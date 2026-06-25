using System.Linq.Expressions;

namespace Contract;

public interface IBaseRepository<T>
{
    IQueryable<T> FindAll(bool trackChanges);
    IQueryable<T> FindByExpression(Expression<Func<T, bool>> predicate, bool trackChanges);
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}