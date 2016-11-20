using Funq;

using JaminBankUIOrchestration.API.Buisness.Managers;
using JaminBankUIOrchestration.API.Buisness.Interfaces;

namespace JaminBankUIOrchestration.API.Buisness
{
    public class ContainerComponentRegistrator
    {
        public static void RegisterComponents(Container container)
        {
            Data.ContainerComponentRegistrator.RegisterComponents(container);
            container.RegisterAutoWiredAs<PersonManager, IPersonManager>();
        }
    }
}
