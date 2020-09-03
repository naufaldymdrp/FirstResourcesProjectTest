using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FirstResources.Web.Data;
using FirstResources.Web.Data.Business;

namespace FirstResources.Web.Pages
{
    public class InputKaryawanModel : PageModel
    {
        private readonly FirstResources.Web.Data.BusinessDBContext _context;

        public InputKaryawanModel(FirstResources.Web.Data.BusinessDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DataKaryawan DataKaryawan { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DataKaryawan.Add(DataKaryawan);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
