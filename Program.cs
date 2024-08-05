using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            // splits 1 whole string into array of strings with ',' delimiter
            string[] orderItems = orderStream.Split(',');
            Array.Sort(orderItems);
            foreach(var orders in orderItems) 
            {
                if(orders.Length != 4)
                    Console.WriteLine($"{orders}\t- Error");
                else
                    Console.WriteLine(orders);
            }

            Console.ReadLine();
        }
    }
}
