using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MySkillTest.Application.Abstractions.IRepository;
using MySkillTest.Domain.Domain.Shared;
using MySkillTest.Persistence.Data;

namespace MySkillTest.Persistence.Repositories
{
    public class BaseRepository<T> :IBaseRepository<T> where T : BaseModal,new()
    {
        private readonly MySkillTestDbContext context;

        public BaseRepository(MySkillTestDbContext context)
        {
            this.context = context;
        }
        public async Task<int> DeleteAsync(T model)
        {   
            await Task.Run(() => context.Set<T>().Remove(model));
            return await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> expression)
        {
            return await Task.Run(() => context.Set<T>().Where(expression));
        }

        public async Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            return await context.Set<T>().FirstOrDefaultAsync(expression);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Task.Run(() => context.Set<T>().ToList());
        }

        public async Task<T?> GetByIdAsync(Guid? Id)
        {
            return await context.Set<T>().FindAsync(Id);
        }

        public async Task<int> InsertAsync(T model)
        {
            await context.Set<T>().AddAsync(model);
            return await context.SaveChangesAsync();
        }

        public async Task<int> InsertRangeAsync(List<T> model)
        {
            await context.Set<T>().AddRangeAsync(model);
            return await context.SaveChangesAsync();
        }

        public async Task<bool> IsExistsAsync(Expression<Func<T, bool>> expression)
        {
            return await context.Set<T>().AnyAsync(expression);

        }

        public async Task<int> UpdateAsync(T model)
        {
            await Task.Run(() => context.Set<T>().Update(model));

            return await context.SaveChangesAsync();
        }
        //public async Task<IEnumerable<string>> GetEmailsAsync(List<string> emails)
        //{
        //    var result = await context.MasterUsers
        //            .Where(m => emails.Contains(m.Email))
        //            .Select(m => m.Email)
        //            .ToListAsync();

        //    return result;
        //}

    }
}
