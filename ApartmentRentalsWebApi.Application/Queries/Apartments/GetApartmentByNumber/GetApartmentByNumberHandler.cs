using ApartmentRentalsWebApi.Domain.Models;
using ApartmentRentalsWebApi.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApartmentRentalsWebApi.Application.Queries.Apartments.GetApartmentByNumber
{
  public class GetApartmentByNumberHandler : IRequestHandler<GetApartmentByNumber, Apartment>
  {
    private readonly IApartmentRepository _apartmentRepository;
    public GetApartmentByNumberHandler(
      IApartmentRepository apartmentRepository)
    {
      _apartmentRepository = apartmentRepository;
    }
    public async Task<Apartment> Handle(GetApartmentByNumber request, CancellationToken cancellationToken)
    {
      return await _apartmentRepository.GetApartmentByNumber(request.ApartmentNumber);
    }
  }
}
