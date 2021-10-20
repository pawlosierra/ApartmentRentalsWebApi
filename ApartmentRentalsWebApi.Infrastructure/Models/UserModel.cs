using System;
using System.Collections.Generic;

#nullable disable

namespace ApartmentRentalsWebApi.Infrastructure.Models
{
    public partial class UserModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
