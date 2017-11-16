using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class MyController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult registerForm(string name, string email, string username, string password, string cpassword)
        {
            return View(new Members(name, username, password, email, cpassword));
        }
        public ActionResult loginForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult loginForm(string username, string password)
        {
            bool flag = false;
            foreach (Members m in Members.mList)
            {
                if(username == m.userName && password == m.passWord)
                {
                    //send the other page
                    m.state = "User has been found.";
                    View(m);
                    flag = true;
                    break;
                }
            }
            if(!flag)
            {
                View();
            }
            return View();
        }
    }
}
