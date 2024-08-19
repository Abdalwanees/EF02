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
    internal class TopicConfig : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.ToTable("Topics", "dbo");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name)
                   .IsRequired()
                   .HasMaxLength(100);


        }
    }
}
