using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations.Models
{
    public class GroupCurator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int CuratorId { get; set; }

        [Required]
        public int GroupId { get; set; }

        [ForeignKey("CuratorId")]
        public Curator Curator { get; set; } = null!;

        [ForeignKey("GroupId")]
        public Group Group { get; set; } = null!;
    }
}
