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
    internal class CourseInstConfig : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder.ToTable("Courses_Inst", "dbo");

            builder.HasKey(ci => new { ci.InstructorId, ci.CourseId });

            builder.Property(ci => ci.Evaluate)
                   .HasMaxLength(500);
        }
    }
}
