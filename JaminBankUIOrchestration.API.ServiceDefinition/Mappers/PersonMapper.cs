using AutoMapper;
using dm = JaminBankUIOrchestration.API.DomainModel;
using sm = JaminBankUIOrchestration.API.ServiceModel.Dtos;

namespace JaminBankUIOrchestration.API.ServiceDefinition.Mappers
{
    internal class PersonMapper : Profile
    {
        public PersonMapper()
        {
            CreateMap<dm.Person, sm.Person>();
            CreateMap<sm.Person, dm.Person>();
        }
    }
}
