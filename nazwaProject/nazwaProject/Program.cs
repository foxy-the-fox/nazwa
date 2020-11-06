using System;

namespace nazwaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = int.Parse(args[0]);
            switch (x)
            {
                case 1:
                    Console.WriteLine("Hello world!");
                    break;

                case 2:
                    Console.WriteLine("raspberry pi");
                    break;

                case 3:
                    Console.WriteLine("arduino");
                    break;

                case 4:
                    Console.WriteLine("and other");
                    break;
                default:
                    break;
            }
        }
    }
}
