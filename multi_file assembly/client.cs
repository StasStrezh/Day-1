using System;
using Food;

namespace MultifileAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            JunkFood obj1 = new JunkFood();
            obj1.JunkFoodInfo();

            Hambaga obj = new Hambaga();
            obj.InfoHambaga();
            Console.ReadLine();
        }
    }
}
