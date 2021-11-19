using MetodosHTTP.Model;
using MetodosHTTP.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MetodosHTTP.Repository.Implementations
{
    public class PersonRepositoyImplementation : IPersonRepository
    {
        private Context _context;
        public PersonRepositoyImplementation(Context context)
        {
            _context = context;
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(long id)
        {
            return _context.Persons.FirstOrDefault(p => p.Id.Equals(id));
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
            return person;
        }
        public Person Update(Person person)
        {
            if (!Exists(person.Id))
            {
                return new Person();
            }
            var response = _context.Persons.FirstOrDefault(p => p.Id.Equals(person.Id));
            if (response != null)
            {
                try
                {
                    _context.Entry(response).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }

            return person;
        }

        public void Delete(long id)
        {
            var response = _context.Persons.FirstOrDefault(p => p.Id.Equals(id));
            if (response != null)
            {
                try
                {
                    _context.Persons.Remove(response);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Exists(long id)
        {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }


    }
}
