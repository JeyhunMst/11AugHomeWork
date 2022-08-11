using _11AugHomeWork.Models;
using System;

namespace _11AugHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            User Developer = new User();
            Console.WriteLine("UserName:");
            Developer._userName = Console.ReadLine();
            Console.WriteLine("Password:");
            Developer._password = Console.ReadLine();
            
            
                
            

            Developer.ShowInfo();
        }
    }
}
