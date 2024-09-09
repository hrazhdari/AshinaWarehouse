using AWMS.dto;
using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWMS.core.Interfaces;
using AWMS.datalayer;

public class AreaUnitService : IAreaUnitService
{
    private readonly IUnitOfWork _unitOfWork;

    public AreaUnitService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<AreaUnitDto>> GetAllAreaUnitsAsync()
    {
        var AreaUnits = await _unitOfWork.AreaUnits.GetAllAsync();
        return AreaUnits.Select(AreaUnit => new AreaUnitDto
        {
            AreaUnitID = AreaUnit.AreaUnitID,
            AreaUnitName = AreaUnit.AreaUnitName,
            AreaUnitDescription = AreaUnit.AreaUnitDescription,
            AreaUnitTrain = AreaUnit.AreaUnitTrain,
            EnteredDate = AreaUnit.EnteredDate,
            Remark = AreaUnit.Remark
        }).ToList();
    }

    public IEnumerable<AreaUnitDto> GetAllAreaUnits()
    {
        var AreaUnits = _unitOfWork.AreaUnits.GetAll();
        return AreaUnits.Select(AreaUnit => new AreaUnitDto
        {
            AreaUnitID = AreaUnit.AreaUnitID,
            AreaUnitName = AreaUnit.AreaUnitName,
            AreaUnitDescription = AreaUnit.AreaUnitDescription,
            AreaUnitTrain = AreaUnit.AreaUnitTrain,
            EnteredDate = AreaUnit.EnteredDate,
            Remark = AreaUnit.Remark
        }).ToList();
    }

    public async Task<AreaUnitDto> GetAreaUnitByIdAsync(int AreaUnitID)
    {
        var AreaUnit = await _unitOfWork.AreaUnits.GetByIdAsync(AreaUnitID);
        if (AreaUnit == null) return null;

        return new AreaUnitDto
        {
            AreaUnitID = AreaUnit.AreaUnitID,
            AreaUnitName = AreaUnit.AreaUnitName,
            AreaUnitDescription = AreaUnit.AreaUnitDescription,
            AreaUnitTrain = AreaUnit.AreaUnitTrain,
            EnteredDate = AreaUnit.EnteredDate,
            Remark = AreaUnit.Remark
        };
    }

    public async Task<int> AddAreaUnitAsync(AreaUnitDto AreaUnitDto)
    {
        var AreaUnit = new AreaUnit
        {
            AreaUnitName = AreaUnitDto.AreaUnitName,
            AreaUnitDescription = AreaUnitDto.AreaUnitDescription,
            AreaUnitTrain = AreaUnitDto.AreaUnitTrain,
            EnteredDate = AreaUnitDto.EnteredDate,
            Remark = AreaUnitDto.Remark
        };

        await _unitOfWork.AreaUnits.AddAsync(AreaUnit);
        await _unitOfWork.CompleteAsync();
        return AreaUnit.AreaUnitID;
    }

    public async Task UpdateAreaUnitAsync(AreaUnitDto AreaUnitDto)
    {
        var AreaUnit = await _unitOfWork.AreaUnits.GetByIdAsync(AreaUnitDto.AreaUnitID);
        if (AreaUnit != null)
        {
            AreaUnit.AreaUnitName = AreaUnitDto.AreaUnitName;
            AreaUnit.AreaUnitDescription = AreaUnitDto.AreaUnitDescription;
            AreaUnit.AreaUnitTrain = AreaUnitDto.AreaUnitTrain;
            AreaUnit.EnteredDate = AreaUnitDto.EnteredDate;
            AreaUnit.Remark = AreaUnitDto.Remark;

            _unitOfWork.AreaUnits.Update(AreaUnit);
            await _unitOfWork.CompleteAsync();
        }
    }

    public async Task DeleteAreaUnitAsync(int AreaUnitID)
    {
        var AreaUnit = await _unitOfWork.AreaUnits.GetByIdAsync(AreaUnitID);
        if (AreaUnit != null)
        {
            _unitOfWork.AreaUnits.Delete(AreaUnit);
            await _unitOfWork.CompleteAsync();
        }
    }

    public async Task DeleteMultipleAreaUnitsWithTransactionAsync(IEnumerable<AreaUnitDto> AreaUnitDtos)
    {
        using (var transaction = await _unitOfWork.BeginTransactionAsync())
        {
            try
            {
                foreach (var AreaUnitDto in AreaUnitDtos)
                {
                    var AreaUnit = await _unitOfWork.AreaUnits.GetByIdAsync(AreaUnitDto.AreaUnitID);
                    if (AreaUnit != null)
                    {
                        _unitOfWork.AreaUnits.Delete(AreaUnit);
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
    public async Task<bool> ExistsAreaUnitAsync(string AreaUnitName)
    {
        return await _unitOfWork.AreaUnits.ExistsAreaUnitAsync(AreaUnitName);
    }
}
