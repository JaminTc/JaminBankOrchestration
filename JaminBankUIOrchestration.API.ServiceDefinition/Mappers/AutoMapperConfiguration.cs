using AutoMapper;
using dm = JaminBankUIOrchestration.API.DomainModel;
using sm = JaminBankUIOrchestration.API.ServiceModel.Dtos;


namespace JaminBankUIOrchestration.API.ServiceDefinition.Mappers
{
    public class AutoMapperConfiguration
    {
        public static IMapper Configure() 
        {
            var mapperConfig = new MapperConfiguration(
                cfg => cfg.AddProfile<PersonMapper>()
            );
            return mapperConfig.CreateMapper();
        }
    }
}
