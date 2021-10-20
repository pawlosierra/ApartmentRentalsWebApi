using System;
using System.Collections.Generic;
using System.Text;

namespace ApartmentRentalsWebApi.Domain.Models
{
  public class Apartment
  {
    public Guid Id { get; set; }
    public string ApartmentNumber { get; set; }
    public int NumberRooms { get; set; }
    public int Area { get; set; }
    public decimal MontlyRent { get; set; }
    public int? NumberBathrooms { get; set; }
  }
}
