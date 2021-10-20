using ApartmentRentalsWebApi.Domain.Models;
using ApartmentRentalsWebApi.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApartmentRentalsWebApi.Application.Commands.Apartments.AddApartment
{
  public class AddApartmentHandler : IRequestHandler<AddApartment, Apartment>
  {
    private readonly IApartmentRepository _apartmentRepository;
    public AddApartmentHandler(
      IApartmentRepository apartmentRepository)
    {
      _apartmentRepository = apartmentRepository;
    }

    public async Task<Apartment> Handle(AddApartment request, CancellationToken cancellationToken)
    {
      return await _apartmentRepository.AddApartment(request.Apartment);
    }
  }
}
