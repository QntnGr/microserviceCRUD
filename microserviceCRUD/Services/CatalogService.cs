using microserviceCRUD.Entities;
using microserviceCRUD.Infrastructure;

namespace microserviceCRUD.Services
{
    public class CatalogService : ICatalogService
    {

        CatalogContext _dbContext;
        public CatalogService(CatalogContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Insert(CatalogItem item)
        {
            _dbContext.Add(item);
            _dbContext.SaveChanges();
        }

        public List<CatalogItem> GetAll()
        {
            return _dbContext.CatalogItems.Select(ci => ci).ToList();
        }
    }
}
