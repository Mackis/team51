﻿using AutoMapper;
using Bursify.Entities;
using Bursify.Entities.UserEntities;
using Bursify.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bursify.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
           //
        }
    }
}