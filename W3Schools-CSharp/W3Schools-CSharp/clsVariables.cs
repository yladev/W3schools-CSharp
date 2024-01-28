using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Schools_CSharp
{
    class clsVariables
    {
        static void Main(string[] args)
        {
            // dataType variableName = value;
            int SFC = 90;
            Console.WriteLine(SFC);

            double pi = 3.14;
            Console.WriteLine("pi value is " + pi);

            char jason = 'j';
            Console.WriteLine(jason);

            string person = "Jason Andrew";
            Console.WriteLine("person name is " + person);

            bool isTrue = true;
            Console.WriteLine(isTrue);

            // Constant Variables
            const string name = "Yan Linn Aung";
            Console.WriteLine("My name is " + name);

            //  Display Variables
            int num1 = 10;
            int num2 = 20;
            int ans = num1 + num2;
            Console.WriteLine(ans);
            
            // Multiple Variables
            int x, y, z;
            x = 10;
            y = 15;
            z = 20;
            Console.WriteLine(x + y + z);

            // Identifiers
            int minutesPerHour = 60;
            Console.WriteLine(minutesPerHour);

            Console.ReadKey();
        }
    }
}
