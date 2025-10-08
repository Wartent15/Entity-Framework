using Entity_Framework.Configurations;
using Entity_Framework.Entities;
using Entity_Framework.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Services
{
    public class InstructorServices
    {
        private readonly InstructorRepository _InstructorRepository;

        public InstructorServices(SchoolContext db)
        {
            _InstructorRepository = new InstructorRepository(db);
        }

        public async Task AddAsync(Instructor Instructor)
        {
            if (Instructor == null)
            {
                throw new ArgumentNullException(nameof(Instructor));
            }

            var ins = _InstructorRepository.GetByFullNameAsync(Instructor.FirstName, Instructor.LastName, Instructor.Patronymic);

            if (ins != null)
            {
                throw new Exception($"Преподаватель с таким именем {Instructor.FirstName} уже существует");
            }
            await _InstructorRepository.AddAsync(Instructor);
        }

        public async Task RemoveAsync(Instructor Instructor)
        {
            if (Instructor == null)
            {
                throw new ArgumentNullException(nameof(Instructor));
            }

            var ins = _InstructorRepository.GetByFullNameAsync(Instructor.FirstName, Instructor.LastName, Instructor.Patronymic);

            if (ins == null)
            {
                throw new Exception($"Преподавателя с таким именем {Instructor.FirstName} не  существует");
            }

            await _InstructorRepository.RemoveAsync(Instructor);
        }

        public async Task UpdateAsync(Instructor Instructor)
        {
            if (Instructor == null)
            {
                throw new ArgumentNullException(nameof(Instructor));
            }

             var ins = _InstructorRepository.GetByFullNameAsync(Instructor.FirstName, Instructor.LastName, Instructor.Patronymic);

            if (ins != null)
            {
                throw new Exception($"Преподаватель с таким именем {Instructor.FirstName} обновлен");
            }

            await _InstructorRepository.UpdateAsync(Instructor);
        }

        public async Task<List<Instructor>> GetAllAsync()
        {
            var Instructors = await _InstructorRepository.GetAllAsync();
            return Instructors;
        }


    }
}

