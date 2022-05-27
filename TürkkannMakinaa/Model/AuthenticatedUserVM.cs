using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TürkkannMakinaa.Model
{
    public class AuthenticatedUserVM
    {
        public string UserName { get; set; }
        public bool Authenticated { get; set; }
    }
}
