using AWMS.datalayer.Context;
using AWMS.datalayer.Repositories;
using System.Threading.Tasks;

namespace AWMS.datalayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AWMScontext _context;
        public ICompanyRepository Companies { get; private set; }
        //public IMemberRepository Members { get; private set; }

        public UnitOfWork(AWMScontext context)
        {
            _context = context;
            Companies = new CompanyRepository(_context);
           //Members = new MemberRepository(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
