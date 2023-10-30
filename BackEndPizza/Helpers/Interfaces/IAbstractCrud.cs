namespace BackEndPizza.Helpers.Interfaces
{
    public interface IAbstractCrud<T>
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
    }
}
