using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAPI.Models
{
    public class CommentCreate
    {
        [Required]
        [MinLength(3, ErrorMessage = "Please enter at least 3 characters")]
        [MaxLength(140, ErrorMessage = "You've exceeded the maximum character limit of 140 characters. Please shorten your comment.")]
        public string Content { get; set; }
        [Display(Name = "Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        public int PostId { get; set; }
    }
}
