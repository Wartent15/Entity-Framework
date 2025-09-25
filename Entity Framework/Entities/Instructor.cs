using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Entities
{
    public class Instructor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }

        public int CourseID { get; set; }
        public Course Course { get; set; }
    }
}
