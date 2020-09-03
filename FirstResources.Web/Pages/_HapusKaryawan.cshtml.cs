using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FirstResources.Web.Data;
using FirstResources.Web.Data.Business;

namespace FirstResources.Web.Pages
{
    public class _HapusKaryawanModel : PageModel
    {
        private readonly FirstResources.Web.Data.BusinessDBContext _context;

        public _HapusKaryawanModel(FirstResources.Web.Data.BusinessDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DataKaryawan DataKaryawan { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DataKaryawan = await _context.DataKaryawan
                .Include(d => d.Agama)
                .Include(d => d.Departemen)
                .Include(d => d.Jabatan)
                .Include(d => d.JenisKelamin).FirstOrDefaultAsync(m => m.DataKaryawanId == id);

            if (DataKaryawan == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DataKaryawan = await _context.DataKaryawan.FindAsync(id);

            if (DataKaryawan != null)
            {
                _context.DataKaryawan.Remove(DataKaryawan);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./TabelKaryawan");
        }
    }
}
