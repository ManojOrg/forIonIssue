using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApplication.Models
{
    public class AppUser: IdentityUser
    {
        public string CompanyID { get; set; }

    }
}
