using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FusionBookieDB.Entity;

namespace FusionBookieDB
{
    class Program
    {
        static void Main(string[] args)
        {
            User currUser;
            Book currBook;
            FusionDb db = new FusionDb();


            int asd = 15;
            var filts = db.Books.Where(x => asd % x.FilterID == 0 ).ToList();

            /*User myUser = new User("chae", "1243", "berk", "pkgz");
            myUser.PhoneNumber = "4321";
            myUser.Address = "xd";
            Cart myCart = new Cart();
            myCart.Price = 9;
            myUser.Cart = myCart;

            db.Users.Add(myUser);
            db.SaveChanges();*/

            var data = db.Users.Where(x => x.UserName == "chae").ToList();
            if (data.Count == 1)
            {
                var data2 = db.Categories.ToList();
                List<Category> Cats = data2;

                for(int i=0; i < Cats.Count; i++)
                {
                    Console.WriteLine(Cats[i].FilterID);
                }

                /*currBook = currUser.CurrSales[3];
                Console.WriteLine(currBook.Tags[0].FilterID);*/


                /*currBook = new Book();
                currBook.Name = "Olasiliksiz4";
                currBook.Price = 10;
                currBook.Author = "Apo";
                currBook.Edition = "Founder Edition";
                currBook.Page = 200;
                currBook.PhotoUrl = "/imgs/4";
                currBook.FilterID = 0;
                currBook.User = currUser;

                currUser.CurrSales.Add(currBook);*/

                /*currBook = currUser.CurrSales[3];
                currBook.FilterID = 6;
                Category newC = new Category();
                newC.Name = "Peotry";
                newC.FilterID = 43;
                currBook.Tags.Add(newC);*/

                //db.SaveChanges();
                //Console.WriteLine(currUser.CurrSales[0].Name);


                //Console.WriteLine(Tag.Art_Photography.ToString().Replace('_',' '));
               // Console.WriteLine(((Tag)3).ToString());
               // Console.WriteLine(currUser.Password);
            }



        }
    }
}
