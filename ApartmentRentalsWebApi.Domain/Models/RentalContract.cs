using System;
using System.Collections.Generic;
using System.Text;

namespace ApartmentRentalsWebApi.Domain.Models
{
  public class RentalContract
  {
    public Guid Id { get; set; }
    public int IdClient { get; set; }
    public Guid IdApartment { get; set; }
    public string ApartmentNumber { get; set; }
    public string Description { get; set; }
  }
}
