using System.Linq.Expressions;
using Contract;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public abstract class RepositoryBase<T>: IBaseRepository<T> where T : class
{
    private readonly CurrencyAlertContext _context;
    
    public RepositoryBase(CurrencyAlertContext context)
    {
        _context =  context;
    }
    
    public IQueryable<T> FindAll(bool trackChanges)
    {
        return trackChanges ? _context.Set<T>() : _context.Set<T>().AsNoTracking();
    }

    public IQueryable<T> FindByExpression(Expression<Func<T, bool>> predicate, bool trackChanges)
    {
        return trackChanges ? _context.Set<T>().Where(predicate) : 
            _context.Set<T>().Where(predicate).AsNoTracking();
    }

    public void Create(T entity)
    { 
       _context.Set<T>().Add(entity);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }
}