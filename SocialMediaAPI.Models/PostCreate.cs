using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAPI.Models
{
    public class PostCreate
    {
        [Required]
        [MinLength(1, ErrorMessage = "Please enter at least 1 character")]
        [MaxLength(140, ErrorMessage = "You've exceeded the maximum character limit of 140 characters. Please shorten your post.")]
        public string Content { get; set; }
        public string Title { get; set; }
    }
}
