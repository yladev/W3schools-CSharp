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
            int numberOne = 10;
            Console.WriteLine("numberOne = " + numberOne);

            long petrolLiter = 15000000000L;
            Console.WriteLine("petrolLiter = " + petrolLiter);

            float myNum = 5.75F;
            Console.WriteLine("myNum = " + myNum);

            double myNumber = 19.99D;
            Console.WriteLine("myNumber = " + myNumber);

            bool isTrue = true;
            Console.WriteLine("isTrue = " + isTrue);

            bool isFalse = false;
            Console.WriteLine("isFalse = " + isFalse);

            char myGrade = 'A';
            Console.WriteLine("myGrade = " + myGrade);

            string greeting = "Mingalarpr";
            Console.WriteLine("greeting = " + greeting);

            Console.ReadKey();
        }
    }
}
