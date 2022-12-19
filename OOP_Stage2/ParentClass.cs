using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Stage2
{
    internal class ParentClass: SomeClass
    {
        public static int _staticInt;
        public void ParentMethod()
        {
            Console.WriteLine("ParentMethod In class Running");
        }
    }
}
