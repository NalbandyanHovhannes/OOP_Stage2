using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsStart
{
    public class PersonGoodPractice<T>
    {
        public T Id { get; set; } //public int Id { get; set; }
        //public string Id { get; set; } //public int Id { get; set; }
        public string Name { get; set; }
        public PersonGoodPractice(T id, string name)
        {
            Id = id;
            Name = name;
        }
        public PersonGoodPractice()
        {

        }
    }
}
