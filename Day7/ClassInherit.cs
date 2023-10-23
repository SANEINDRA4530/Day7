using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{


    internal class Parent

    {

        protected int ID { get; set; }  //protected data member  --so that no one access it anywhere but can give value

        protected string Name { get; set; }

        protected void ParentFunction1()

        {

            Console.WriteLine("Parent function");

            Console.WriteLine($"{ID} {Name}");

        }

    }
}