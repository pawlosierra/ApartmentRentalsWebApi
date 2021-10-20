using ApartmentRentalsWebApi.Domain.Models;
using ApartmentRentalsWebApi.Domain.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ApartmentRentalsWebApi.Application.Commands.Apartments.UpdateApartment
{
  public class UpdateApartmentHandler : IRequestHandler<UpdateApartment, Apartment>
  {
    private readonly IApartmentRepository _apartmentRepository;
    public UpdateApartmentHandler(
      IApartmentRepository apartmentRepository)
    {
      _apartmentRepository = apartmentRepository;
    }
    public async Task<Apartment> Handle(UpdateApartment request, CancellationToken cancellationToken)
    {
      return await _apartmentRepository.UpdateApartment(request.Apartment, request.ApartmentNumber);
    }
  }
}
