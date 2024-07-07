using System;
using System.Threading.Tasks;
using AWMS.datalayer.Repositories;

namespace AWMS.datalayer
{
    public interface IUnitOfWork : IDisposable
    {
        ICompanyRepository Companies { get; }
        Task<int> CompleteAsync();
    }
}
