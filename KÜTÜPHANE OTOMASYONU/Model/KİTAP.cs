using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KÜTÜPHANE_OTOMASYONU.Model
{
    public class KİTAP
    {
        private int v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;
        private int v6;
        private int v7;
        private int v8;

        public int kitapid { get; set; }
        public string kitapisim { get; set; }
        public string kitapyazar { get; set; }
        public string kitapdili { get; set; }
        public string yayınevi { get; set; }
        public string tür { get; set; }
        public int adet { get; set; }
        public int sayfasayısı { get; set; }
        public int basımyılı { get; set; }


        public KİTAP()
        {

        }

        public KİTAP(int kitapid, string kitapisim, string kitapyazar, string kitapdili, string yayınevi, string tür, int adet, int sayfasayısı, int basımyılı)
        {
            this.kitapid = kitapid;
            this.kitapisim = kitapisim;
            this.kitapyazar = kitapyazar;
            this.kitapdili = kitapdili;
            this.yayınevi = yayınevi;
            this.tür = tür;
            this.adet = adet;
            this.sayfasayısı = sayfasayısı;
            this.basımyılı = basımyılı;
        }

        public KİTAP(int v1, string v2, string v3, string v4, string v5, int v6, int v7, int v8)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
            this.v8 = v8;
        }

        public int getkıtapid()
        {
            return this.kitapid;
        }
        public string getkitapisim()
        {
            return this.kitapisim;
        }
        public string getkitapyazar()
        {
            return this.kitapyazar;
        }
        public string getkitapdili()
        {
            return this.kitapdili;
        }
        public string getyayınevi()
        {
            return this.yayınevi;
        }
        public string gettür()
        {
            return this.tür;
        }
        public int getadet()
        {
            return this.adet;
        }
        public int getsayfasayısı()
        {
            return this.sayfasayısı;
        }
        public int getbasımyılı()
        {
            return this.basımyılı;
        }
    }
}
