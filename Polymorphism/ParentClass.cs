using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class ParentClass:VirtualClasses
    {
        public override void AnimalVoice(int t)
        {
           // base.AnimalVoice(t);
            Console.WriteLine("base.AnimalVoice(t);");
        }
        public override void AnimalFight(int t)
        {
            Console.WriteLine("a im ParentClass:VirtualClasses ");
        }
    }
}
