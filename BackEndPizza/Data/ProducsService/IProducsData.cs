using BackEndPizza.Helpers.Interfaces;
using BackEndPizza.Models.Tables;

namespace BackEndPizza.Data.ProducsService
{
    public interface IProducsData : IAbstractCrud<Producs>
    {
        IEnumerable<Producs> GetProducs();
    }
}
