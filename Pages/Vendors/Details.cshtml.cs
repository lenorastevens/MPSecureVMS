using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MPSecureVMS.Models;
using MPSecureVMS.Services;

namespace MPSecureVMS.Pages.Vendors
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly MPSecureVMS.Services.ApplicationDbContext _context;

        public DetailsModel(MPSecureVMS.Services.ApplicationDbContext context)
        {
            _context = context;
        }

        public Vendor Vendor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendor.FirstOrDefaultAsync(m => m.VendorId == id);
            if (vendor == null)
            {
                return NotFound();
            }
            else
            {
                Vendor = vendor;
            }
            return Page();
        }
    }
}
