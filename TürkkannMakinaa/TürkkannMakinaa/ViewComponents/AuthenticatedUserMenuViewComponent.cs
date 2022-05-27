using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TürkkannMakinaa.Model;

namespace TürkkannMakinaa.ViewComponents
{
    public class AuthenticatedUserMenuViewComponent : ViewComponent
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthenticatedUserMenuViewComponent (IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new AuthenticatedUserVM
            {
                Authenticated = _httpContextAccessor.HttpContext.User.Identity.IsAuthenticated,
                UserName = _httpContextAccessor.HttpContext.User.Identity.Name
            };

            return View(model);
        }
    }
}
