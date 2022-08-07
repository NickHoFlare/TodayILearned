namespace TodayILearnedApi.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get;set; }
        public string? BlogPost { get; set; }
        public List<string>? Tags { get; set; }
        public ExternalInfo? ExternalInfo { get; set; }

        public Post(int id, string title, string description) => 
            (Id, Title, Description) = (id, title, description);

        public void Deconstruct(out string title, out string description, out string? blogPost, out List<string>? tags, out ExternalInfo? externalInfo) =>
            (title, description, blogPost, tags, externalInfo) = (Title, Description, BlogPost, Tags, ExternalInfo);
    }

    public class ExternalInfo
    {
        public List<string>? Urls { get; set; }
        public List<string>? Other { get; set; }
    }

    public enum GetPostOptions
    {
        Random, Latest
    }
}
