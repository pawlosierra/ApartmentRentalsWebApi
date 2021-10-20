using ApartmentRentalsWebApi.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApartmentRentalsWebApi.Application.Queries.Apartments.GetApartments
{
  public class GetApartments : IRequest<IEnumerable<Apartment>>
  {
  }
}
