using AutoMapper;
using CRUD.App.Data.Entities;
using CRUD.App.Data.Repository;
using CRUD.App.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.App.Services
{

    public interface IProductService
    {
        Task<IList<ProductDTO>> GetAllProductsAsync();
        Task<ProductDTO> GetProductByIdAsync(int id);
        Task<ProductDTO> SaveProductAsync(ProductDTO obj);
    }

    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            this._productRepository = productRepository;
            this._mapper = mapper;
        }
        public async Task<IList<ProductDTO>> GetAllProductsAsync()
        {
            var result = await this._productRepository.GetAllProductsAsync();
            var dto = _mapper.Map<IList<ProductDTO>>(result);
            return dto;
        }

        public async Task<ProductDTO> GetProductByIdAsync(int id)
        {
            var result = await this._productRepository.GetProductByIdAsync(id);
            var dto = _mapper.Map<ProductDTO>(result);
            return dto;
        }

        public async Task<ProductDTO> SaveProductAsync(ProductDTO obj)
        {
            var entry = _mapper.Map<ProductBE>(obj);
            var result = await this._productRepository.SaveProductAsync(entry);
            var dto = _mapper.Map<ProductDTO>(result);
            return dto;
        }
    }
}
