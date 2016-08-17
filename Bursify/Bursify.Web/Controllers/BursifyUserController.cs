﻿using Bursify.Web.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bursify.Api.Security;
using Bursify.Data.EF.Entities.User;
using Bursify.Web.Utility;
using System.Web;
using System.Linq;
using System.IO;

namespace Bursify.Web.Controllers
{
    [System.Web.Mvc.RoutePrefix("api/BursifyUser")]
    public class BursifyUserController : ApiController
    {
        private readonly MembershipApi _membershipApi;

        public BursifyUserController(MembershipApi membershipApi)
        {
            _membershipApi = membershipApi;
        }

        [System.Web.Mvc.AllowAnonymous]
        [System.Web.Mvc.Route("GetUser")]
        public HttpResponseMessage GetUser(HttpRequestMessage request, string email)
        {
            var user = _membershipApi.GetUserByEmail(email);

            var model = new BursifyUserViewModel();

            var userVm = model.MapSingleBursifyUser(user);

            userVm.PasswordHash = null;
            userVm.PasswordSalt = null;

            var response = request.CreateResponse(HttpStatusCode.OK, userVm);

            return response;
        }

        [System.Web.Mvc.AllowAnonymous]
        [System.Web.Mvc.Route("UploadImage")]
        [MimeMultipart]
        public HttpResponseMessage UploadImage(HttpRequestMessage request, int userId)
        {
            var user = _membershipApi.GetUserById(userId);

            if (user == null) return null;

            //var userDirectory = new FileInfo("~/Content/BursifyUploads/" + userId + "/images");

            var imagePath = HttpContext.Current.Server.MapPath("~/Content/BursifyUploads/images");

            var multipartFormDataStreamProvider = new UploadMultipartFormProvider(imagePath);

            // Read the MIME multipart asynchronously 
            Request.Content.ReadAsMultipartAsync(multipartFormDataStreamProvider);

            var localFileName = multipartFormDataStreamProvider
                .FileData.Select(multiPartData => multiPartData.LocalFileName).FirstOrDefault();

            // Create response
            if (localFileName == null) return null;
            var fileUploadResult = new FileUploadResult
            {
                LocalFilePath = localFileName,

                FileName = Path.GetFileName(localFileName),

                FileLength = new FileInfo(localFileName).Length
            };

            // update database
            user.ProfilePicturePath = fileUploadResult.FileName;

            _membershipApi.UpdateUser(user);

            var response = request.CreateResponse(HttpStatusCode.OK, fileUploadResult);

            return response;
        }

    }
}