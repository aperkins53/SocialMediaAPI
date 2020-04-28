using Data;
using SocialMediaAPI.Data;
using SocialMediaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;

namespace SocialMediaAPI.Services
{
    public class ReplyService
    {
        private readonly Guid _userId;
        public ReplyService(Guid userId)
        {
            _userId = userId;
        }

      
        public bool CreateReply(ReplyCreate model)
        {
            var entity =
                new Reply()
                {
                    Content = model.Content,
                    CommentId = model.CommentId,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Reply.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //public bool DeleteReply(int commentId)
        //{
        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        // Find the product we want to update
        //        Reply replyToDelete = ctx.Reply.Find(commentId);
        //        if (replyToDelete == null)
        //        {
                    
        //        }
        //        ctx.Reply.Remove(replyToDelete);
        //        return ctx.SaveChanges() == 1;
        //    }
        //}

        public bool DeleteReply(int replyId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Reply
                        .Single(e => e.ReplyId == replyId);

                ctx.Reply.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }

        public string GetReply(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Comments
                        .Single(e => e.CommentId == id);
                return entity.Content;
            }
        }
    }
}
