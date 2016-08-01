﻿using System;
using Bursify.Data.EF.SponsorUser;
using Bursify.Data.EF.StudentUser;

namespace Bursify.Data.EF.User
{
    public class StudentSponsorship : IEntity
    {
        public int ID { get; set; }
        public int StudentId { get; set; }
        public int SponsorshipId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public bool IsSponsorshipOfferd { get; set; } 
        public string SponsorshipConfirmed { get; set; }

        public virtual Student Student { get; set; }
        public virtual Sponsorship Sponsorship { get; set; }       
    }
}