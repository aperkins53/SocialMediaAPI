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
    public class PostController : ApiController
    { 
            public IHttpActionResult Get()
            {
                PostServices postService = CreatePostService();
            var notes = postService.GetPost();
                return Ok(notes);
            }
            public IHttpActionResult Post(PostCreate post)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var service = CreatePostService();

                if (!service.CreatePost(post))
                    return InternalServerError();

                return Ok();
            }
            private PostServices CreatePostService()
            {
                var userId = Guid.Parse(User.Identity.GetUserId());
                var noteService = new PostServices(userId);
                return noteService;
            }
        }
    }

