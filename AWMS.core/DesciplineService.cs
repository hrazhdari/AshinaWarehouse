using AWMS.dto;
using AWMS.datalayer.Entities;
using AWMS.datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWMS.core.Interfaces;

namespace AWMS.core.Services
{
    public class DesciplineService : IDesciplineService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DesciplineService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<DesciplineDto>> GetAllDesciplinesAsync()
        {
            var Desciplines = await _unitOfWork.Desciplines.GetAllAsync();
            return Desciplines.Select(d => new DesciplineDto
            {
                DesciplineId = d.DesciplineId,
                DesciplineName = d.DesciplineName
            }).ToList();
        }

        public IEnumerable<DesciplineDto> GetAllDesciplines()
        {
            var Desciplines = _unitOfWork.Desciplines.GetAll();
            return Desciplines.Select(d => new DesciplineDto
            {
                DesciplineId = d.DesciplineId,
                DesciplineName = d.DesciplineName
            }).ToList();
        }

        public async Task<DesciplineDto> GetDisciplineByIdAsync(int desciplineId)
        {
            var discipline = await _unitOfWork.Desciplines.GetByIdAsync(desciplineId);
            if (discipline == null)
                return null;

            return new DesciplineDto
            {
                DesciplineId = discipline.DesciplineId,
                DesciplineName = discipline.DesciplineName
            };
        }

        public async Task<int> AddDisciplineAsync(DesciplineDto desciplineDto)
        {
            var discipline = new Descipline
            {
                DesciplineName = desciplineDto.DesciplineName
            };

            await _unitOfWork.Desciplines.AddAsync(discipline);
            await _unitOfWork.CompleteAsync();
            return discipline.DesciplineId;
        }

        public async Task UpdateDisciplineAsync(DesciplineDto desciplineDto)
        {
            var discipline = await _unitOfWork.Desciplines.GetByIdAsync(desciplineDto.DesciplineId);
            if (discipline != null)
            {
                discipline.DesciplineName = desciplineDto.DesciplineName;
                _unitOfWork.Desciplines.Update(discipline);
                await _unitOfWork.CompleteAsync();
            }
        }

        public async Task DeleteDisciplineAsync(int desciplineId)
        {
            var discipline = await _unitOfWork.Desciplines.GetByIdAsync(desciplineId);
            if (discipline != null)
            {
                _unitOfWork.Desciplines.Delete(discipline);
                await _unitOfWork.CompleteAsync();
            }
        }

        public async Task DeleteMultipleDesciplinesWithTransactionAsync(IEnumerable<DesciplineDto> disciplineDtos)
        {
            using (var transaction = await _unitOfWork.BeginTransactionAsync())
            {
                try
                {
                    foreach (var desciplineDto in disciplineDtos)
                    {
                        var discipline = await _unitOfWork.Desciplines.GetByIdAsync(desciplineDto.DesciplineId);
                        if (discipline != null)
                            _unitOfWork.Desciplines.Delete(discipline);
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
