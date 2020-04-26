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
        [MinLength(1, ErrorMessage = "Please enter at least 1 character")]
        [MaxLength(140, ErrorMessage = "You've exceeded the maximum character limit of 140 characters. Please shorten your comment.")]
        public string Content { get; set; }
    }
}
