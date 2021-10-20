using ApartmentRentalsWebApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRentalsWebApi.Domain.Repository
{
  public interface IRentalContractRepository
  {
    Task<IEnumerable<RentalContract>> GetRentalContracts();
  }
}
