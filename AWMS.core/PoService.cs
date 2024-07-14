using AWMS.dto;
using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWMS.core.Interfaces;
using AWMS.datalayer;

public class PoService : IPoService
{
    private readonly IUnitOfWork _unitOfWork;

    public PoService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<PoDto>> GetAllPosAsync()
    {
        var Pos = await _unitOfWork.Pos.GetAllAsync();
        return Pos.Select(Po => new PoDto
        {
            PoId = Po.PoId,
            MrId = Po.MrId,
            PoName = Po.PoName,
            PoDescription = Po.PoDescription,
            EnteredDate = Po.EnteredDate
        }).ToList();
    }
    public IEnumerable<PoDto> GetAllPos()
    {
        var Pos = _unitOfWork.Pos.GetAll();
        return Pos.Select(Po => new PoDto
        {
            PoId = Po.PoId,
            MrId = Po.MrId,
            PoName = Po.PoName,
            PoDescription = Po.PoDescription,
            EnteredDate = Po.EnteredDate
        }).ToList();
    }
    public async Task<PoDto> GetPoByIdAsync(int id)
    {
        var Po = await _unitOfWork.Pos.GetByIdAsync(id);
        if (Po == null) return null;

        return new PoDto
        {
            PoId = Po.PoId,
            PoName = Po.PoName,
            PoDescription = Po.PoDescription,
            EnteredDate = Po.EnteredDate
        };
    }

    public async Task<int> AddPoAsync(PoDto PoDto)
    {
        var Po = new Po
        {
            MrId=PoDto.MrId,
            PoName = PoDto.PoName,
            PoDescription = PoDto.PoDescription,
            EnteredDate = PoDto.EnteredDate
        };

        await _unitOfWork.Pos.AddAsync(Po);
        await _unitOfWork.CompleteAsync();
        return Po.PoId;
    }

    public async Task UpdatePoAsync(PoDto PoDto)
    {
        var Po = await _unitOfWork.Pos.GetByIdAsync(PoDto.PoId);
        if (Po != null)
        {
            Po.MrId = PoDto.MrId;
            Po.PoName = PoDto.PoName;
            Po.PoDescription = PoDto.PoDescription;
            Po.EnteredDate = PoDto.EnteredDate;

            _unitOfWork.Pos.Update(Po);
            await _unitOfWork.CompleteAsync();
        }
    }

    public async Task DeletePoAsync(int id)
    {
        var Po = await _unitOfWork.Pos.GetByIdAsync(id);
        if (Po != null)
        {
            _unitOfWork.Pos.Delete(Po);
            await _unitOfWork.CompleteAsync();
        }
    }

    public async Task<int?> GetByPoNameAsync(string PoName)
    {
        return await _unitOfWork.Pos.GetByNameAsync(PoName);
    }

    public async Task DeleteMultiplePosWithTransactionAsync(IEnumerable<PoDto> PoDtos)
    {
        using (var transaction = await _unitOfWork.BeginTransactionAsync())
        {
            try
            {
                foreach (var PoDto in PoDtos)
                {
                    var Po = await _unitOfWork.Pos.GetByIdAsync(PoDto.PoId);
                    if (Po != null)
                    {
                        _unitOfWork.Pos.Delete(Po);
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

    public async Task<IEnumerable<PoIdAndPoNameDto>> GetPoIdAndNameAsync()
    {
        var Pos = await _unitOfWork.Pos.GetAllAsync();
        return Pos.Select(Po => new PoIdAndPoNameDto
        {
            PoId = Po.PoId,
            PoName = Po.PoName
        }).ToList();
    }

    public IEnumerable<PoIdAndPoNameDto> GetPoIdAndName()
    {
        var Pos =  _unitOfWork.Pos.GetPoIdAndName();
        return Pos.Select(Po => new PoIdAndPoNameDto
        {
            PoId = Po.PoId,
            PoName = Po.PoName
        }).ToList();
    }
}
