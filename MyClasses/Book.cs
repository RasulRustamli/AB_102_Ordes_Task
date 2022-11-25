using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class Book
    {
        private static int _count;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }
        public string Code { get; set; }

        public Book(string name,string authorName,double price)
        {
            _count++;
            this.Name = name;
            this.AuthorName = authorName;
            this.Price = price;

            string[] newCode= name.Split(' ');
            foreach (string item in newCode)
            {
                Code += item[0].ToString().ToUpper();
            }
            Code += _count;
        }
    }
}
