using C42_G01_EF02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF02.Configrations
{
    internal class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors", "dbo");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(i => i.Address)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(i => i.Bonus);

            builder.Property(i => i.Salary)
                   .IsRequired();

            builder.Property(i => i.HourlyRate)
                   .IsRequired();


        }
    }
}
