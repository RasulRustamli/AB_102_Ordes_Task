
using MyClasses;

namespace AB_102_Ordes_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Programlasdirma ne oyredir", "Anonim", 45.4);
            Book book1 = new Book("Programlasdirma ne oyredir", "Anonim", 45.4);
            Book book2 = new Book("Programlasdirma ne oyredir", "Anonim", 45.4);
            Book book3 = new Book("Programlasdirma ne oyredir", "Anonim", 213.4);
            Book book5 = new Book("Programlasdirma ne oyredir", "Anonim", 42.4);
            Book book4 = new Book("Programlasdirma ne oyredir", "Anonim", 45.4);

            Order order = new Order();
            order.AddSellList(book1);
            order.AddSellList(book2);
            order.AddSellList(book3);
            
            
            Console.WriteLine(order.SellBook());

        }
    }
}