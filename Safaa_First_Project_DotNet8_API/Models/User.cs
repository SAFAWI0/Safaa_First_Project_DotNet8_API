namespace Safaa_First_Project_DotNet8_API.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? Age { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
