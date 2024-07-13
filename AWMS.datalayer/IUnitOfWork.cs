using System;
using System.Threading.Tasks;
using AWMS.datalayer.Repositories;
using Microsoft.EntityFrameworkCore.Storage;

namespace AWMS.datalayer
{
    public interface IUnitOfWork : IDisposable
    {
        ICompanyRepository Companies { get; }
        IMrRepository Mrs { get; }
        IPoRepository Pos { get; }
        IDescriptionForPkRepository DescriptionForPks { get; }
        Task<int> CompleteAsync();
        Task<IDbContextTransaction> BeginTransactionAsync();
    }
}
