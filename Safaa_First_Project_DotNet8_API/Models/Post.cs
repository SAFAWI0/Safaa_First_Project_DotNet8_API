using System.ComponentModel.DataAnnotations.Schema;

namespace Safaa_First_Project_DotNet8_API.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title    { get; set; }
        public string Description { get; set; }


        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }



        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
