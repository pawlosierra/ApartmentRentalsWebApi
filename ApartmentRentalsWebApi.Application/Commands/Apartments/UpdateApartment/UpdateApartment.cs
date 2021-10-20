using ApartmentRentalsWebApi.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApartmentRentalsWebApi.Application.Commands.Apartments.UpdateApartment
{
  public class UpdateApartment : IRequest<Apartment>
  {
    public Guid ApartmentNumber { get; set; }
    public Apartment Apartment { get; set; }
    public UpdateApartment(
      Guid apartmentNumber,
      Apartment apartment)
    {
      ApartmentNumber = apartmentNumber;
      Apartment       = apartment;
    }
  }
}
