using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsStart
{
    internal class PersonBad
    {
        public int Id { get; }
        public string Name { get; }
        public PersonBad(int id, string name)
        {
            Id = id;
            Name = name;
        }
       // With 2 parameters when id can be string and int
        //public object Id { get; }
        //public string Name { get; }
        //public Person(object id, string name)
        //{
        //    Id = id;
        //    Name = name;
        //}
    }
}
