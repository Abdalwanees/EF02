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
    internal class StudCourseConfig : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            builder.ToTable("Stud_Courses", "dbo");
            builder.HasKey(sc => new { sc.StudentId, sc.CourseId });
            builder.Property(sc => sc.Grade)
                   .HasMaxLength(2);
        }
    }
}
