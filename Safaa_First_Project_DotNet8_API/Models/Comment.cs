namespace Safaa_First_Project_DotNet8_API.Models
{
    public class Comment
    {
           public int Id { get; set; }

        public string Text { get; set; }

        public int Likes { get; set; }

        public DateTime CraeteTime { get; set; }
    }
}
