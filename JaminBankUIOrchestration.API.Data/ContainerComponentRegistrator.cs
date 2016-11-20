using Funq;
using JaminBankUIOrchestration.API.Data.Interfaces;
using JaminBankUIOrchestration.API.Data.Factories;                       
using JaminBankUIOrchestration.API.Data.Repositories;
using ServiceStack.Configuration;

namespace JaminBankUIOrchestration.API.Data
{
    public class ContainerComponentRegistrator
    {
        public static void RegisterComponents(Container container)
        {
            var settings = new AppSettings();                                                                            
            container.Register<IRestServiceFactory>(c => new RestServiceFactory(settings.GetString("LoginService")));
            container.RegisterAutoWiredAs<PersonRepository, IPersonRepository>();

        }
    }
}
