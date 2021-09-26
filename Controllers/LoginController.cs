using Employee_Microservice.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Okta.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Microservice.Controllers
{
   
    public class LoginController : Controller
    {
        Dbclass db = new Dbclass();
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login([Bind] Login lg)
        {
            int res = db.LoginCheck(lg);
            if (res == 1)
            {
              //  TempData["msg"] = "You are welcome to Admin Section";
                return RedirectToAction("Index", "Employees");
            }
            else
            {
                TempData["msg"] = "Admin id or Password is wrong.!";
                return RedirectToAction("Login", "Login");
            }
            

        }

       


    }
}
