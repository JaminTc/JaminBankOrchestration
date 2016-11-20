using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaminBankUIOrchestration.API.ServiceModel.Dtos;
using ServiceStack;

namespace JaminBankUIOrchestration.API.ServiceModel.Messages
{
    public class ReadPersonResponse : IHasResponseStatus
    {
        public Person Person { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
