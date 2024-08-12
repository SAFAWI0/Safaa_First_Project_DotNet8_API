using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Safaa_First_Project_DotNet8_API.Data;
using Safaa_First_Project_DotNet8_API.DTOs;
using Safaa_First_Project_DotNet8_API.Models;

namespace Safaa_First_Project_DotNet8_API.Controllers;

[Route("api/[controller]/[Action]")]
[ApiController]
public class UsersController : Controller
{
    private readonly ApplicationDbContext _context;

    public UsersController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    
    public IActionResult GetUsers()
    {
        List<User> AllUsers = _context.Users.ToList();
        return Ok(AllUsers);
    }

    [HttpGet]
    
    public IActionResult GetUserById(int id)
    {
       
        User user2 = _context.Users.FirstOrDefault((User user) => user.UserId == id);
        if (user2 == null)
        {
            return NotFound("No User Founded !");
        }
        return Ok(user2);
    }

    [HttpPost]
   
    public IActionResult AddNewUser( UserDTO userDTO)
    {
        User User = new User
        {
            Name = userDTO.Name,
            Age = userDTO.Age,
            Email = userDTO.Email,
            Password = userDTO.Password
        };
        _context.Users.Add(User);
        _context.SaveChanges();
        return Ok("User Created Succesfully !");
    }

    [HttpDelete]
   
    public IActionResult DeleteUser(int? id)
    {
        if (!id.HasValue)
        {
            return BadRequest();
        }
        var user = _context.Users.FirstOrDefault((User u) => (int?)u.UserId == id);
        _context.Users.Remove(user);
        _context.SaveChanges();
        return Ok("User Deleted Succesfully");
    }

    [HttpPut]
   
    public IActionResult UpdateUser(int? id,UserDTO userDTO)
    {
        var user = _context.Users.FirstOrDefault(u=> u.UserId == id);

        user.Name = userDTO.Name;
        user.Email = userDTO.Email;
        user.Password = userDTO.Password;
        user.Age = userDTO.Age;

        _context.Users.Update(user);
        _context.SaveChanges();
        return Ok("User Update Succesfully");
    }
}
