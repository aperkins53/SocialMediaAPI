using Data;
using Microsoft.AspNet.Identity;
using SocialMediaAPI.Models;
using SocialMediaAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TeamCAJESocialMediaAPI.Controllers
{
    public class LikePostController : ApiController
    {
        private LikePostService CreateLikePostService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var likePostService = new LikePostService(userId);
            return likePostService;
        }

        public IHttpActionResult Get()
        {
            LikePostService likePostService = CreateLikePostService();
            var likes = likePostService.GetPostLikes();
            return Ok(likes);
        }

        public IHttpActionResult Post(LikePost postToLike)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateLikePostService();

            if (!service.LikePost(postToLike))
                return InternalServerError();

            return Ok();
        }
    }

}
