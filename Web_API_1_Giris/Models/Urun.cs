using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_API_1_Giris.Models
{
    public class Urun
    {
        public int id { get; set; }
        public string urun_adi { get; set; }
        public decimal fiyat { get; set; }
    }
}