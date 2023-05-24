using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Application.Data
{
    public static class DbIntializer   
    {
        static ApplicationDbContext ApplicationDbContext = new ApplicationDbContext();
        public static void GetAll(Label label,Label label1 ,Button button,int id)
        {
            var collection = from item in ApplicationDbContext.Books
                             where item.Id == id
                             select item;
            foreach (var item in collection)
            {
                label.Text = item.BookName;
                label1.Text = item.AuthorName;
                button.Text = "$"+Convert.ToString(item.Price);
            }
        }
    }
}
