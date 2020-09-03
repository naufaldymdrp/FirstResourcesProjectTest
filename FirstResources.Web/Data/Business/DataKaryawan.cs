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

        // inverse navigation and foreign key dibuat 
        // tidak boleh null dan eksplisit 
        [Display(Name = "Agama")]
        public int AgamaId { get; set; }
        public Agama Agama { get; set; }      
        
        [Display(Name = "Jenis Kelamin")]
        public int JenisKelaminId { get; set; }
        [Display(Name = "Jenis Kelamin")]
        public JenisKelamin JenisKelamin { get; set; }   
        
        [Display(Name = "Departemen")]
        public int DepartemenId { get; set; }
        public Departemen Departemen { get; set; }        

        [Display(Name = "Jabatan")]
        public int JabatanId { get; set; }
        public Jabatan Jabatan { get; set; }
    }
}
