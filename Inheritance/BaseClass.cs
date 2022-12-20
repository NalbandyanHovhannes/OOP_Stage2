using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class BaseClass
    {
        void  BaseMethod(int t)
        {
            Console.WriteLine("BaseMethod   {0}",t);
        }
        public BaseClass(int y)
        {
            BaseMethod(y);
        }
    }
}
