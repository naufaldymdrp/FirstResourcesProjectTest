using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FirstResources.Web.Data;
using FirstResources.Web.Data.Business;

namespace FirstResources.Web.Pages
{
    public class _EditKaryawanModel : PageModel
    {
        private readonly FirstResources.Web.Data.BusinessDBContext _context;

        public _EditKaryawanModel(FirstResources.Web.Data.BusinessDBContext context)
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

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DataKaryawan = await _context.
                DataKaryawan
                .Include(item => item.JenisKelamin)
                .Include(item => item.Agama)
                .Include(item => item.Departemen)
                .Include(item => item.Jabatan)
                .Where(m => m.DataKaryawanId == id)
                .FirstOrDefaultAsync();

            if (DataKaryawan == null)
            {
                return NotFound();
            }
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

            _context.Attach(DataKaryawan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DataKaryawanExists(DataKaryawan.DataKaryawanId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./TabelKaryawan");
        }

        private bool DataKaryawanExists(int id)
        {
            return _context.DataKaryawan.Any(e => e.DataKaryawanId == id);
        }
    }
}
