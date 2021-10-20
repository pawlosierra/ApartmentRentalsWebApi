using System;
using System.Collections.Generic;

#nullable disable

namespace ApartmentRentalsWebApi.Infrastructure.Models
{
    public partial class RentalContractModel
    {
        public Guid Id { get; set; }
        public int IdClient { get; set; }
        public Guid IdApartment { get; set; }
        public string Description { get; set; }

        public virtual ApartmentModel IdApartmentNavigation { get; set; }
        public virtual ClientModel IdClientNavigation { get; set; }
    }
}
