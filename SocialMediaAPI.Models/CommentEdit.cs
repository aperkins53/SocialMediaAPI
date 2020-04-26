using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAPI.Models
{
    public class CommentEdit
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
