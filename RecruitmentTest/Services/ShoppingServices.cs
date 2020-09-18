using RecruitmentTest.Entities;
using RecruitmentTest.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentTest.Services
{
    public interface IShoppingService
    {
        // process show All data also can show specific data
        Task<IEnumerable<Shopping>> ListAsync(int ID);
        // process save data
        Task<ShoppingResponse> SaveAsync(Shopping shopping);
        // process update all data, mark as done and set todo will complate
        Task<ShoppingResponse> UpdateAsync(int id, Shopping shopping);
        // process delete data todo list
        Task<ShoppingResponse> DeleteAsync(int id);
    }

    public class ShoppingServices : IShoppingService
    {
        public Task<ShoppingResponse> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Shopping>> ListAsync(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingResponse> SaveAsync(Shopping shopping)
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingResponse> UpdateAsync(int id, Shopping shopping)
        {
            throw new NotImplementedException();
        }
    }
}
