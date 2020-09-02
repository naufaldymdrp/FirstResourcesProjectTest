using FirstResources.Web.Data.Business;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstResources.Web.Data
{
    public class BusinessDBContext: DbContext
    {
        public BusinessDBContext(DbContextOptions<BusinessDBContext> options)
            : base(options)
        { }

        public DbSet<DataKaryawan> DataKaryawan { get; set; }
        public DbSet<Agama> Agama { get; set; }
        public DbSet<Departemen> Departemen { get; set; }
        public DbSet<JenisKelamin> JenisKelamin { get; set; }
        public DbSet<Jabatan> Jabatan { get; set; }
    }
}
