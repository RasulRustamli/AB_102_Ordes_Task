using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class Order
    {
        public int Id { get; set; }
        public Book[] Books=new Book[0];
        public double Total_Price { get; set; }



        public void AddSellList(Book book)
        {
            Array.Resize(ref Books, Books.Length+1); 
            Books[Books.Length-1] = book;
        }
       public double SellBook()
        {
            foreach (Book book in Books)
            {
                Total_Price+=book.Price;
            }
            if(Total_Price<100)
            {
                return Total_Price;
            }
            else if(Total_Price<200)
            {
               return Total_Price -= Total_Price/10;
            }
            else
            {
               return Total_Price -= Total_Price * 0.2;
            }
        }
       
    }
}
