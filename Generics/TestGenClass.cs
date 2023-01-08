using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class TestGenClass<T>
    {
        // private data members
        private T data;

        // using properties
        public T value
        {
            // using accessors
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
        // Generics method
        public void Display<TypeOfValue>(string msg, TypeOfValue value)
        {
            Console.WriteLine("{0}:{1}", msg, value);
        }
    }
}
