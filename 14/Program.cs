using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Мурка");
            cat1.ShowInfo();
            Console.ReadKey();

            Dog dog1 = new Dog("Барбос");
            dog1.ShowInfo();
            dog1.Say();
            Console.ReadKey();
        }
    }
}
