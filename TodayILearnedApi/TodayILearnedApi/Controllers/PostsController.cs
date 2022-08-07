using Microsoft.AspNetCore.Mvc;
using TodayILearnedApi.Models;
using TodayILearnedApi.Services;

namespace TodayILearnedApi.Controllers
{
    [ApiController]
    [Route("api/posts")]
    public class PostsController : ControllerBase
    {
        private readonly ILogger<PostsController> _logger;
        private readonly IPostsService _postsService;

        public PostsController(ILogger<PostsController> logger, IPostsService postsService)
        {
            _logger = logger;
            _postsService = postsService;
        }

        // api/posts?q=<searchTerms>
        [HttpGet(Name = "GetPostSearchResults")]
        public ActionResult<List<Post>> GetPostSearchResults(string q)
        {
            return Ok(_postsService.Search(q));
        }

        // api/posts
        [HttpPost(Name = "CreatePost")]
        public ActionResult<int> CreatePost(Post post)
        {
            return Ok(_postsService.CreatePost(post));
        }

        // api/posts/{id}
        [HttpGet("{id}", Name = "GetPostById")]
        public ActionResult<Post> GetPostById(int id)
        {
            return Ok(_postsService.GetPostById(id));
        }

        // api/posts/{id}
        [HttpPut("{id}", Name = "UpdatePost")]
        public ActionResult UpdatePost(Post post)
        {
            _postsService.UpdatePost(post);
            return Ok();
        }

        // api/posts/{id}
        [HttpDelete("{id}", Name = "DeletePost")]
        public ActionResult DeletePost(Post post)
        {
            _postsService.UpdatePost(post);
            return Ok();
        }

        // api/posts/latest
        [HttpGet("latest", Name = "GetLatestPost")]
        public ActionResult<Post> GetLatestPost()
        {
            return Ok(_postsService.GetPostByOption(GetPostOptions.Latest));
        }

        // api/posts/random
        [HttpGet("random", Name = "GetRandomPost")]
        public ActionResult<Post> GetRandomPost()
        {
            return Ok(_postsService.GetPostByOption(GetPostOptions.Random));
        }
    }
}