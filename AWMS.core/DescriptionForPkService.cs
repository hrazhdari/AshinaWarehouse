using AWMS.dto;
using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWMS.core.Interfaces;
using AWMS.datalayer;

public class DescriptionForPkService : IDescriptionForPkService
{
    private readonly IUnitOfWork _unitOfWork;

    public DescriptionForPkService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<DescriptionForPkDto>> GetAllDescriptionForPksAsync()
    {
        var DescriptionForPks = await _unitOfWork.DescriptionForPks.GetAllAsync();
        return DescriptionForPks.Select(DescriptionForPk => new DescriptionForPkDto
        {
            DescriptionForPkId = DescriptionForPk.DescriptionForPkId,
            Description=DescriptionForPk.Description
        }).ToList();
    }
    public IEnumerable<DescriptionForPkDto> GetAllDescriptionForPks()
    {
        var DescriptionForPks = _unitOfWork.DescriptionForPks.GetAll();
        return DescriptionForPks.Select(DescriptionForPk => new DescriptionForPkDto
        {
            DescriptionForPkId = DescriptionForPk.DescriptionForPkId,
            Description = DescriptionForPk.Description
        }).ToList();
    }
    public async Task<DescriptionForPkDto> GetDescriptionForPkByIdAsync(int DescriptionForPkId)
    {
        var DescriptionForPk = await _unitOfWork.DescriptionForPks.GetByIdAsync(DescriptionForPkId);
        if (DescriptionForPk == null) return null;

        return new DescriptionForPkDto
        {
            DescriptionForPkId = DescriptionForPk.DescriptionForPkId,
            Description = DescriptionForPk.Description
        };
    }

    public async Task<int> AddDescriptionForPkAsync(DescriptionForPkDto DescriptionForPkDto)
    {
        var DescriptionForPk = new DescriptionForPk
        {
            DescriptionForPkId = DescriptionForPkDto.DescriptionForPkId,
            Description = DescriptionForPkDto.Description
        };

        await _unitOfWork.DescriptionForPks.AddAsync(DescriptionForPk);
        await _unitOfWork.CompleteAsync();
        return DescriptionForPk.DescriptionForPkId;
    }

    public async Task UpdateDescriptionForPkAsync(DescriptionForPkDto DescriptionForPkDto)
    {
        var DescriptionForPk = await _unitOfWork.DescriptionForPks.GetByIdAsync(DescriptionForPkDto.DescriptionForPkId);
        if (DescriptionForPk != null)
        {
            DescriptionForPk.DescriptionForPkId = DescriptionForPkDto.DescriptionForPkId;
            DescriptionForPk.Description = DescriptionForPkDto.Description;

            _unitOfWork.DescriptionForPks.Update(DescriptionForPk);
            await _unitOfWork.CompleteAsync();
        }
    }

    public async Task DeleteDescriptionForPkAsync(int DescriptionForPkId)
    {
        var DescriptionForPk = await _unitOfWork.DescriptionForPks.GetByIdAsync(DescriptionForPkId);
        if (DescriptionForPk != null)
        {
            _unitOfWork.DescriptionForPks.Delete(DescriptionForPk);
            await _unitOfWork.CompleteAsync();
        }
    }
    public async Task DeleteMultipleDescriptionForPksWithTransactionAsync(IEnumerable<DescriptionForPkDto> DescriptionForPkDtos)
    {
        using (var transaction = await _unitOfWork.BeginTransactionAsync())
        {
            try
            {
                foreach (var DescriptionForPkDto in DescriptionForPkDtos)
                {
                    var DescriptionForPk = await _unitOfWork.DescriptionForPks.GetByIdAsync(DescriptionForPkDto.DescriptionForPkId);
                    if (DescriptionForPk != null)
                    {
                        _unitOfWork.DescriptionForPks.Delete(DescriptionForPk);
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
