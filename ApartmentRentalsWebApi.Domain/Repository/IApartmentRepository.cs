using ApartmentRentalsWebApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApartmentRentalsWebApi.Domain.Repository
{
  public interface IApartmentRepository
  {
    Task<IEnumerable<Apartment>> GetApartments();
    Task<Apartment> AddApartment(Apartment apartmentRequest);
    Task<Apartment> GetApartmentByNumber(string apartmentNumber);
    Task<Apartment> UpdateApartment(Apartment apartmentRequest, Guid apartmentId);
    Task<Apartment> DeleteApartment(Guid apartmentId);
  }
}
