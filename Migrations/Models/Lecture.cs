using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations.Models
{
    public class Lecture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string LectureRoom { get; set; } = null!;

        [Required]
        public int SubjectId { get; set; }

        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; } = null!;

        [Required]
        public int TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; } = null!;

        public List<Group> Groups { get; set; } = new();
    }
}
