namespace BackEndPizza.Helpers.Interfaces
{
    public interface IAbstractCrud<T>
    {
        bool Add(T item);
        bool Update(T item);
        bool Delete(T item);
        IQueryable<T> GetItems();
    }
}
