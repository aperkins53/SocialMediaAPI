using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAPI.Models
{
    public class LikePostCreate
    {
        [Required]
        public bool IsLiked { get; set; }
        [Required]
        public int PostId { get; set; }
    }
}
