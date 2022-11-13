using KÜTÜPHANE_OTOMASYONU.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KÜTÜPHANE_OTOMASYONU
{
    public partial class Form1 : Form
    {

        List<KISI> kısılerım = new List<KISI>();//o classtan obje oluşturduk.
        List<KİTAP> kitaplarım = new List<KİTAP>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temızle_Click(object sender, EventArgs e)
        {
            txt_kullanıcıadı.Text = "";
            txt_sıfre.Text = "";

        }

        private void btn_gırıs_Click(object sender, EventArgs e)
        {
            string kullaniciadi, sifre = "";
            kullaniciadi = txt_kullanıcıadı.Text;
            sifre = txt_sıfre.Text;



            bool kontrol = false;

            foreach (KISI kısı in kısılerım)//kısı nesnesini kısılerimdeki insanları kısı classına ata.
            {
                if (kullaniciadi == kısı.getkullaniciadi() && sifre == kısı.getsifre() && kısı.getyetki() == "ADMİN")
                {
                    //admin sayfasına gönderir.
                    ADMİN_SAYFASI adminsayfası = new ADMİN_SAYFASI(kısılerım,kitaplarım);
                    adminsayfası.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }

                else if (kullaniciadi == kısı.getkullaniciadi() && sifre == kısı.getsifre() && kısı.getyetki() == "ÜYE")
                {
                    //ÜYE SAYFASINA GÖNDERİR.
                    ÜYE_SAYFASI üyesayfası = new ÜYE_SAYFASI(kitaplarım);
                    üyesayfası.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                

            }
            if (kontrol==false)//kontrol false ise
            {
                 MessageBox.Show("LÜTFEN KULLANICI ADI VE ŞİFREYİ DOĞRU GİRİNİZ !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kısılerım.Add(new KISI(1, "ÖMER", "BAYRAK", DateTime.Now, "ÖMER", "1", "ADMİN"));//YENİ KİŞİ ATADIK.
            kısılerım.Add(new KISI(2, "EBRU", "BAYRAK", DateTime.Now, "EBRU", "2", "ÜYE"));
            kısılerım.Add(new KISI(3, "ELİS", "BAYRAK", DateTime.Now, "ELİS", "3", "ÜYE"));
            kısılerım.Add(new KISI(4, "BARAN", "BAYRAK", DateTime.Now, "BARAN", "4", "ÜYE"));
            kısılerım.Add(new KISI(5, "ALPER", "SANCAR", DateTime.Now,"KİNCİ", "1263", "ÜYE"));

            kitaplarım.Add(new KİTAP(1, "İÇİMİZDEKİ ŞEYTAN", "SEBAHATTİN ALİ", "TÜRKÇE", "YAPI KREDİ YAYINLARI","ROMAN", 100, 250, 2016));
            kitaplarım.Add(new KİTAP(2, "TUTUNAMAYANLAR", "OĞUZ ATAY", "TÜKÇE", "İLETİŞİM YAYINCILIK", "ROMAN", 350, 760, 2015));
            kitaplarım.Add(new KİTAP(3,"UÇURTMA AVCISI","KHALED HOSSEINI","İNGİLİZCE","EVEREST YAYINCILIK","ROMAN",100,350,2010));
            kitaplarım.Add(new KİTAP(4, "KÜÇÜK PRENS", "ANTOINE DE SAINT-EXUPERY", "İNGİLİZCE", "CAN ÇOCUK YAYINLARI", "ROMAN", 50, 60, 2018));
            kitaplarım.Add(new KİTAP(5, "KÜRK MANTOLU MADONNA", "SEBAHATTİN ALİ", "TÜRKÇE", "YAPI KREDİ YAYINLARI", "ROMAN", 650, 220, 2015));


        }
    }
}
