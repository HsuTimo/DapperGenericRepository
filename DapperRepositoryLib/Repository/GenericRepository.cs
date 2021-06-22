using Dapper.Contrib.Extensions;
using DapperRepositoryLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperRepositoryLib.Repository
{
    public class GenericRepository:IRepository
    {
        private readonly IConnectionHelper _connectionHelper;
        public GenericRepository(IConnectionHelper connectionHelper)
        {
            _connectionHelper = connectionHelper;
        }
        public async Task CreateAsync<TModel>(TModel obj) where TModel : class
        {
            using (var connection = _connectionHelper.GetConnection())
            {
                connection.Open();
                await connection.InsertAsync(obj);
            }
        }
        public async Task DeleteAsync<TModel>(TModel obj) where TModel : class
        {
            using (var connection = _connectionHelper.GetConnection())
            {
                connection.Open();
                await connection.DeleteAsync(obj);
            }
        }
        public async Task<List<TModel>> GetAllAsync<TModel>() where TModel : class
        {
            using (var connection = _connectionHelper.GetConnection())
            {
                connection.Open();
                var list = await connection.GetAllAsync<TModel>();
                return list.ToList();
            }
        }
        public async Task<TModel> GetByIdAsync<TModel>(int id) where TModel : class
        {
            using (var connection = _connectionHelper.GetConnection())
            {
                connection.Open();
                var obj = await connection.GetAsync<TModel>(id);
                return obj;
            }
        }
        public async Task UpdateAsync<TModel>(TModel obj) where TModel : class
        {
            using (var connection = _connectionHelper.GetConnection())
            {
                connection.Open();
                await connection.UpdateAsync(obj);
            }
        }
    }
}
