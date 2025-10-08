using Entity_Framework.Entities;
using Entity_Framework.Configurations;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework.Repositories
{
    public class InstructorRepository
    {
        private readonly SchoolContext _db;

        public InstructorRepository(SchoolContext db)
        {
            _db = db;
        }

        public async Task AddAsync(Instructor instructor)
        {
            await _db.Instructors.AddAsync(instructor);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveAsync(Instructor instructor)
        {
            _db.Instructors.Remove(instructor);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(Instructor instructor)
        {
            _db.Instructors.Update(instructor);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Instructor>> GetAllAsync()
        {
            var instructors = await _db.Instructors.ToListAsync();
            return instructors;
        }

        public async Task<Instructor> GetByIdAsync(int id)
        {
            var instructor = await _db.Instructors.FindAsync(id);
            return instructor;
        }

        public async Task<Instructor> GetByFullNameAsync(string firstname, string lastname, string patronymic)
        {
            var instructor = await _db.Instructors.FirstOrDefaultAsync(i => i.FirstName == firstname && i.LastName == lastname && i.Patronymic == patronymic);
            return instructor;
        }
    }
}