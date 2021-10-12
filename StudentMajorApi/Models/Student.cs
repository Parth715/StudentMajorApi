using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMajorApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(30), Required]
        public string Firstname { get; set; }
        [StringLength(30), Required]
        public string Lastname { get; set; }
        [StringLength(2), Required]
        public string StateCode { get; set; }
        [Required]
        public int Sat { get; set; }
        [Column(TypeName = "decimal(1,2")]
        public Decimal Gpa { get; set; }
        public int MajorId { get; set; }
        public virtual Major Major { get; set; }

        public Student() { }
    }
}
