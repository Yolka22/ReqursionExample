using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reqursion
{
    internal class Program
    {

        static int Reqursion(int iterator)
        {
            if (iterator == 0)
            {
                Console.WriteLine(iterator);
                return 0;
            }
            Console.WriteLine(iterator);
            return Reqursion(iterator - 1);
        }

        static void Main(string[] args)
        {
            Reqursion(0); // 0 iterations
            Reqursion(10);// 10-N iterations
            Reqursion(-2);// infinity loop

            Console.ReadLine();
        }
    }
}
