using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Application.Abstractions.IRepository
{
    public interface IBaseRepository<T>where T:BaseModal,new()
    {
        Task<int> InsertAsync(T model);
        Task<int> InsertRangeAsync(List<T> model);
        Task<int> UpdateAsync(T model);
        Task<int> DeleteAsync(T model);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> expression);
        Task<T?> GetByIdAsync(int Id);
        Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression);
        Task<bool> IsExistsAsync(Expression<Func<T, bool>> expression);
        //Task<IEnumerable<string>> GetEmailsAsync(List<string> emails);
    }
}
