using ApartmentRentalsWebApi.Domain.Models;
using ApartmentRentalsWebApi.Domain.Repository;
using ApartmentRentalsWebApi.Infrastructure.Data;
using ApartmentRentalsWebApi.Infrastructure.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApartmentRentalsWebApi.Infrastructure.Repositories
{
  public class ApartmentRepository : IApartmentRepository
  {
    private readonly ApartmentRentalsContext _apartmentRentalsContext;
    private readonly IMapper                 _mapper;
    public ApartmentRepository(
      ApartmentRentalsContext apartmentRentalsContext,
      IMapper                 mapper)
    {
      _apartmentRentalsContext = apartmentRentalsContext;
      _mapper                  = mapper;
    }

    public async Task<Apartment> AddApartment(Apartment apartmentRequest)
    {
      apartmentRequest.Id = Guid.NewGuid();
      var createdApartment = await _apartmentRentalsContext.ApartmentModels
        .AddAsync(_mapper.Map<ApartmentModel>(apartmentRequest));
      await _apartmentRentalsContext.SaveChangesAsync();
      return apartmentRequest;
    }

    public async Task<Apartment> GetApartmentByNumber(string apartmentNumber)
    {
      var apartmentRequest = await _apartmentRentalsContext.ApartmentModels
        .Where(x => x.ApartmentNumber == apartmentNumber)
        .FirstOrDefaultAsync();
      return _mapper.Map<Apartment>(apartmentRequest);
    }

    public async Task<IEnumerable<Apartment>> GetApartments()
    {
      var apartments = await _apartmentRentalsContext.ApartmentModels
        .OrderBy(x => x.ApartmentNumber)
        .ToListAsync();
      return _mapper.Map<IEnumerable<Apartment>>(apartments);
    }

    public async Task<Apartment> UpdateApartment(Apartment apartmentRequest, Guid apartmentId)
    {
      var apartment = await ApartmentExist(apartmentId);
      apartment.MontlyRent = apartmentRequest.MontlyRent;
      _apartmentRentalsContext.ApartmentModels.Update(apartment);
      await _apartmentRentalsContext.SaveChangesAsync();
      return _mapper.Map<Apartment>(apartment);
    }

    public async Task<ApartmentModel> ApartmentExist(Guid apartmentId)
    {
      var apartment = await _apartmentRentalsContext.ApartmentModels
        .FindAsync(apartmentId);
      return apartment;
    }

    public async Task<Apartment> DeleteApartment(Guid apartmentId)
    {
      var apartment = await ApartmentExist(apartmentId);
      _apartmentRentalsContext.ApartmentModels.Remove(apartment);
      await _apartmentRentalsContext.SaveChangesAsync();
      return _mapper.Map<Apartment>(apartment);
    }
  }
}
