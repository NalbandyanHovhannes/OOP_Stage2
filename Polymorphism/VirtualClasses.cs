using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public    class VirtualClasses
    {

        public  virtual void AnimalVoice(int t)
        {
            Console.WriteLine("DefaultVoice in VirtualClasses");
        }
        public virtual void AnimalFight(int t)
        {
            Console.WriteLine("DefaulAnimalFight  in VirtualClasses");
        }
    }
}
