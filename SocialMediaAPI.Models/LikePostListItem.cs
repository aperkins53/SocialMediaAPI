using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAPI.Models
{
    public class ReplyListItem
    {
        public Guid OwnerId { get; set; }
        public bool IsLiked { get; set; }
        public int PostId { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }

    }
}
