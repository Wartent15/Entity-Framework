using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Entities
{
    public class Review
    {
        public int ID { get; set; }

        public int CourseID { get; set; }
        public Course Course { get; set; }

        public int StudentID { get; set; }
        public Student Student { get; set; }
        public int Rating { get; set; }
    }
}
