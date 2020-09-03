using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("AgamaId")]
        public Agama Agama { get; set; }
        [ForeignKey("JenisKelaminId")]
        public JenisKelamin JenisKelamin { get; set; }
        [ForeignKey("DepartemenId")]
        public Departemen Departemen { get; set; }
        [ForeignKey("JabatanId")]
        public Jabatan Jabatan { get; set; }
    }
}
