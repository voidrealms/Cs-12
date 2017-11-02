using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person cPerson = new Person();
            Person cPerson2 = new Person();

            cPerson.Age = 36;
            cPerson.Name = "Bryan";

            cPerson2.Age = 18;
            cPerson2.Name = "Heather";

            Console.WriteLine(cPerson.Name + " is " + cPerson.Age + " years old");
            Console.WriteLine(cPerson2.Name + " is " + cPerson2.Age + " years old");

            Console.Read();
        }
    }
}
