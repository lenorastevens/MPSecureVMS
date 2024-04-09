using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MPSecureVMS.Models;
using MPSecureVMS.Services;
using MPSecureVMS.Pages;

namespace MPSecureVMS.Pages.Vendors
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly MPSecureVMS.Services.ApplicationDbContext _context;

        public IndexModel(MPSecureVMS.Services.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Vendor> Vendor { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? States { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? VendorState { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? VendorNameSort { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? ContactSort { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? StateSort { get; set; }

        [BindProperty(SupportsGet = true)]
        public string sortOrder { get; set; } = "";

        public async Task OnGetAsync()
        {
            VendorNameSort = sortOrder == "vendor_desc"?  "vendor_asc" : "vendor_desc";
            ContactSort = sortOrder == "contact_desc" ? "contact_asc" : "contact_desc";
            StateSort = sortOrder == "state_desc"? "state_asc" : "state_desc";

            IQueryable<string> stateQuery = from s in _context.Vendor orderby s.State select s.State;

            var vendors = from v in _context.Vendor
                         select v;
            if (!string.IsNullOrEmpty(SearchString))
            {
                vendors = vendors.Where(s => s.VendorName.Contains(SearchString) || s.Contact.Contains(SearchString) || s.Notes.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(VendorState))
            {
                vendors = vendors.Where(x => x.State == VendorState);
            }

            States = new SelectList(await stateQuery.Distinct().ToListAsync());

            switch (sortOrder)
            {
                case "vendor_desc":
                    vendors = vendors.OrderByDescending(b => b.VendorName);
                    VendorNameSort = "vendor_asc"; 
                    break;
                case "vendor_asc":
                    vendors = vendors.OrderBy(b => b.VendorName);
                    VendorNameSort = "vendor_desc"; 
                    break;
                case "contact_asc":
                    vendors = vendors.OrderBy(d => d.Contact);
                    ContactSort = "contact_desc";
                    break;
                case "contact_desc":
                    vendors = vendors.OrderByDescending(d => d.Contact);
                    ContactSort = "contact_asc";
                    break;
                case "state_asc":
                    vendors = vendors.OrderBy(d => d.State);
                    StateSort = "state_desc";
                    break;
                case "state_desc":
                    vendors = vendors.OrderByDescending(d => d.State);
                    StateSort = "state_asc";
                    break;
                default:
                    vendors = vendors.OrderBy(b => b.VendorName);
                    VendorNameSort = "vendor_desc";
                    break;
            }
                        
            Vendor = await vendors.AsNoTracking().ToListAsync();
        }
    }
}
