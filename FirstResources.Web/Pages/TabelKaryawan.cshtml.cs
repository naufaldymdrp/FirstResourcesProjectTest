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
    public class TabelKaryawanModel : PageModel
    {
        private readonly BusinessDBContext _context;

        public TabelKaryawanModel(BusinessDBContext context)
        {
            _context = context;
        }

        public IList<DataKaryawan> DataKaryawan { get;set; }

        public async Task OnGetAsync()
        {
            DataKaryawan = await _context.DataKaryawan.ToListAsync();
        }
    }
}
