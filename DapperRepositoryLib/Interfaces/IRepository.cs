using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DapperRepositoryLib.Interfaces
{
    public interface IRepository
    {
        Task<List<TModel>> GetAllAsync<TModel>() where TModel : class;
        Task<TModel> GetByIdAsync<TModel>(int id) where TModel : class;
        Task CreateAsync<TModel>(TModel obj) where TModel : class;
        Task DeleteAsync<TModel>(TModel obj) where TModel : class;
        Task UpdateAsync<TModel>(TModel obj) where TModel : class;
    }
}
