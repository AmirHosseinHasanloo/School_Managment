using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string NationalityCode { get; set; }
        public string FatherPhone { get; set; }
        public string MotherPhone { get; set; }
        public string StudentPhone { get; set; }
        public string HousePhone { get; set; }
        public string ClassNumber { get; set; }
        public string Level { get; set; }
        public string CourseField { get; set; }
        public string HowMuchPaid { get; set; }

        //navigation properties
        public ICollection<StudentCrime> StudentCrimes { get; set; } = new List<StudentCrime>();
        public ICollection<StudentLate> StudentLates { get; set; } = new List<StudentLate>();
    }
}
