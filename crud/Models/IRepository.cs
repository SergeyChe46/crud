using System.Linq.Expressions;

namespace crud.Models
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        IQueryable<T> GetByExpression(Expression<Func<T, bool>> expression);
        Task Create(T entity);
        Task Update(T entity);
        void Delete(T entity);
    }
}
