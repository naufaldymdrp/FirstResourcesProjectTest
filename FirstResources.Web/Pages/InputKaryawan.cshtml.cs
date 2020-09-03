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

        [BindProperty]
        public DataKaryawan DataKaryawan { get; set; }

        [BindProperty]
        public List<SelectListItem> PilihanAgama
            => _context.Agama
                .Select(item =>
                new SelectListItem
                {
                    Value = item.AgamaId.ToString(),
                    Text = item.NamaAgama
                })
                .ToList();

        [BindProperty]
        public List<JenisKelamin> PilihanJenisKelamin
            => _context.JenisKelamin
                .Select(jenisKelamin => jenisKelamin)
                .ToList();

        [BindProperty]
        public List<SelectListItem> PilihanDepartemen
            => _context.Departemen
                .Select(departemen =>
                new SelectListItem
                {
                    Value = departemen.DepartemenId.ToString(),
                    Text = departemen.Nama
                })
                .ToList();

        [BindProperty]
        public List<SelectListItem> PilihanJabatan
            => _context.Jabatan
                .Select(jabatan =>
                new SelectListItem
                {
                    Value = jabatan.JabatanId.ToString(),
                    Text = jabatan.Nama
                })
                .ToList();        

        public IActionResult OnGet()
        {          

            return Page();
        }

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

            return RedirectToPage("./TabelKaryawan");
        }
    }
}
