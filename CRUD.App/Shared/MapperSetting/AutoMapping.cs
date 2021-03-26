using AutoMapper;
using CRUD.App.Data.Entities;
using CRUD.App.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.App.Shared.MapperSetting
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<ProductBE, ProductDTO>();
            CreateMap<ProductDTO, ProductBE>();

        }
    }
}
