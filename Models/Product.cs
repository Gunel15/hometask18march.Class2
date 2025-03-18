using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Product
    {
        public int No;
        public string Name;
        public int Price;
        public int Count;

        public Product(int no,string name,int price) 
        {  
            No = no;
            Name = name;
            Price = price;
           
            
        }
      
        

    }
}
