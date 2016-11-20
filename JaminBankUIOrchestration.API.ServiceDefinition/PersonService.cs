using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using JaminBankUIOrchestration.API.Buisness.Interfaces;
using JaminBankUIOrchestration.API.ServiceModel.Messages;
using JaminBankUIOrchestration.API.ServiceDefinition.Mappers;
using ServiceStack;

using dm = JaminBankUIOrchestration.API.DomainModel;
using sm = JaminBankUIOrchestration.API.ServiceModel.Dtos;

namespace JaminBankUIOrchestration.ServiceDefinition
{
    class PersonService : Service
    {
        private IPersonManager _personManager;
        private IMapper _mapper;
        public PersonService(IPersonManager personMgr)
        {
            _personManager = personMgr;
            _mapper = AutoMapperConfiguration.Configure();
        }
        public ReadPersonResponse Get(ReadPerson request)
        {
            var person = new dm.Person { Id = request.PersonId }; 


            var friends = _personManager.GetPerson(person);
            return new ReadPersonResponse() { Person = _mapper.Map<sm.Person>(friends) };
        }
    }
}
