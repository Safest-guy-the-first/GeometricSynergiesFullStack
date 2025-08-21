using System;
using Microsoft.AspNetCore.Mvc;
using GeoSys_backend.Data;
using GeoSys_backend.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
namespace GeoSys_backend.Controllers
{
    [Route("gs/[controller]")]
    [ApiController]
    public class UserModelController : Controller
    {
        private GeoSynDbContext _db;
        public UserModelController(GeoSynDbContext db) { _db = db; }

        //GET requests: returns info 
        [HttpGet]
        public ActionResult<List<UserModel>> GetUser()
        {
            return  Ok(_db.UsersTable.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<UserModel> GetUserById(int id) 
        {
            /*var userById =  _db.UsersTable.Select();*//*//need to fix this
            if (userById == null) { return NotFound(); }
            return Ok(userById);*/
        }


        //post requests:: send info to the api 
        [HttpPost]
        public IActionResult AddUsers([FromBody] UserModel newUser)
        {
            if (newUser == null) { return BadRequest("Data Is Required"); }
            _db.UsersTable.Add(newUser);
            newUser.uniqueUserId =
                newUser.FirstName.Substring(0, 2).ToLower() + newUser.LastName.Substring(0, 2).ToLower() + newUser.id.Substring(5, 2).ToLower();


            _db.SaveChanges();
            return Ok(newUser);
            /*return CreatedAtAction(nameof(newUser), newUser);*/ //create a getuserbyid 
        }


        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
