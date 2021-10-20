using ApartmentRentalsWebApi.Domain.Models;
using MediatR;

namespace ApartmentRentalsWebApi.Application.Commands.Apartments.AddApartment
{
  public class AddApartment : IRequest<Apartment>
  {
    public Apartment Apartment { get; set; }
    public AddApartment(
      Apartment apartment)
    {
      Apartment = apartment;
    }
  }
}
