using System;
using System.Collections.Generic;

#nullable disable

namespace ApartmentRentalsWebApi.Infrastructure.Models
{
    public partial class ClientModel
    {
        public ClientModel()
        {
            RentalContractModels = new HashSet<RentalContractModel>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
        public string WorkAddress { get; set; }

        public virtual ICollection<RentalContractModel> RentalContractModels { get; set; }
    }
}
