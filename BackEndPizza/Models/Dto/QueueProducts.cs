using BackEndPizza.Models.Common;

namespace BackEndPizza.Models.Dto
{
    public record QueueProducts(Guid Id, IEnumerable<int> ProductsId,string? description,string adress,TimeSpan EstimatedTime, DateTime OrderDate, Status Status);
}
