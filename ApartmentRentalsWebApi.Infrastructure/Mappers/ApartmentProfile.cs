using ApartmentRentalsWebApi.Domain.Models;
using ApartmentRentalsWebApi.Infrastructure.Models;
using AutoMapper;

namespace ApartmentRentalsWebApi.Infrastructure.Mappers
{
  public class ApartmentProfile : Profile
  {
    public ApartmentProfile()
    {
      CreateMap<ApartmentModel, Apartment>().ReverseMap();
    }
  }
}
