﻿using Data;
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
                    OwnerId = _userId,
                    Content = model.Content,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Reply.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteReply(int commentId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                // Find the product we want to update
                Reply replyToDelete = ctx.Reply.Find(commentId);
                if (replyToDelete == null)
                {
                    
                }
                ctx.Reply.Remove(replyToDelete);
                return ctx.SaveChanges() == 1;
            }
        }

        public Reply GetReply(int commentId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Comments
                        // refactor so that for a given post, return all likes for this post
                        .Where(e => e.CommentId == commentId)
                        .Select(
                            e =>
                                new ReplyListItem
                                {
                                    PostId = e.PostId,
                                    OwnerId = e.OwnerId,
                                    CreatedUtc = e.CreatedUtc
                                }
                        );
                return entity;
            }
        }
    }
}
