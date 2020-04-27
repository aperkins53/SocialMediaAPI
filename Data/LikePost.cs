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
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        [Key]
        public int LikePostId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        // One to many relationship. One Post can have many comments.
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
