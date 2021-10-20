using ApartmentRentalsWebApi.Domain.Models;
using ApartmentRentalsWebApi.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApartmentRentalsWebApi.Application.Queries.Apartments.GetApartments
{
  public class GetApartmentsHandler : IRequestHandler<GetApartments, IEnumerable<Apartment>>
  {
    private readonly IApartmentRepository _apartmentRepository;
    public GetApartmentsHandler(
      IApartmentRepository apartmentRepository)
    {
      _apartmentRepository = apartmentRepository;
    }

    public async Task<IEnumerable<Apartment>> Handle(GetApartments request, CancellationToken cancellationToken)
    {
      return await _apartmentRepository.GetApartments();
    }
  }
}
