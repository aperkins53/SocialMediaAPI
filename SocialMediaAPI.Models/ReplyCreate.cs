using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAPI.Models
{
    public class ReplyCreate
    {
        [Required]
        public string Content { get; set; }
        public int CommentId { get; set; }
    }
}
