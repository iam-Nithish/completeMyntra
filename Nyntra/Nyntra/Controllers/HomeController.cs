using Nyntra.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nyntra.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BeautylandingPage()
        {
            return View();
        }
        public ActionResult MenlandingPage()
        {
            return View();
        }
        public ActionResult WomanlandingPage()
        {
            return View();
        }
        public ActionResult KidslandingPage()
        {
            return View();
        }
        public ActionResult Studio()
        {
            return View();
        }
        public ActionResult HomeLandingPage()
        {
            return View();
        }
        public ActionResult Bag()
        {
            return View();
        }
        public ActionResult DeliveryAdress()
        {
            return View();
        }
        public ActionResult Payment()
        {
            return View();
        }
        public ActionResult selectadress()
        {
            return View();
        }
        public ActionResult success()
        {
            return View();
        }
        public ActionResult wishlist()
        {
            return View();
        }
        //admin page
        public ActionResult AdminPage()
        {
            return View();
        }











        //login page controller
        private MyntraEntities db = new MyntraEntities();
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]

      

        public ActionResult Login(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var loggedInUser = db.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);


                    if (loggedInUser != null)
                    {
                        // Redirect based on user role
                        if (loggedInUser.Role == "Admin")
                        {
                            return RedirectToAction("AdminPage");
                        }
                        else if (loggedInUser.Role == "User")
                        {
                            return RedirectToAction("Index");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid login credentials.");
                    }
                }

                
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message); 
            }
            return View(user);

        }

        //register page controller

        // GET: Register
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        // POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Check if the email already exists
                    var existingUser = db.Users.FirstOrDefault(u => u.Email == user.Email);
                    if (existingUser != null)
                    {
                        ModelState.AddModelError("", "Email already exists. Please choose another one.");
                        return View(user);
                    }

                    // Add new user and save changes
                    db.Users.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("Login");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }


            return View(user);
        }

        //landing pages for mens ,womens and kids

        

    }

}
