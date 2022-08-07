using TodayILearnedApi.Models;

namespace TodayILearnedApi.Services
{
    public interface IPostsService
    {
        List<Post> Search(string query);
        Post GetPostById(int id);
        Post GetPostByOption(GetPostOptions option);
        int CreatePost(Post post);
        void UpdatePost(Post post);
        void DeletePost(int id);
    }

    // TODO: Call DB
    public class PostsService : IPostsService
    {
        private Post mockPost = new Post(1, "Hummingbirds", "Hummingbirds are the only birds that can fly backwards");

        public List<Post> Search(string query)
        {
            
            return new List<Post>()
            {
                mockPost
            };
        }

        public Post GetPostById(int id)
        {
            return mockPost;
        }

        public Post GetPostByOption(GetPostOptions option)
        {
            return mockPost;
        }

        public int CreatePost(Post post)
        {
            return 2;
        }

        public void UpdatePost(Post post)
        {
            // Do Nothing;
        }

        public void DeletePost(int id)
        {
            // Do Nothing;
        }
    }
}
