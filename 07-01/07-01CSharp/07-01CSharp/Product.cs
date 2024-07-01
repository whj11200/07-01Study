using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_01CSharp_info
{
    internal class Product
    {
        // 읽을 수 있지만 사용불가능
        private int price = 100;
        public ref int GetPrice()
        {
            return ref price;
        }
        public void PrintPrice()
        {
            Console.WriteLine($"Price : {price}");
        }
    }
}
