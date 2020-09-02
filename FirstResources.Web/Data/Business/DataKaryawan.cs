using System;
using System.Collections.Generic;
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

        public string TanggalLahir { get; set; }

        public List<Agama> Agama { get; set; }

        public List<JenisKelamin> JenisKelamin { get; set; }

        public List<Departemen> Departemen { get; set; }

        public List<Jabatan> Jabatan { get; set; }
    }
}
