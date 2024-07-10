using AWMS.datalayer;
using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using AWMS.core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AWMS.core
{
    public class MrService : IMrService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MrService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Mr>> GetAllMrsAsync()
        {
            return await _unitOfWork.Mrs.GetAllAsync();
        }

        public async Task<Mr> GetMrByIdAsync(int id)
        {
            return await _unitOfWork.Mrs.GetByIdAsync(id);
        }

        public async Task<int> AddMrAsync(Mr Mr)
        {
            await _unitOfWork.Mrs.AddAsync(Mr);
            await _unitOfWork.CompleteAsync();
            return Mr.MrId;
        }

        public async Task UpdateMrAsync(Mr Mr)
        {
            _unitOfWork.Mrs.Update(Mr);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteMrAsync(int id)
        {
            var Mr = await _unitOfWork.Mrs.GetByIdAsync(id);
            if (Mr != null)
            {
                _unitOfWork.Mrs.Delete(Mr);
                await _unitOfWork.CompleteAsync();
            }
        }

        public async Task<int?> GetByMrNameAsync(string Mrname)
        {
            return await _unitOfWork.Mrs.GetByNameAsync(Mrname);
        }

        public async Task DeleteMultipleMrsWithTransactionAsync(IEnumerable<Mr> mrs)
        {
            using (var transaction = await _unitOfWork.BeginTransactionAsync())
            {
                try
                {
                    foreach (var mr in mrs)
                    {
                        if (mr != null)
                        {
                            _unitOfWork.Mrs.Delete(mr);
                        }
                    }
                    await _unitOfWork.CompleteAsync();
                    await transaction.CommitAsync();
                }
                catch (Exception)
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            }
        }
    }
}
