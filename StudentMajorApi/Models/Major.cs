using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMajorApi
{
    public class Major
    {
        public int Id { get; set; }
        [StringLength(10), Required]
        public string Code { get; set; }
        [StringLength(30), Required]
        public string Description { get; set; }
        public int MinSat { get; set; }

        public Major() { }
    }
}
