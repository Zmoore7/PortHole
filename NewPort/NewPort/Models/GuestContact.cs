using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NewPort.Models
{
    public class GuestContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email_Id { get; set; }
    }

    public class GuestDBContext : DbContext
    {
        public DbSet<GuestContact> Guests { get; set; }
    }
}
