

using Bursify.Data.EF.Entities.StudentUser;
using System;
using System.Collections.Generic;
using System.Linq;
using Bursify.Data.EF.Entities.User;
using Bursify.Data.EF.Entities.Bridge;

namespace Bursify.Web.Models
{
    public class StudentViewModel
    {
        public int ID { get; set; }
        public int InstitutionID { get; set; }
        public string IDNumber { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string EducationLevel { get; set; }
        public int AverageMark { get; set; }
        public string StudentNumber { get; set; }
        public int Age { get; set; }
        public bool HasDisability { get; set; }
        public string DisabilityDescription { get; set; }
        public string Race { get; set; }
        public string Gender { get; set; }
        public string CurrentOccupation { get; set; }
        public string StudyField { get; set; }
        public string HighestAcademicAchievement { get; set; }
        public long YearOfAcademicAchievement { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int NumberOfViews { get; set; }
        public string Essay { get; set; }
        public string GuardianPhone { get; set; }
        public string GuardianRelationship { get; set; }
        public string GuardianEmail { get; set; }
        public string IDDocumentPath { get; set; }
        public string MatricCertificatePath { get; set; }
        public string CVPath { get; set; }
        public bool AgreeTandC { get; set; }

        public StudentViewModel()
        {
            //default
        }

        public StudentViewModel(Student s)
        {
            MapSingleStudent(s);
        }

        public StudentViewModel MapSingleStudent(Student student)
        {
            ID = student.ID;
            InstitutionID = student.InstitutionID;
            Firstname = student.Firstname;
            Surname = student.Surname;
            EducationLevel = student.EducationLevel;
            AverageMark = student.AverageMark;
            StudentNumber = student.StudentNumber;
            IDNumber = student.IDNumber;
            Age = student.Age;
            HasDisability = student.HasDisability;
            DisabilityDescription = student.DisabilityDescription;
            Race = student.Race;
            Gender = student.Gender;
            CurrentOccupation = student.CurrentOccupation;
            StudyField = student.StudyField;
            HighestAcademicAchievement = student.HighestAcademicAchievement;
            YearOfAcademicAchievement = student.YearOfAcademicAchievement;
            DateOfBirth = student.DateOfBirth;
            NumberOfViews = student.NumberOfViews;
            Essay = student.Essay;
            GuardianPhone = student.GuardianPhone;
            GuardianEmail = student.GuardianEmail;
            GuardianRelationship = student.GuardianRelationship;
            IDDocumentPath = student.IDDocumentPath;
            MatricCertificatePath = student.MatricCertificatePath;
            CVPath = student.CVPath;
            AgreeTandC = student.AgreeTandC;
           
            return this;
        }

        public Student ReverseMap()
        {
            return new Student()
            {
                ID = this.ID,
                InstitutionID = this.InstitutionID,
                Firstname = this.Firstname,
                Surname = this.Surname,
                EducationLevel = this.EducationLevel,
                AverageMark = this.AverageMark,
                StudentNumber = this.StudentNumber,
                IDNumber = this.IDNumber,
                Age = this.Age,
                HasDisability = this.HasDisability,
                DisabilityDescription = this.DisabilityDescription,
                Race = this.Race,
                Gender = this.Gender,
                CurrentOccupation = this.CurrentOccupation,
                StudyField = this.StudyField,
                HighestAcademicAchievement = this.HighestAcademicAchievement,
                YearOfAcademicAchievement = this.YearOfAcademicAchievement,
                DateOfBirth = this.DateOfBirth,
                NumberOfViews = this.NumberOfViews,
                Essay = this.Essay,
                GuardianPhone = this.GuardianPhone,
                GuardianEmail = this.GuardianEmail,
                GuardianRelationship = this.GuardianRelationship,
                IDDocumentPath = this.IDDocumentPath,
                MatricCertificatePath = this.MatricCertificatePath,
                CVPath = this.CVPath,
                AgreeTandC = this.AgreeTandC
               
            };
        }

        public static List<StudentViewModel> MapMultipleStudents(List<Student> students)
        {
            List<StudentViewModel> studentsVM = new List<StudentViewModel>();
            foreach (var s in students)
            {
                StudentViewModel sVm = new StudentViewModel(s);
                studentsVM.Add(sVm);
            }
            return studentsVM;
        }
    }
}