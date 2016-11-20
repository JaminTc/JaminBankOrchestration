using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaminBankUIOrchestration.API.Data.Interfaces;
using ServiceStack;

namespace JaminBankUIOrchestration.API.Data.Factories
{
    public class RestServiceFactory : IRestServiceFactory
    {
        public string BaseUri { get; set; }

        public RestServiceFactory(string baseUri)
        {
            BaseUri = baseUri;
        }
        public IServiceClient GenerateInstance()
        {
            var client = new JsonServiceClient(BaseUri);
            return client;
        }
    }
}
