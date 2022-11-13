using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KÜTÜPHANE_OTOMASYONU.Model
{
    public class KISI
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmatarihi { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }


        public KISI()
        {

        }


        public KISI(int id, string isim, string soyisim, DateTime olusturmatarihi, string kullaniciadi, string sifre, string yetki)
        {

            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.olusturmatarihi = olusturmatarihi;
            this.kullaniciadi = kullaniciadi;
            this.sifre = sifre;
            this.yetki = yetki;

        }

        public void setId (int id)
        {
            this.id = id;
        }
        public int GetId()
        {
            return this.id;
        }

        public void setisim(string isim)
        {
            this.isim=isim;
        }
        public string getisim()
        {
            return this.isim;
        }

        public void setsoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }
        public string getsoyisim()
        {
            return this.soyisim;
        }

        public void setolusturmatarihi(DateTime olusturmatarihi)
        {
            this.olusturmatarihi = olusturmatarihi;
        }
        public DateTime getolusturmatarihi()
        {
            return this.olusturmatarihi;
        }

        public void setkullaniciadi(string kullaniciadi)
        {
            this.kullaniciadi = kullaniciadi;
        }
        public string getkullaniciadi()
        {
            return this.kullaniciadi;
        }

        public void setsifre(string sifre)
        {
            this.sifre = sifre;
        }
        public string getsifre()
        {
            return this.sifre;
        }

        public void setyetki(string yetki)
        {
            this.yetki = yetki;
        }
        public string getyetki()
        {
            return this.yetki;
        }

        public override string ToString()
        {
            return "İSİM - SOYİSİM : " + this.isim + " " + this.soyisim;
        }

        public static implicit operator KISI(KİTAP v)
        {
            throw new NotImplementedException();
        }
    }
}
