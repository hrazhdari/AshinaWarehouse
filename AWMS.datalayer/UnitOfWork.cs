using AWMS.datalayer.Context;
using AWMS.datalayer.Repositories;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;

namespace AWMS.datalayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AWMScontext _context;
        public ICompanyRepository Companies { get; private set; }
        public IMrRepository Mrs { get; private set; }

        public UnitOfWork(AWMScontext context)
        {
            _context = context;
            Companies = new CompanyRepository(_context);
            Mrs = new MrRepository(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _context.Database.BeginTransactionAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
