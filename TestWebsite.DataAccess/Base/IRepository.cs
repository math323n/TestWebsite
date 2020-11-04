using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestWebsite.Entities.Models.Context;

namespace TestWebsite.DataAccess.Base
{
    /// <summary>
    /// Base repository interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepositoryBase<T>
    {
        NorthwindContext Context { get; set; }

        Task AddAsync(T t);
        Task<T> GetByIdAsync(int? id);
        Task<IEnumerable<T>> GetAllAsync();
        Task UpdateAsync(T t);
        Task DeleteAsync(T t);
    }
}
