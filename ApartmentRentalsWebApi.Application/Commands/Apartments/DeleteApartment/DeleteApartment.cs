using ApartmentRentalsWebApi.Domain.Models;
using MediatR;
using System;

namespace ApartmentRentalsWebApi.Application.Commands.Apartments.DeleteApartment
{
  public class DeleteApartment : IRequest<Apartment>
  {
    public Guid ApartmentId { get; set; }
    public DeleteApartment(
      Guid apartmentId)
    {
      ApartmentId = apartmentId;
    }
  }
}
