using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp162
{
    class Program
    {
        static void Main(string[] args)
        {
            var buffer = new StringBuilder("Hello,how are you?");

            Console.WriteLine($"buffer={buffer}" + $"\n Length={buffer.Length}" + $"\n Capacity={buffer.Capacity}");

            buffer.EnsureCapacity(75);
            Console.WriteLine($"\n New Capacity={buffer.Capacity}");

            buffer.Length = 10;
            Console.WriteLine($" New length={buffer.Length}\n\n buffer = ");

            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write(buffer[i]);
            }

            Console.WriteLine();
            Console.ReadLine();








        }
    }
}
