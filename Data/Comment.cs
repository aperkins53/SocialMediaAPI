using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        [MaxLength(140, ErrorMessage ="You've exceeded the character limit of 140 characters.")]
        public string Content { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        // One to many relationship. One Post can have many comments.
        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }

    }
}
