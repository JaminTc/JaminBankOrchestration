using Funq;
using ServiceStack.Validation;

namespace JaminBankUIOrchestration.API
{
    public static class ContainerManager
    {
        public static void Register(Container container)
        {
            //container.RegisterValidators(ReuseScope.Container, typeof(APIValidat))
            JaminBankUIOrchestration.API.Buisness.ContainerComponentRegistrator.RegisterComponents(container);
        }
    }
}