﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations.Models
{

    public class Faculty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "money")]
        [Range(0, double.MaxValue)]
        public decimal Financing { get; set; } = 0;

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        public List<Department> Departments { get; set; } = new();
    }
}
