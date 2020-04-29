using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class LikePost
    {
        [Required]
        public Guid OwnerId { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        [Key]
        public int LikePostId { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
