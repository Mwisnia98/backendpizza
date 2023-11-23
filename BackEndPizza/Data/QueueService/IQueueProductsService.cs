using BackEndPizza.Models.Dto;

namespace BackEndPizza.Data.QueueService
{
    public interface IQueueProductsService
    {
        void AddItem(QueueProducts queue);
        void RemoveItem(QueueProducts queue);
        void UpdateItem(QueueProducts queue);

        IEnumerable<QueueProducts> GetItems();
    }
}
