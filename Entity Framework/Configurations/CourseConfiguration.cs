using Entity_Framework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.ID);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Description)
                .IsRequired();

            builder.Property(c => c.DurationHours)
                .IsRequired();

            builder.Property(c => c.Price)
                .IsRequired();

            builder.Property(c => c.Instructors)
                .IsRequired();

            builder.Property(c => c.Reviews)
                .IsRequired();

        }

    }
}
