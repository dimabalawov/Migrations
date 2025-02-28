using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations.Models
{
    public class GroupLecture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int GroupId { get; set; }

        [Required]
        public int LectureId { get; set; }

        [ForeignKey("GroupId")]
        public Group Group { get; set; } = null!;

        [ForeignKey("LectureId")]
        public Lecture Lecture { get; set; } = null!;
    }
}
