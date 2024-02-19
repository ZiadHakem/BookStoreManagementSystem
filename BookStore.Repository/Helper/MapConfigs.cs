using AutoMapper;
using BookStore.Core.DTOs;
using BookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Helper
{
    public static class MapConfigs
    {
        private static MapperConfiguration config;
        public readonly static IMapper mapper;

        static MapConfigs()
        {
            config = new MapperConfiguration((cfg) =>
            {
                cfg.CreateMap<CustomerLoginParamsDTO, Customer>();
                cfg.CreateMap<Category, CategoryToReturnDTO>();
            });
            mapper = config.CreateMapper();
        }
    }
}
