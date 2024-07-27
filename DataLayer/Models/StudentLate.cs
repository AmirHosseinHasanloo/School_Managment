using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class StudentLate
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string LateDate { get; set; }

        //navigation property
        [ForeignKey("StudentId")]
        public Student? Student { get; set; }
    }
}
