using BackEndPizza.Helpers.Interfaces;
using BackEndPizza.Models.Dto;
using System.Collections.Concurrent;

namespace BackEndPizza.Data.QueueService
{
    public class QueueProductsService: IQueueProductsService
    {
        private ConcurrentList<QueueProducts> _queues = new ConcurrentList<QueueProducts>(); // to nie to chyba
        public QueueProductsService() { }

        public void AddItem(QueueProducts queue)
        {
            _queues.Add(queue);
        }

        public void RemoveItem(QueueProducts queue)
        {
            var result = _queues.Remove(queue);
        }
        public void UpdateItem(QueueProducts queue)
        {
             _queues[_queues.IndexOf(queue)] = queue;
        }

        public IEnumerable<QueueProducts> GetItems() => _queues.AsEnumerable();
    }
}
