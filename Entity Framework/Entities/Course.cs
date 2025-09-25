using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Entities
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public int DurationHours { get; set; }
        public decimal Price { get; set; }

        public ICollection<Instructor> Instructors { get; set; }

        public ICollection<Review> Reviews { get; set; }

    }

}
