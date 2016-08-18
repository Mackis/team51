﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Bursify.Data.EF.Entities.StudentUser;
using Bursify.Data.EF.Entities.User;

namespace Bursify.Data.EF.EntityMappings
{
    public class SubjectMapping : EntityTypeConfiguration<Subject>
    {
        public SubjectMapping()
        {
            this.ToTable("Subject", "dbo");

            this.HasKey(x => x.ID);

            this.Property(x => x.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(x => x.Name)
                .HasMaxLength(200)
                .IsOptional();

            this.Property(x => x.SubjectLevel)
                .IsOptional();

            this.Property(x => x.Period).IsOptional();

            this.HasMany(x => x.StudentSubjects);

            this.HasMany(x => x.Requirements);
        }
    }
}