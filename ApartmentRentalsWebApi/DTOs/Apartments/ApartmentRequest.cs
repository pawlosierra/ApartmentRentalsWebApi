using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApartmentRentalsWebApi.DTOs.Apartments
{
  public class ApartmentRequest
  {
    public string ApartmentNumber { get; set; }
    public int NumberRooms { get; set; }
    public int Area { get; set; }
    public decimal MontlyRent { get; set; }
    public int? NumberBathrooms { get; set; }
  }
}
