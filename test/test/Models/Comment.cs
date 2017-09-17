namespace test.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public Post Post { get; set; }
        public string Title { get; set; }
        public Fan Fan { get; set; }
        public string SiteUrl { get; set; }
        public string Description { get; set; }
    }
}