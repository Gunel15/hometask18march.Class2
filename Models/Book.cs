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
        public Book(int No, string Name, int Price,int count, string genre ) : base( No,Name,Price,Count)

        { 
            Genre = genre;
        }
        
    }
}
