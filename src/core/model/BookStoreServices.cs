using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FusionBookieDB.Entity;

namespace FusionBookieDB
{
    public class BookStoreServices
    {

        static FusionDb Db = new FusionDb();

        public static User Login(User user) { return Db.Users.Find(user); }

        public static bool SignUp(User user) { return Db.Users.Where(x => x.UserName.Equals(user.UserName)).ToList() == null; }

        public static List<Book> Filter(int FilterID) { return Db.Books.Where(x => x.FilterID == FilterID && x.BookStatus == 0).ToList(); }

        public static List<Category> GetCategories()
        {
            var data = Db.Categories.ToList();
            List<Category> Categories = data;

            if (Categories.Count != 0)
                return Categories;
            else
                return null;
        }

        public static User GetUser(int UserID)
        {
            var data = Db.Users.Where(x => x.ID == UserID).ToList();

            if (data.Count == 1)
                return data.FirstOrDefault();
            else
                return null;
        }

        public static Book GetBook(int BookID)
        {
            var data = Db.Books.Where(x => x.ID == BookID).ToList();

            if (data.Count == 1)
                return data.FirstOrDefault();
            else
                return null;
        }
    }
}