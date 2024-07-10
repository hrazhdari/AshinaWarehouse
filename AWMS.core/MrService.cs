using AWMS.dto;
using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWMS.core.Interfaces;
using AWMS.datalayer;

public class MrService : IMrService
{
    private readonly IUnitOfWork _unitOfWork;

    public MrService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<MrDto>> GetAllMrsAsync()
    {
        var mrs = await _unitOfWork.Mrs.GetAllAsync();
        return mrs.Select(mr => new MrDto
        {
            MrId = mr.MrId,
            MrName = mr.MrName,
            MrDescription = mr.MrDescription,
            EnteredDate = mr.EnteredDate
        }).ToList();
    }

    public async Task<MrDto> GetMrByIdAsync(int id)
    {
        var mr = await _unitOfWork.Mrs.GetByIdAsync(id);
        if (mr == null) return null;

        return new MrDto
        {
            MrId = mr.MrId,
            MrName = mr.MrName,
            MrDescription = mr.MrDescription,
            EnteredDate = mr.EnteredDate
        };
    }

    public async Task<int> AddMrAsync(MrDto mrDto)
    {
        var mr = new Mr
        {
            MrName = mrDto.MrName,
            MrDescription = mrDto.MrDescription,
            EnteredDate = mrDto.EnteredDate
        };

        await _unitOfWork.Mrs.AddAsync(mr);
        await _unitOfWork.CompleteAsync();
        return mr.MrId;
    }

    public async Task UpdateMrAsync(MrDto mrDto)
    {
        var mr = await _unitOfWork.Mrs.GetByIdAsync(mrDto.MrId);
        if (mr != null)
        {
            mr.MrName = mrDto.MrName;
            mr.MrDescription = mrDto.MrDescription;
            mr.EnteredDate = mrDto.EnteredDate;

            _unitOfWork.Mrs.Update(mr);
            await _unitOfWork.CompleteAsync();
        }
    }

    public async Task DeleteMrAsync(int id)
    {
        var mr = await _unitOfWork.Mrs.GetByIdAsync(id);
        if (mr != null)
        {
            _unitOfWork.Mrs.Delete(mr);
            await _unitOfWork.CompleteAsync();
        }
    }

    public async Task<int?> GetByMrNameAsync(string mrName)
    {
        return await _unitOfWork.Mrs.GetByNameAsync(mrName);
    }

    public async Task DeleteMultipleMrsWithTransactionAsync(IEnumerable<MrDto> mrDtos)
    {
        using (var transaction = await _unitOfWork.BeginTransactionAsync())
        {
            try
            {
                foreach (var mrDto in mrDtos)
                {
                    var mr = await _unitOfWork.Mrs.GetByIdAsync(mrDto.MrId);
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

    public async Task<IEnumerable<MrIdAndMrNameDto>> GetMrIdAndNameAsync()
    {
        var mrs = await _unitOfWork.Mrs.GetAllAsync();
        return mrs.Select(mr => new MrIdAndMrNameDto
        {
            MrId = mr.MrId,
            MrName = mr.MrName
        }).ToList();
    }
}
