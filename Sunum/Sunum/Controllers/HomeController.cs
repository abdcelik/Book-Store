using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FusionBookieDB.Entity;
using FusionBookieDB;

namespace Sunum.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        [Route("pg={pg?}")]
        public ActionResult HomePage(int pg = 1)
        {
            List<Book> bookList ;
            bookList = BookStoreServices.Filter(new int[0], null);
            ViewBag.pg_max = BookStoreServices.PageMax(bookList);
            bookList = BookStoreServices.GetPageBooks(bookList, pg);
            ViewBag.pg = pg;

            if (pg > ViewBag.pg_max)
                return View("Error");

            return View(bookList);
        }
        
        [HttpGet]
        public ActionResult ProductDetail(string productName,int productID)
        {
            Book currB = BookStoreServices.GetBook(productID);
            
            if(currB == null)
                return View("Error");

            return View(currB);
        }

        [HttpGet]
        [Route("Search")]
        public ActionResult Search(string q, int[] catID, int pg = 1)
        {
            List<Book> currBooks = BookStoreServices.Filter(catID,q);

            ViewBag.q = q;
            ViewBag.pg = pg;
            ViewBag.pg_max = BookStoreServices.PageMax(currBooks);
            ViewBag.selectedCats = catID;

            if (pg > ViewBag.pg_max && pg>1)
                return View("Error");

            return View(currBooks);
        }
      
  
        [HttpGet]
        [Route("Cart")]
        public ActionResult Cart(int pg = 1)
        {
            List<Sunum.Models.Book> b = new List<Sunum.Models.Book>();

            for (int i = 0; i < 10; i++)
            {
                b.Add(new Sunum.Models.Book(productID_: i + 1, name_: "Olasılıksız", author_: "Adam Fawer",
                    price_: 18.99, photourl_: "/images/olasiliksiz-adam-fawer.jpg", user_: null, tags_: null, summary_: null));
            }

            ViewBag.pg = pg;
            ViewBag.pg_max = 7;

            return View(b);
        }

        [HttpGet]
        [Route("MyOrders")]
        public ActionResult MyOrders(int pg = 1)
        {
            List<Sunum.Models.Book> b = new List<Sunum.Models.Book>();

            for (int i = 0; i < 10; i++)
            {
                b.Add(new Sunum.Models.Book(productID_: i + 1, name_: "Olasılıksız", author_: "Adam Fawer",
                    price_: 18.99, photourl_: "/images/olasiliksiz-adam-fawer.jpg", user_: null, tags_: null, summary_: null));
            }
            ViewBag.pg = pg;
            ViewBag.pg_max = 7;
            return View(b);
        }

        [HttpGet]
        [Route("MySolds")]
        public ActionResult MySolds(int pg = 1)
        {
            List<Sunum.Models.Book> b = new List<Sunum.Models.Book>();

            for (int i = 0; i < 10; i++)
            {
                b.Add(new Sunum.Models.Book(productID_: i + 1, name_: "Olasılıksız", author_: "Adam Fawer",
                    price_: 18.99, photourl_: "/images/olasiliksiz-adam-fawer.jpg", user_: null, tags_: null, summary_: null));
            }

            ViewBag.pg = pg;
            ViewBag.pg_max = 7;

            return View(b);
        }

        [HttpGet]
        [Route("MySales")]
        public ActionResult MySales(int pg = 1)
        {
            List<Sunum.Models.Book> b = new List<Sunum.Models.Book>();

            for (int i = 0; i < 10; i++)
            {
                b.Add(new Sunum.Models.Book(productID_: i + 1, name_: "Olasılıksız", author_: "Adam Fawer",
                    price_: 18.99, photourl_: "/images/olasiliksiz-adam-fawer.jpg", user_: null, tags_: null, summary_: null));
            }
            ViewBag.pg = pg;
            ViewBag.pg_max = 7;

            return View(b);
        }
        

        [HttpGet]
        [Route("Profile")]
        public ActionResult MyProfile()
        {

            return View("Profile");
        }
        

        [HttpGet]
        [Route("SignIn")]
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [Route("SignIn")]
        public ActionResult SignIn(string username, string password)
        {
            User u = BookStoreServices.Login(username, password);
            Session.Add("currentUser",u);

            return RedirectToAction("HomePage");
        }

        [HttpGet]
        [Route("SignUp")]
        public ActionResult SignUp()
        {

            return View();
        }

        [HttpPost]
        [Route("SignUp")]
        public ActionResult SignUp(string name, string surname,string username,string password, string email,string phonenumber, string adress)
        {
            //BookStoreServices.SignUp(name,surname,username,password,email,phonumber,adress);
            return RedirectToAction("HomePage");
        }

        [HttpGet]
        [Route("SignOut")]
        public ActionResult SignOut()
        {
            return RedirectToAction("HomePage");
        }



    }
}