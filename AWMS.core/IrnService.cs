using AWMS.dto;
using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWMS.core.Interfaces;
using AWMS.datalayer;

public class IrnService : IIrnService
{
    private readonly IUnitOfWork _unitOfWork;

    public IrnService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<IrnDto>> GetAllIrnsAsync()
    {
        var Irns = await _unitOfWork.Irns.GetAllAsync();
        return Irns.Select(Irn => new IrnDto
        {
            IrnId = Irn.IrnId,
            IrnName = Irn.IrnName,
            IrnDescription = Irn.IrnDescription,
            IrnPdf = Irn.IrnPdf,
            EnteredDate = Irn.EnteredDate
        }).ToList();
    }

    public IEnumerable<IrnDto> GetAllIrns()
    {
        var Irns = _unitOfWork.Irns.GetAll();
        return Irns.Select(Irn => new IrnDto
        {
            IrnId = Irn.IrnId,
            IrnName = Irn.IrnName,
            IrnDescription = Irn.IrnDescription,
            IrnPdf = Irn.IrnPdf,
            EnteredDate = Irn.EnteredDate
        }).ToList();
    }

    public async Task<IrnDto> GetIrnByIdAsync(int IrnId)
    {
        var Irn = await _unitOfWork.Irns.GetByIdAsync(IrnId);
        if (Irn == null) return null;

        return new IrnDto
        {
            IrnId = Irn.IrnId,
            IrnName = Irn.IrnName,
            IrnDescription = Irn.IrnDescription,
            IrnPdf = Irn.IrnPdf,
            EnteredDate = Irn.EnteredDate
        };
    }

    public async Task<int> AddIrnAsync(IrnDto IrnDto)
    {
        var Irn = new Irn
        {
            IrnName = IrnDto.IrnName,
            IrnDescription = IrnDto.IrnDescription,
            IrnPdf = IrnDto.IrnPdf,
            EnteredDate = IrnDto.EnteredDate
        };

        await _unitOfWork.Irns.AddAsync(Irn);
        await _unitOfWork.CompleteAsync();
        return Irn.IrnId;
    }

    public async Task UpdateIrnAsync(IrnDto IrnDto)
    {
        var Irn = await _unitOfWork.Irns.GetByIdAsync(IrnDto.IrnId);
        if (Irn != null)
        {
            Irn.IrnName = IrnDto.IrnName;
            Irn.IrnDescription = IrnDto.IrnDescription;
            Irn.IrnPdf = IrnDto.IrnPdf;
            Irn.EnteredDate = IrnDto.EnteredDate;

            _unitOfWork.Irns.Update(Irn);
            await _unitOfWork.CompleteAsync();
        }
    }

    public async Task DeleteIrnAsync(int IrnId)
    {
        var Irn = await _unitOfWork.Irns.GetByIdAsync(IrnId);
        if (Irn != null)
        {
            _unitOfWork.Irns.Delete(Irn);
            await _unitOfWork.CompleteAsync();
        }
    }

    public async Task DeleteMultipleIrnsWithTransactionAsync(IEnumerable<IrnDto> IrnDtos)
    {
        using (var transaction = await _unitOfWork.BeginTransactionAsync())
        {
            try
            {
                foreach (var IrnDto in IrnDtos)
                {
                    var Irn = await _unitOfWork.Irns.GetByIdAsync(IrnDto.IrnId);
                    if (Irn != null)
                    {
                        _unitOfWork.Irns.Delete(Irn);
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

    public async Task<IrnDto> GetIrnByIrnNameAsync(string IrnName)
    {
        var Irn = await _unitOfWork.Irns.GetByIrnNameAsync(IrnName);
        if (Irn == null) return null;

        return new IrnDto
        {
            IrnId = Irn.IrnId,
            IrnName = Irn.IrnName,
            IrnDescription = Irn.IrnDescription,
            IrnPdf = Irn.IrnPdf,
            EnteredDate = Irn.EnteredDate
        };
    }
    public async Task<bool> ExistsByIrnNameAsync(string IrnName)
    {
        return await _unitOfWork.Irns.ExistsByIrnNameAsync(IrnName);
    }
}
