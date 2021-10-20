using System;

namespace ApartmentRentalsWebApi.DTOs.Apartments
{
  public class ApartmentResponse
  {
    public Guid Id { get; set; }
    public string ApartmentNumber { get; set; }
    public int NumberRooms { get; set; }
    public int Area { get; set; }
    public decimal MontlyRent { get; set; }
    public int? NumberBathrooms { get; set; }
  }
}
