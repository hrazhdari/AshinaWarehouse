using AWMS.dto;
using AWMS.dto.AWMS.datalayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWMS.dapper.Repositories
{
    public interface IRequestDapperRepository
    {
        Task<string?> NextMivNumber();
        Task<int> GetTotalRecordCount();
        Task<int> GetTotalItemRecordCount();
        Task<List<MaterialIssueVoucherDto>> MaterialIssueVoucherFillGrid(int pageNumber, int pageSize);
        Task<List<MaterialIssueVoucherDto>> SearchItemFillGrid(int pageNumber, int pageSize);
        //Task<List<LocItemBalanceDto>> GetLocItemOFSelectedItemID_FOR_ISSUE_VOUCHER(List<int> itemIds);
        Task<DataTable> GetLocItemOFSelectedItemID_FOR_ISSUE_VOUCHER(List<int> itemIds);
        Task AddRequests(List<RequestDto> requestMivs);
        Task InsertRequestBatchAsync(List<RequestDto> requestMivs);
        Task<List<string>> InsertRequestBatchWithReturnMivNumberAsync(List<RequestDto> requestMivs, int issuedBy);

        Task<DataTable> GetDataFromDatabaseAsync(string mivNumber);
    }
}
