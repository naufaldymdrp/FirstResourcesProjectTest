﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstResources.Web.Data.Business
{
    public class JenisKelamin
    {
        [Key]
        public int JenisKelaminId { get; set; }
        public string NamaJenisKelamin { get; set; }
                
        public List<DataKaryawan> DataKaryawan { get; set; }
    }
}
