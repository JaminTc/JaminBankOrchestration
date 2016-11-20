using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaminBankUIOrchestration.API.DomainModel;

namespace JaminBankUIOrchestration.API.Buisness.Interfaces
{
    public interface IPersonManager
    {
        Person GetPerson(Person person);
    }
}
