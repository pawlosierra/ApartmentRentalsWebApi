using ApartmentRentalsWebApi.Domain.Models;
using ApartmentRentalsWebApi.DTOs.Apartments;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApartmentRentalsWebApi.Mappers
{
  public class ApartmentProfile : Profile
  {
    public ApartmentProfile()
    {
      CreateMap<Apartment, ApartmentResponse>();
      CreateMap<ApartmentRequest, Apartment>();
    }
  }
}
