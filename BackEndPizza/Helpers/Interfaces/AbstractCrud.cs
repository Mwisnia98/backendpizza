using Microsoft.EntityFrameworkCore;

namespace BackEndPizza.Helpers.Interfaces
{
    public abstract class AbstractCrud<T>: IAbstractCrud<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;

        public AbstractCrud(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public virtual bool Add(T item)
        {
            _dbContext.Add(item);
            return _dbContext.SaveChanges() == 1;
        }
        public virtual bool Update(T item)
        {
            _dbContext.Update(item);
            return _dbContext.SaveChanges() == 1;
        }
        public virtual bool Delete(T item)
        {
            _dbContext.Remove(item);
            return _dbContext.SaveChanges() == 1;
        }
        public virtual IQueryable<T> GetItems()
        {
            return _dbContext.Set<T>().AsQueryable();
        }
    }
}
