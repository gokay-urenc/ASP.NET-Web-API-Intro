using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API_1_Giris.Controllers
{
    public class DefaultController : ApiController
    {
        List<string> sehirler = new List<string>() { "Los Santos", "San Fierro", "Las Venturas", "Liberty City" };
        List<string> sehirler_2 = new List<string>() { "Dead Center", "Dark Carnival", "Swamp Fever", "Hard Rain" };
        [HttpGet] // Eklenebilir.
        public List<string> Getir() // Method adının başına Get koyarsak HttpGet yapmış oluruz.
        {
            return sehirler;
        }

        public string Getir(int id) // Overload.
        {
            return sehirler[id];
        }

        // Bir controller, default olarak http methodlarından her türden bir adete cevap verebilir.
        // Yani 1 adet get, 1 adet post, put, delete işlemi varsa sıkıntı yoktur.
        // Ama bu tiplerdeki method sayısı controller içerisinde artarsa WebApiConfig dosyasında route olayı düzeltilmelidir.
        public List<string> GetSehirlerim()
        {
            return sehirler_2;
        }

        // Web API uygulamasında açılan sayfa sadece get methodlarını çalıştırır.
        // Get methodları hariç diğer işlemler için farklı uygulamalardan tetikleme yapmak gerekir.
        // Bu yüzden Postman kullanılabilir.
        [HttpPost]
        public void Ekle()
        {
        }
    }
}
/* Web Servis: HTTP protokolü ile XML(Api ile json, png formatlarıda dahil olacak.) veri gönderip alarak iki ya da daha fazla
   cihaz(platform) arasında iletişimi sağlayan bir haberleşme yöntemidir.
   XML olması sayesinde değişik platformlar ve programlama dilleri arasında haberleşme sağlanabilir.
   Web Servisler, Service Oriented Architecture(SOA)'nın dahil edilmiş halidir.
   SOA'da iki farklı yazılım birbiriyle haberleşir.
   Bu yazılımlardan bir tanesi istemci bir tanesi ise sunucudur.
   İstemci sunucuya istekte bulunur, sunucu da istemciye cevap döner.
   HTTP protokolü ile XML veya Json'a serileştirilmiş veri gönderip alarak platform bağımsız haberleşme olayıdır.
   Örneğin Java ile yazılmış bir programla C# ile yazılmış bir program arasında veri alışverişi olabilir.
   REST(Representational State Transfer): Client-server iletişimiyle ilgili bir mimaridir.
   HTTP protokolü ile paralel olarak gelişmiş olmasının yanı sıra bugün en çok www(World Wide Web) sisteminde kullanılıyor.
   REST mimarisini kullanan servislere genel olarak RESTFull servis deniyor.
   Client-server arasındaki veri alışverişini SOAP, RPC gibi komplike mimarilerle sağlamak yerine HTTP üzerinden sağlamaktır.
   SOAP: HTTP üzerinden uygulamaların bilgi alışverişinin gerçekleşmesini sağlayan XML tabanlı bir protokoldür.
   Yani web servislere erişmek için kullanılan protokoldür.
   Platform bağımsızdır(Client'in Windows, Server'in Linux olmasının hiç bir önemi yoktur).
   Dil bağımsızdır.
   HTTP üzerinden çalışırlar.
   Esnekler ve çok kolay genişletilebilirler.
   API(Application Programming Interface[Uygulama Geliştirme Arayüzü])
   Web API: .NET platformuna aittir. Dönüş tipi olarak xml, json, png formatında veri dönebilir.
   Microsoft: Biz daha iyisini yapana kadar en iyisi bu.
   Web Servisler, HTTP methodları ile iletişime geçerler.
   CRUD     |   HTTP Methods
   Create  =>   Post
   Read    =>   Get
   Update  =>   Put
   Delete  =>   Delete
   Bir servise yapılan istek cevap olarak bir status(durum) code döner. HTTP Status Code denir.
   Tarayıcıdan web server'a bir servis isteği gönderildiğinde hata meydana gelebilir.
   HTTP Status code'ler ile bu hata durumlarında veya başarılı
*/