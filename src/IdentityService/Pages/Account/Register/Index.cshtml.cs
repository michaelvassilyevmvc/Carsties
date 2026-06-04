using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityService.Pages.Account.Register;

// adding headers so that an unregistered user can log in
[SecurityHeaders]
[AllowAnonymous]
public class Index : PageModel
{
    public void OnGet()
    {
        
    }
}