using ApartmentRentalsWebApi.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApartmentRentalsWebApi.Application.Queries.Apartments.GetApartmentByNumber
{
  public class GetApartmentByNumber : IRequest<Apartment>
  {
    public string ApartmentNumber { get; set; }
    public GetApartmentByNumber(
      string apartmentNumber)
    {
      ApartmentNumber = apartmentNumber;
    }
  }
}
