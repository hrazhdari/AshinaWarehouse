﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AWMS.dto;

namespace AWMS.dapper.Repositories
{
    public interface IItemDapperRepository
    {
        Task<IEnumerable<ItemDto>> GetAllAsync();
        Task<IEnumerable<ItemDto>> GetAllItemByPlIdAsync(int PlId);
        Task<ItemDto> GetByIdAsync(int id);
        Task AddAsync(ItemDto item);
        Task UpdateAsync(ItemDto item);
        Task DeleteAsync(int id);
        //Task AddItemWithAddLocitemWithTriggerAsync(ItemDto itemDto, int locationId);
        Task<int> AddItemWithAddLocitemWithTriggerAsync(ItemDto item, int locationId);
        Task DeleteMultipleItemsWithTransactionAsync(IEnumerable<ItemDto> items);
    }
}