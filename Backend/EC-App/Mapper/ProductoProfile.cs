using AutoMapper;
using EC_App.Dto;
using EC_App.Models;
using System.Threading;

namespace EC_App.Mapper
{
    public class ProductoProfile : Profile
    {
        public ProductoProfile()
        {
            CreateMap<Product, ProductoMostrarDto>().ReverseMap();
            CreateMap<Product, ProductoLeerDto>().ReverseMap();
        }
    }
}
