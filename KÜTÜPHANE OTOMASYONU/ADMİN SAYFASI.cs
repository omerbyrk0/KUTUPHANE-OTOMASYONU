using KÜTÜPHANE_OTOMASYONU.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KÜTÜPHANE_OTOMASYONU
{
    public partial class ADMİN_SAYFASI : Form
    {

        List<KISI> kısılerım;
        List<KİTAP> kitaplarım;

        public ADMİN_SAYFASI(List<KISI> kısılerım, List<KİTAP> kitaplarım)
        {
            InitializeComponent();
            this.kısılerım = kısılerım;
            this.kitaplarım = kitaplarım;
        }

        private void ADMİN_SAYFASI_Load(object sender, EventArgs e)
        {
            foreach(KISI kısı in kısılerım)
            {
                dataGridView1.Rows.Add(kısı.GetId(), kısı.getisim(), kısı.getsoyisim(), kısı.getolusturmatarihi(), kısı.getkullaniciadi(), kısı.getsifre(), kısı.getyetki());

            }

            

            foreach(KİTAP kitap in kitaplarım)
            {
                dataGridView2.Rows.Add(kitap.getkıtapid(), kitap.getkitapisim(), kitap.getkitapyazar(), kitap.getkitapdili(), kitap.getyayınevi(), kitap.gettür(), kitap.getadet(), kitap.getsayfasayısı(), kitap.getbasımyılı());
            }
            //BU ŞEKİLDE SADECE ORDA YAZDIRABİLİRİZ.
            dataGridView2.Rows.Add(6, "NE İÇİN VARSAN ONUN İÇİN YAŞA", "HİKMET ANIL ÖZTEKİN", "TÜRKÇE", "KİTAP YURDU YAYINEVİ", "ROMAN", 60, 180, 2019);
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txt_id.Text, txt_isim.Text, txt_soyisim.Text, maskedTextBox1.Text, txt_kullaniciadi.Text, txt_sifre.Text, txt_yetki.Text);
            txt_id.Text = "";
            txt_isim.Text = "";
            txt_soyisim.Text = "";
            maskedTextBox1.Text = "";
            txt_kullaniciadi.Text = "";
            txt_sifre.Text = "";
            txt_yetki.Text = "";
            MessageBox.Show("KAYIT EKLENDİ !", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            
            MessageBox.Show("KAYIT SİLİNDİ !", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string olusturmatarihi = maskedTextBox1.Text;
            string kullaniciadi = txt_kullaniciadi.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyisim, olusturmatarihi, kullaniciadi, sifre, yetki);

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_isim.Text = "";
            txt_soyisim.Text = "";
            maskedTextBox1.Text = "";
            txt_kullaniciadi.Text = "";
            txt_sifre.Text = "";
            txt_yetki.Text = "";
        }

        public void textleridoldur()
        {

            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kullaniciadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleridoldur();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_kitapid.Text, txt_kitapismi.Text, txt_kitapyazar.Text, txt_kitapdili.Text, txt_kitapyayınevi.Text, txt_kitaptür.Text, txt_kitapadet.Text, txt_kitapsayfasyısı.Text, txt_kitapbasımyılı.Text);
        }

        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_kitapgüncelle_Click(object sender, EventArgs e)
        {
            string kitapid = txt_kitapid.Text;
            string kitapismi = txt_kitapismi.Text;
            string kitapyazar = txt_kitapyazar.Text;
            string kitapdili = txt_kitapdili.Text;
            string kitapyayınevi = txt_kitapyayınevi.Text;
            string kitaptür = txt_kitaptür.Text;
            string kitapadet = txt_kitapadet.Text;
            string kitapsayfasayısı = txt_kitapsayfasyısı.Text;
            string basımyılı = txt_kitapbasımyılı.Text;

            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kitapid, kitapismi, kitapyazar, kitapdili, kitapyayınevi, kitaptür, kitapadet, kitapsayfasayısı, basımyılı);

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_kitapismi.Text= dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_kitapyazar.Text= dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_kitapdili.Text= dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_kitapyayınevi.Text= dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_kitaptür.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_kitapadet.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_kitapsayfasyısı.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_kitapbasımyılı.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_kitaptemizle_Click(object sender, EventArgs e)
        {
            txt_kitapid.Text = "";
            txt_kitapismi.Text = "";
            txt_kitapyazar.Text = "";
            txt_kitapdili.Text = "";
            txt_kitapyayınevi.Text = "";
            txt_kitaptür.Text = "";
            txt_kitapadet.Text = "";
            txt_kitapsayfasyısı.Text = "";
            txt_kitapbasımyılı.Text = "";


        }

        private void btn_kısıara_Click(object sender, EventArgs e)
        {
            KISI hedefkısı = null;

            int secılenkısıID = Convert.ToInt32(textBox1.Text);

            foreach(KISI kişi in kısılerım)
            {
                if (kişi.GetId()==secılenkısıID)
                {
                    hedefkısı = kişi;
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkısı.GetId(), hedefkısı.getisim(), hedefkısı.getsoyisim(), hedefkısı.getolusturmatarihi(), hedefkısı.getkullaniciadi(), hedefkısı.getsifre(), hedefkısı.getyetki());
            
        }

        private void btn_kısıyenıle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//BU YAPILMAZSA ARANAN KİŞİ 2 TANE OLUŞUR.

            foreach (KISI kısı in kısılerım)
            {
                dataGridView1.Rows.Add(kısı.GetId(), kısı.getisim(), kısı.getsoyisim(), kısı.getolusturmatarihi(), kısı.getkullaniciadi(), kısı.getsifre(), kısı.getyetki());

            }
        }

        private void btn_kitapara_Click(object sender, EventArgs e)
        {
            KİTAP hedefkitap = null;

            int secılenkıtapID = Convert.ToInt32(textBox2.Text);

            foreach (KİTAP kitap in kitaplarım)
            {
                if (kitap.getkıtapid() == secılenkıtapID)
                {
                    hedefkitap = kitap;
                    break;
                }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefkitap.getkıtapid(), hedefkitap.getkitapisim(), hedefkitap.getkitapyazar(), hedefkitap.getkitapdili(), hedefkitap.getyayınevi(), hedefkitap.gettür(), hedefkitap.getadet(), hedefkitap.getsayfasayısı(), hedefkitap.getbasımyılı());


        }

        private void btn_kitapyenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            foreach(KİTAP kitap in kitaplarım)
            {
                dataGridView2.Rows.Add(kitap.getkıtapid(), kitap.getkitapisim(), kitap.getkitapyazar(), kitap.getkitapdili(), kitap.getyayınevi(), kitap.gettür(), kitap.getadet(), kitap.getsayfasayısı(), kitap.getbasımyılı());
            }

        }

        private void btn_cıkısadmın_Click(object sender, EventArgs e)
        {
            Form1 logınsayfası = new Form1();
            MessageBox.Show("ÇIKIŞ YAPILDI.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            logınsayfası.Show();
            this.Hide();
            
        }
    }
}
