﻿using System.Collections.Generic;
using Bursify.Data.EF.Entities.StudentUser;

namespace Bursify.Data.EF.Entities.User
{
    public class StudentReport : IEntity
    {
        public StudentReport()
        {
            Subjects = new List<Subject>();
        }

        public int ID { get; set; }
        public int StudentId { get; set; }
        public int Average { get; set; }
        public string ReportLevel { get; set; }
        public string ReportPeriod { get; set; }
        public string ReportInstitution { get; set; }
        
        public virtual Student Student { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }
}
