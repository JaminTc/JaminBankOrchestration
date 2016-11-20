using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaminBankUIOrchestration.API.Buisness.Interfaces;
using JaminBankUIOrchestration.API.Data.Interfaces;
using JaminBankUIOrchestration.API.DomainModel;

namespace JaminBankUIOrchestration.API.Buisness.Managers
{
    internal class PersonManager : RepositoryManager<IPersonRepository>, IPersonManager
    {
        public PersonManager(IPersonRepository repo) : base(repo) { }

        public Person GetPerson(Person person)
        {
            return _repository.GetPerson(person);
        }
    }
}
