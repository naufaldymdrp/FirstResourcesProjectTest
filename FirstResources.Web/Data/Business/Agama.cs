using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstResources.Web.Data.Business
{
    public class Agama
    {
        [Key]
        public int AgamaId { get; set; }
        public string NamaAgama { get; set; }
       
        public List<DataKaryawan> DataKaryawan { get; set; }
    }
}
