using System.Security.Cryptography.X509Certificates;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kitabin sayini daxil edin");
            int count=Convert.ToInt32(Console.ReadLine());
            Book[] books = new Book[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("No:");
                int no = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ad:");
                string name = Console.ReadLine();
                Console.WriteLine("Qiymeti(AZN):");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Janr:");
                string genre = Console.ReadLine();

                Book newbook = new(no, name, price, genre);
                books[i] = newbook;
               
            }
                 for (int i = 0; i < count; i++) 
            { Console.WriteLine($"{books[i].Name} {books[i].Price}"); }


        }       
    }
}
