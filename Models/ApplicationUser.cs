using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace Administration.Models
{
    public class ApplicationUser: IdentityUser
    {

        public bool InternalUser { get; set; }
    }
}
