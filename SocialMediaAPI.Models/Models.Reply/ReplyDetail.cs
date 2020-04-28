using System;

namespace SocialMediaAPI.Models
{
    public class ReplyDetail
    {
        public Guid OwnerId { get; set; }
        public bool IsLiked { get; set; }
        public int CommentId { get; set; }
        public string Content { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
