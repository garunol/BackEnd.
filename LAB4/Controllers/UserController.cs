using Microsoft.AspNetCore.Mvc;
using LAB4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB4.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>()
        {
            new User() {id="1",username="aaa",password="1",phone="111",email="111"},
            new User() {id="2",username="aaa",password="1",phone="111",email="111"},
            new User() {id="3",username="aaa",password="1",phone="111",email="111"},
            new User() {id="4",username="aaa",password="1",phone="111",email="111"},
            new User() {id="5",username="aaa",password="1",phone="111",email="111"},
        };

        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    users.Add(user);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(user);
        }
        [HttpGet]
        public IActionResult Edit(string id)
        {
            var user = users.FirstOrDefault(u => u.id == id);
            if (user == null)
                return NotFound();
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = users.FirstOrDefault(u => u.id == user.id);
                if (existingUser != null)
                {
                    existingUser.username = user.username;
                    existingUser.password = user.password;
                    existingUser.email = user.email;
                    existingUser.phone = user.phone;
                }
                return RedirectToAction("Index");
            }
            return View(user);
        }
        [HttpGet]
        public IActionResult Delete(string id)
        {
            var user = users.FirstOrDefault(u => u.id == id);
            if (user != null)
            {
                users.Remove(user);
            }
            return RedirectToAction("Index");
        }



    }
}
