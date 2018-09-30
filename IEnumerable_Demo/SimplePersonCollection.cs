using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Demo
{
    class SimplePersonCollection : IEnumerable<Person>
    {

        private readonly List<Person> _people = new List<Person>();
        
        public void Add(Person person)
        {
            _people.Add(person);
        }

         
        public IEnumerator<Person> GetEnumerator()
        {
            foreach (var person  in _people)
            {
                yield return person;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
