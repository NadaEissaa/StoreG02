using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEFC.Entitites
{
    // Mapping using Data Annotations
    public class Instructor
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        public string Address { get; set; } = string.Empty;

        public decimal HourRateBonus { get; set; }

        public int Dept_ID { get; set; } 
    }

}
