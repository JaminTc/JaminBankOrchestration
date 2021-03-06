﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace JaminBankUIOrchestration.API.Data.Interfaces
{
    interface IRestServiceFactory
    {
        string BaseUri { get; set; }
        IServiceClient GenerateInstance();
    }
}
