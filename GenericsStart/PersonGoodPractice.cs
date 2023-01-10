using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsStart
{
    internal class PersonGoodPractice<T>
    {
        public T Id { get; set; }
        public string Name { get; set; }
        public PersonGoodPractice(T id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
