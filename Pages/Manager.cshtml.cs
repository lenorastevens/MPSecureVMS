using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MPSecureVMS.Pages
{
    [Authorize(Roles = "manager")]
    public class ManagerModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
