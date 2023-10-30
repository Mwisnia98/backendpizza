using BackEndPizza.Helpers.Interfaces;
using BackEndPizza.Models.Tables;

namespace BackEndPizza.Data.ProducsService;

    public class ProducsData : AbstractCrud<Producs>, IProducsData
{
        private readonly ApplicationDbContext _dbContext;

        public ProducsData(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Producs[] GetProducs() =>_dbContext.Producs.ToArray();
    }

