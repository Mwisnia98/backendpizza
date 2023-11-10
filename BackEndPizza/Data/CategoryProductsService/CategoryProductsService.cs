using BackEndPizza.Helpers.Interfaces;

namespace BackEndPizza.Data.CategoryProductsService
{
    public class CategoryProductsService : AbstractCrud<CategoryProducts>, ICategoryProductsService
    {
        public CategoryProductsService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
