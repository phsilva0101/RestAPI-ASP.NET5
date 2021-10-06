using MetodosHTTP.Model;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MetodosHTTP.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> peoples = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                peoples.Add(person);
            }
            return peoples;
        }

      
        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                Name = "Paulo",
                Age = 15,
                City = "São Paulo",
                Phone = "1199999999"

            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                Name = "Name" + i,
                Age = i,
                City = "City Name" + i,
                Phone = "Phone Number" + i
                
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
