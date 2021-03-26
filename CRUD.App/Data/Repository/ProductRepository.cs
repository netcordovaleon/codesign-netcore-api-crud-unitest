using CRUD.App.Data.Communication;
using CRUD.App.Data.Entities;
using CRUD.App.Shared.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace CRUD.App.Data.Repository
{

    public interface IProductRepository : IRepositoryBase<ProductBE>
    {
        Task<IList<ProductBE>> GetAllProductsAsync();
        Task<ProductBE> GetProductByIdAsync(int id);
        Task<ProductBE> SaveProductAsync(ProductBE product);
    }
    public class ProductRepository : RepositoryBase<ProductBE>, IProductRepository
    {
        public ProductRepository(MaintenanceContext repositoryPatternDemoContext) : base(repositoryPatternDemoContext)
        {
        }

        public async Task<IList<ProductBE>> GetAllProductsAsync()
        {
            return await GetAll().ToListAsync();
        }

        public Task<ProductBE> GetProductByIdAsync(int id)
        {
            return GetAll().FirstOrDefaultAsync(c => c.Id == id);
        }

        public Task<ProductBE> SaveProductAsync(ProductBE product)
        {
            return AddAsync(product);
        }
    }
}
