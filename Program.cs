using stack_test.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var simplestack = new simplestack<int>();

            simplestack.Push(1);
            simplestack.Push(2);
            simplestack.Push(3);

            var item = simplestack.Pop();
            var item2 = simplestack.Peek();

            Console.WriteLine(item);
            Console.WriteLine(item2);
            Console.ReadLine();
        }
    }
}
