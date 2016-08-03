﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Bursify.Data.EF.Entities.Bridge;
using Bursify.Data.EF.Entities.StudentUser;
using Bursify.Data.EF.Entities.User;

namespace Bursify.Data.EF.EntityMappings
{
    public class StudentSponsorshipMapping : EntityTypeConfiguration<StudentSponsorship>
    {
        public StudentSponsorshipMapping()
        {
            this.ToTable("StudentSponsorship", "dbo");

            this.HasKey(x => new { x.StudentId, x.SponsorshipId });

            this.Property(x => x.StudentId)
                .IsRequired();

            this.Property(x => x.SponsorshipId)
                .IsRequired();

            this.Property(x => x.ApplicationDate)
                .IsRequired();

            this.Property(x => x.Status)
                .IsRequired();

            this.Property(x => x.SponsorshipOffered).IsRequired();

            this.HasRequired(x => x.Student)
                .WithMany(s => s.StudentSponsorships)
                .HasForeignKey(f => f.StudentId);

            this.HasRequired(x => x.Sponsorship)
                .WithMany(s => s.StudentSponsorships)
                .HasForeignKey(f => f.SponsorshipId);
        }
    }
}
