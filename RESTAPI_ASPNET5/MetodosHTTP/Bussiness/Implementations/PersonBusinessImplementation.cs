using MetodosHTTP.Model;
using MetodosHTTP.Model.Context;
using MetodosHTTP.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MetodosHTTP.Business.Implementations
{
    public class PersonBussinessImplementation : IPersonBusiness
    {
        private readonly IPersonRepository _repository;
        public PersonBussinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Person Create(Person person)
        {
            
            return _repository.Create(person);
        }
        public Person Update(Person person)
        {
            return _repository.Update(person);

        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

    }
}
