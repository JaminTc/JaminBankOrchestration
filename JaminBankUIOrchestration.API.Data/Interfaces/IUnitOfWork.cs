using System;                  
using System.Data;

namespace JaminBankUIOrchestration.API.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDbCommand CreateCommand();
        void SaveChanges();
        void RollBack();
    }
}
