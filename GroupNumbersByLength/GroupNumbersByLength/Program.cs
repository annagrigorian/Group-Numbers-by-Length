using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupNumbersByLength
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 100);

            var groups = numbers.GroupBy(i => i.ToString().Length);

            foreach (var item in groups)
            {
                Console.WriteLine($"Number of digits : {item.Key}");
                Console.WriteLine("Group numbers : ");
                foreach (var itemo in item)
                {
                    Console.Write(itemo + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
