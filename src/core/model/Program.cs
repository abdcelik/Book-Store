using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fusion.Entity;

namespace Fusion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            User currUser;
            Book currBook;
            FusionDb db = new FusionDb();

            db.Users.Add(new User {
                Username = "Chae",
                Password = "6789",
                Address  = "Ofis"

            });
            db.SaveChanges();*/

            /*
            var data = db.Users.Where(x => x.Username == "Norius").ToList();
            if (data.Count == 1)
            {
                currUser = data.FirstOrDefault();
                Console.WriteLine(currUser.Cart.Price);
                
            }
            */

           /* var data = db.Books.Where(x => x.Name == "berk kitap").ToList();
            if (data.Count == 1)
            {
                currBook = data.FirstOrDefault();
                Console.WriteLine(currBook.Name);
                currUser = currBook.User;
                Console.WriteLine(currUser.Address);

            }*/
        }
    }
}