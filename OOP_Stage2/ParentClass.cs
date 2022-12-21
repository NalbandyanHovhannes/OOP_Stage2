using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Stage2
{
    public class ParentClass: SomeClass
    {
        private static int _staticInt;
        public void ParentMethod()
        {
            Console.WriteLine("ParentMethod In class Running");
        }
        public ParentClass()
        {

        }
    }
}
