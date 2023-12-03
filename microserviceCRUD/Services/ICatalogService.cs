using microserviceCRUD.Entities;

namespace microserviceCRUD.Services;

public interface ICatalogService
{
    void Insert(CatalogItem item);
    List<CatalogItem> GetAll();
}
