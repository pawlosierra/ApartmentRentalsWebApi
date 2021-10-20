using System;
using System.Collections.Generic;
using System.Text;

namespace ApartmentRentalsWebApi.Domain.Models
{
  public class Client
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Occupation { get; set; }
    public string Cellphone { get; set; }
    public string Email { get; set; }
    public string WorkAddress { get; set; }
  }
}
