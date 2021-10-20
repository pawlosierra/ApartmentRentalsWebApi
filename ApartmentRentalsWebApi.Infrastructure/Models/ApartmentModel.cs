using System;
using System.Collections.Generic;

#nullable disable

namespace ApartmentRentalsWebApi.Infrastructure.Models
{
    public partial class ApartmentModel
    {
        public ApartmentModel()
        {
            RentalContractModels = new HashSet<RentalContractModel>();
        }

        public Guid Id { get; set; }
        public string ApartmentNumber { get; set; }
        public int NumberRooms { get; set; }
        public int Area { get; set; }
        public decimal MontlyRent { get; set; }
        public int? NumberBathrooms { get; set; }

        public virtual ICollection<RentalContractModel> RentalContractModels { get; set; }
    }
}
