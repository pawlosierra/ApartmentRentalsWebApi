using ApartmentRentalsWebApi.Domain.Models;
using ApartmentRentalsWebApi.Domain.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ApartmentRentalsWebApi.Application.Commands.Apartments.DeleteApartment
{
  public class DeleteApartmentHandler : IRequestHandler<DeleteApartment, Apartment>
  {
    private readonly IApartmentRepository _apartmentRepository;
    public DeleteApartmentHandler(
      IApartmentRepository apartmentRepository)
    {
      _apartmentRepository = apartmentRepository;
    }
    public async Task<Apartment> Handle(DeleteApartment request, CancellationToken cancellationToken)
    {
      return await _apartmentRepository.DeleteApartment(request.ApartmentId);
    }
  }
}
