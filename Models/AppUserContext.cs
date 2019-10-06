using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApplication.Models
{
    public class AppUserContext : IdentityDbContext
    {
        AppUser ocmm = new AppUser();
       
    }
}
