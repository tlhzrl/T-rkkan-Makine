using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TürkkannMakinaa.Entities;

namespace TürkkannMakinaa
{
        public class LoginIM
        {
            [Required(ErrorMessage = "E-posta alanı boş geçilemez")]
            public string Email { get; set; }
            [Required(ErrorMessage = "Parola giriniz")]
            public string Password { get; set; }

            public bool RememberMe { get; set; }
        }

    public class LoginModel : PageModel
    {
        
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public LoginModel(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        [BindProperty]
        public LoginIM LoginİnputModel { get; set; }

        public async Task OnGet()
        {

            var user = new ApplicationUser
            {
                UserName = "ZORLU",
                Email = "ekremzorlu69@gmail.com",

            };

            var result = await _userManager.CreateAsync(user, "Türkkanmakine123+");

            if (result.Succeeded)
            {

            }

        }

        public async Task<IActionResult> OnPostLogin()
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(LoginİnputModel.Email);

                if (user != null)
                {
                    var passwordExist = await _userManager.CheckPasswordAsync(user, LoginİnputModel.Password);

                    var emailCorfirmed = await _userManager.IsEmailConfirmedAsync(user);

                    if (passwordExist && emailCorfirmed)
                    {
                        var result = await _signInManager.PasswordSignInAsync(user, LoginİnputModel.Password, LoginİnputModel.RememberMe, false);

                        if (result.Succeeded)
                        {
                            ViewData["ErrorMessage"] = null;
                            return new RedirectToPageResult("/Index");
                        }
                       }
                    else
                    {
                        ViewData["ErrorMessage"] = "Boyle bir parola yada şifre bulunamadı!";
                    }
                }
                //else
                //{
                //    ViewData["ErrorMessage"] = "Boyle bir parola yada şifre bulunamadı!";
                //}
            }
            return Page();
        }
    }


}