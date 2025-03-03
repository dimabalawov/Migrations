using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Surname { get; set; } = null!;

        [Required]
        [Column(TypeName = "money")]
        [Range(0.01, double.MaxValue)]
        public decimal Salary { get; set; }

        public List<Lecture> Lectures { get; set; } = new();
        public Assistant Assistant { get; set; }
        public Head Head { get; set; }
        public Dean Dean { get; set; }
    }
}
