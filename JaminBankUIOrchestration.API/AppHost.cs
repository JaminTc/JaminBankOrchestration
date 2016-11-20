using Funq;
using JaminBankUIOrchestration.API.ServiceDefinition;
using JaminBankUIOrchestration.API.ServiceDefinition.Mappers;
using ServiceStack;

namespace JaminBankUIOrchestration.API
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base(APIInfo.Name, APIInfo.Assembly) { }

        public override void Configure(Container container)
        {
            ContainerManager.Register(container);
            SetConfig(new HostConfig { HandlerFactoryPath = "myFirstApp" });
            AutoMapperConfiguration.Configure();
        }
    }
}