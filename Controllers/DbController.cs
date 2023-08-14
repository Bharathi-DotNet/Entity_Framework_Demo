using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using Multhalvan.data;
using Multhalvan.Models;

namespace Multhalvan.Controllers
{
    public class DbController : Controller
    {
        private readonly MyDbContext _context;
        public DbController(MyDbContext con)
        {
            _context = con;
        }
        //adding  single data
        public IActionResult Add()
        {
            Studets std = new Studets();
            std.age = 1;
            std.Name = "melvin";
            _context.student.Add(std);
            _context.SaveChanges();
            return View();
        }
        //geting single data
        public IActionResult get()
        {
            Studets std = _context.student.Where(s => s.Id == 3).FirstOrDefault();

            ViewBag.name = std.Name;
            return View();
        }

        //geting all data
        public IActionResult GetAll()
        {
            List<Studets> std = new List<Studets>();
            std = _context.student.ToList();
            ViewBag.all = std;

            return View();
        }
        //Update
        public IActionResult Update()
        {
            Studets std = _context.student.Where(s => s.Id == 2).FirstOrDefault();

            std.Name = "vishak";
            _context.student.Update(std);
            _context.SaveChanges();

            return View();
        }
        //Delete the data
        public ActionResult Delete()
        {
            Studets std = _context.student.Where(s => s.Id == 2).FirstOrDefault();

            std.Name = "vishak";
            _context.student.Remove(std);
            _context.SaveChanges();


            return View();
        }

    }



}
