using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAPI.Models
{
    public class PostUpdate
    {
        public string UpdateTitle { get; set; }
        public string UpdateContent { get; set; }

        public int PostId { get; set; }
    }
}
