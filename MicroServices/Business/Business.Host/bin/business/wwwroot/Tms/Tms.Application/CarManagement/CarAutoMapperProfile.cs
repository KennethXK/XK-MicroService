using AutoMapper;
using Tms.CarManagement.Dto;
using Tms.Models;

namespace Tms.CarManagement
{
    public class CarAutoMapperProfile : Profile
    {
        public CarAutoMapperProfile()
        {
            CreateMap<Car, CarDto>();
            CreateMap<CreateOrUpdateCarDto, Car>();
        }
    }
}
