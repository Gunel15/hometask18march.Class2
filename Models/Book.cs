using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Book : Product
    {
        public string Genre;
        public Book(int no, string name, int price, string genre ) : base( no,name,price)

        { 
            Genre = genre;
        }
        
    }
}
