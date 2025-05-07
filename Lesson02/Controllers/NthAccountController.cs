using Lesson02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace Lesson02.Controllers
{
    public class NthAccountController : Controller
    {
        public IActionResult NthIndex()
        {
            List<NthAccount> accounts = new List<NthAccount>
            {
                new NthAccount
                {
                    Id = 1,
                    Name = "Trong Hung",
                    Email = "tronghung122005@gmail.com",
                    Phone = "0329930596",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/Avatar/avt1.webp"),
                    Gender = 1,
                    Bio = "My name is Hung",
                    Birthday = new DateTime(2005, 1, 2)
                },
                new NthAccount
                {
                    Id = 2,
                    Name = "Long Lanh",
                    Email = "longlanh@example.com",
                    Phone = "0329930000",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/Avatar/avt2.webp"),
                    Gender = 1,
                    Bio = "My name is Long",
                    Birthday = new DateTime(2005, 4, 2)
                },
                new NthAccount
                {
                    Id = 3,
                    Name = "Lung Linh",
                    Email = "lunglinh@example.com",
                    Phone = "0329939999",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/Avatar/avt3.webp"),
                    Gender = 1,
                    Bio = "My name is Linh",
                    Birthday = new DateTime(2005, 3, 2)
                }
            };
            ViewBag.Accounts = accounts;
            return View();
        }
        public IActionResult NthProfile()
        {
            NthAccount account = new NthAccount()
            {
                Id = 1,
                Name = "Trong Hung",
                Email = "tronghung122005@gmail.com",
                Phone = "0329930596",
                Address = "Ha Noi",
                Avatar = Url.Content("~/Avatar/avt1.webp"),
                Gender = 1,
                Bio = "My name is Hung",
                Birthday = new DateTime(2005, 1, 2)
            };

            ViewBag.account = account;
            return View();
        }
    }
}
