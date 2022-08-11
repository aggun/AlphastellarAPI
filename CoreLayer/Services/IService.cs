using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
namespace CoreLayer.Services
{
    public interface IService<T> where T : class
    {
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
    }
}
