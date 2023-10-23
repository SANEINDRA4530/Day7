using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
   
        internal class Child : Parent  // inherit Parent class here

        {

            public string EmaildID { get; set; }

            public void ChildFunction1()

            {

                base.ID = 1;

                base.Name = "Samatha";

                Console.WriteLine("Child Function");

                Console.WriteLine($"{EmaildID}");

                base.ParentFunction1();

            }

        }

    
}
