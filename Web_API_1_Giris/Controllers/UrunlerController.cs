using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_API_1_Giris.Models;

namespace Web_API_1_Giris.Controllers
{
    public class UrunlerController : ApiController
    {
        List<Urun> urunListesi = new List<Urun>
        {
            new Urun{ id = 1, urun_adi = "Lucille", fiyat = 500 },
            new Urun{ id = 2, urun_adi = "Katana", fiyat = 350 },
            new Urun{ id = 3, urun_adi = "Axe", fiyat = 200 }
        };

        public List<Urun> GetUrunleriGetir()
        {
            return urunListesi;
        }

        public Urun GetUrunleriGetir(int id)
        {
            return urunListesi[id];
        }
    }
}