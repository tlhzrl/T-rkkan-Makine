using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TürkkannMakinaa.Entities
{
    public class ApplicationUser : IdentityUser
    {
        internal ApplicationUser loginInputModel;
    }
}
