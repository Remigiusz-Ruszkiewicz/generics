using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<Roman> genericClass = new GenericClass<Roman>(new Roman());
            Console.WriteLine(genericClass.GetY);
            //var x = genericClass.GetSum<string>("2","3");
            //var y = genericClass.GetSum<Program>(new Program(), new Program());
            //var z = genericClass.GetSum<Array>(new string[3], new string[2]);
            //var a = genericClass.GetSum<int>(3,2);

            Console.WriteLine();
            Console.Read();
        }
    }
}
