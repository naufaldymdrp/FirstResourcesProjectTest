using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstResources.Web.Data.Business
{
    public class DataKaryawan
    {
        public int DataKaryawanId { get; set; }
        public string NIK { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        [Display(Name = "Tanggal Lahir")]
        public DateTime TanggalLahir { get; set; }

        // inverse navigation and shadow property (foreign key)
        public Agama Agama { get; set; }
        public JenisKelamin JenisKelamin { get; set; }
        public Departemen Departemen { get; set; }
        public Jabatan Jabatan { get; set; }
    }
}
