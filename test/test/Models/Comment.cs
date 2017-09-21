namespace test.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Title { get; set; }
        public string SiteUrl { get; set; }
        public string Description { get; set; }

        public Fan Fan { get; set; }
        public Post ReferencedPost { get; set; }
    }
}