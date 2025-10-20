using Entity_Framework.Configurations;
using Entity_Framework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    public class SchoolContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Review> Reviews { get; set; }

        private readonly string _connectionString = "Server=myServerAddress;Database=RestaurantDb;Trusted_Connection=True;TrustServerCertificate=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //FluentAPI
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new InstructorConfiguration());
            modelBuilder.ApplyConfiguration(new ReviewConfiguration());
        }

        internal object GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        internal async Task RemoveAsync(Course course)
        {
            throw new NotImplementedException();
        }

        internal async Task UpdateAsync(Course course)
        {
            throw new NotImplementedException();
        }

        internal async Task<List<Course>> ToListAsync()
        {
            throw new NotImplementedException();
        }

        internal object GetByFullNameAsync(string firstName, string lastName, string patronymic)
        {
            throw new NotImplementedException();
        }

        internal async Task RemoveAsync(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        internal async Task UpdateAsync(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        internal async Task RemoveAsync(Student student)
        {
            throw new NotImplementedException();
        }

        internal async Task UpdateAsync(Student student)
        {
            throw new NotImplementedException();
        }

        internal object GetByRatingAsync(int rating)
        {
            throw new NotImplementedException();
        }

        internal async Task RemoveAsync(Review review)
        {
            throw new NotImplementedException();
        }

        internal async Task UpdateAsync(Review review)
        {
            throw new NotImplementedException();
        }

        internal async Task<List<Review>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
