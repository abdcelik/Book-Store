using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FusionBookieDB.Entity;

namespace FusionBookieDB
{
    public static class BookStoreServices
    {

        static FusionDb Db = new FusionDb();

        public static User Login(String Username, String Password) { 
            return Db.Users.Where(x => x.UserName.Equals(Username) && x.Password.Equals(Password)).FirstOrDefault(); 
        }

        public static bool SignUp(User user) { 
            return Db.Users.Where(x => x.UserName.Equals(user.UserName)).ToList() == null; 
        }

        public static List<Book> Filter(int[] filterList, string querry) {
            int FilterID = 1;

            if (filterList == null)
            {
                if (querry == null || querry == "" || querry == " ")
                    return Db.Books.Where(x => (x.FilterID % FilterID == 0) && x.BookStatus == 0).ToList();
                else
                    return Db.Books.Where(x => (x.FilterID % FilterID == 0) && x.BookStatus == 0 && x.Name.Contains(querry)).ToList();
            }
                

            foreach (var i in filterList)
            {
                FilterID *= i;
            }

            if (querry == null || querry == "" || querry == " ")
                return Db.Books.Where(x => (x.FilterID % FilterID == 0) && x.BookStatus == 0).ToList();

            return Db.Books.Where(x => (x.FilterID % FilterID == 0) && x.BookStatus == 0 && x.Name.Contains(querry)).ToList();

        }

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

        public static int PageMax(List<Book> books) {
            return Convert.ToInt32(Math.Ceiling( books.Count/Convert.ToDouble(12))); 
        }

        public static List<Book> GetPageBooks(List<Book> books, int PageNumber)
        {
            List<Book> newList = new List<Book>();

            for (int i = books.Count() - 1; i >= 0; --i)
            {
                Book book = books.ElementAt(i);
                if (i >= books.Count() - PageNumber * 12 && i < books.Count() - (PageNumber-1) * 12)
                    newList.Add(book);
            }

            return newList;
        }

        public static string catToUrl(int[] catID)
        {
            string s = "";

            if (catID == null)
                return s;

            for (int i = 0; i < catID.Length; i++)
            {
                s += "&catID=" + catID[i].ToString();
            }

            return s;

        }

    }
}