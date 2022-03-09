using System;
using myapp.lib;

namespace myapp
{
   class Program
    {
        static void Main(string[] args)
        {
            var c = new calculator().Add(10,1);

            Console.WriteLine($"Hello World! c => {c}");
        }
    }
}