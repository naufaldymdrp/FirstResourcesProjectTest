﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstResources.Web.Data.Business
{
    public class Jabatan
    {
        [Key]
        public int JabatanId { get; set; }
        public string Nama { get; set; }
                
        public List<DataKaryawan> DataKaryawan { get; set; }
    }
}
