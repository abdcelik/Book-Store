using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionBookieDB.Entity
{
    public class Book : EntityBase
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string Author { get; set; }

        public string Edition { get; set; }

        public int Page { get; set; }

        public string PhotoUrl { get; set; }

        public virtual string Category_1 { get; set; } = "-";

        public virtual string Category_2 { get; set; } = "-";

        public virtual string Category_3 { get; set; } = "-";

        public int FilterID { get; set; }

        public virtual User User { get; set; }

        public Book()
        {
            
        }

        public Book(string name_, double price_, string author_, string edition_,
            int page_, string photourl_, List<int> categories_, User user_)
        {
            this.Name       = name_;
            this.Price      = price_;
            this.Author     = author_;
            this.Edition    = edition_;
            this.Page       = page_;
            this.PhotoUrl   = photourl_;
            this.User       = user_;
            this.FilterID   = 1;

            SetCategories(categories_);
        }



        public List<string> GetCategoryInfo()
        {
            List<string> CatgList = new List<string>();

            CatgList.Add(Category_1);
            CatgList.Add(Category_2);
            CatgList.Add(Category_3);

            return CatgList;
        }



        private void SetCategories(List<int> categories_)
        {
            for (int i = 0; i < categories_.Count; i++)
            {
                this.FilterID *= categories_[i];

                if (i == 0) this.Category_1 = ((Tag)categories_[i]).ToString().Replace('_', ' ');
                else if (i == 1) this.Category_2 = ((Tag)categories_[i]).ToString().Replace('_', ' ');
                else this.Category_3 = ((Tag)categories_[i]).ToString().Replace('_', ' ');

            }
        }


    }
}
