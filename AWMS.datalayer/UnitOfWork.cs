using AWMS.datalayer.Context;
using AWMS.datalayer.Repositories;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace AWMS.datalayer
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AWMScontext _context;
        private readonly ConcurrentDictionary<Type, object> _repositories;

        public UnitOfWork(AWMScontext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _repositories = new ConcurrentDictionary<Type, object>();
        }

        public IMrRepository Mrs => GetRepository<IMrRepository, MrRepository>();
        public IPoRepository Pos => GetRepository<IPoRepository, PoRepository>();
        public ICompanyRepository Companies => GetRepository<ICompanyRepository, CompanyRepository>();

        private TRepository GetRepository<TRepository, TImplementation>()
            where TRepository : class
            where TImplementation : class, TRepository
        {
            var type = typeof(TRepository);
            if (!_repositories.ContainsKey(type))
            {
                var repositoryInstance = Activator.CreateInstance(typeof(TImplementation), _context);
                _repositories[type] = repositoryInstance;
            }

            return (TRepository)_repositories[type];
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
