using ApartmentRentalsWebApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRentalsWebApi.Domain.Repository
{
  public interface IClientRepository
  {
    Task<IEnumerable<Client>> GetClients();
  }
}
