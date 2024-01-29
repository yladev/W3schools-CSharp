using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Schools_CSharp
{
    class clsDataType
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2 * x + 1;
            for (int x = 0; x <= 10 ; x++)
            {
                Console.WriteLine("2 * " + x + "+1=" + y);   
            }


            Console.ReadKey();
        }
    }
}
