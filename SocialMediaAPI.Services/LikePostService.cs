﻿using Data;
using SocialMediaAPI.Data;
using SocialMediaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAPI.Services
{
    public class LikePostService
    {
        private readonly Guid _userId;

        public LikePostService(Guid userId)
        {
            _userId = userId;
        }


        public bool LikePost(LikePost postToLike)
        {
            var entity =
                new LikePost()
                {
                    OwnerId = _userId,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.LikePost.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<ReplyListItem> GetPostLikes()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Reply
                        // refactor so that for a given post, return all likes for this post
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new ReplyListItem
                                {
                                    CommentId = e.CommentId, 
                                    OwnerId = e.OwnerId,
                                    CreatedUtc = e.CreatedUtc
                                }
                        );
                return query.ToArray();
            }
        }
    }
}
