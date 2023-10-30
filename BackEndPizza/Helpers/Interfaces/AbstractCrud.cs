using Microsoft.EntityFrameworkCore;

namespace BackEndPizza.Helpers.Interfaces
{
    public abstract class AbstractCrud<T>: IAbstractCrud<T>
    {
        private readonly ApplicationDbContext _dbContext;

        public AbstractCrud(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public virtual void Add(T item)
        {
            _dbContext.Add(item);
            _dbContext.SaveChanges();
        }
        public void Update(T item)
        {
            _dbContext.Update(item);
            _dbContext.SaveChanges();
        }
        public void Delete(T item)
        {
            _dbContext.Update(item);
            _dbContext.SaveChanges();
        }
    }
}
