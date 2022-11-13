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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KÜTÜPHANE_OTOMASYONU
{
    public partial class ÜYE_SAYFASI : Form
    {
        List<KİTAP> kitaplarım;

        public ÜYE_SAYFASI(List<KİTAP> kitaplarım)
        {
            InitializeComponent();
            this.kitaplarım = kitaplarım;
        }


        public ÜYE_SAYFASI()
        {
            InitializeComponent();
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Form1 logınsayfası = new Form1();

            MessageBox.Show("ÇIKIŞ YAPILDI.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            logınsayfası.Show();
            this.Hide();
            
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            {
                KİTAP hedefkitap = null;

                int secılenkıtapID = Convert.ToInt32(textBox1.Text);

                foreach (KİTAP kitap in kitaplarım)
                {
                    if (kitap.getkıtapid() == secılenkıtapID)
                    {
                        hedefkitap = kitap;
                        break;
                    }
                    

                }
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(hedefkitap.getkıtapid(), hedefkitap.getkitapisim(), hedefkitap.getkitapyazar(), hedefkitap.getkitapdili(), hedefkitap.getyayınevi(), hedefkitap.gettür(), hedefkitap.getadet(), hedefkitap.getsayfasayısı(), hedefkitap.getbasımyılı());



            }
        }
            private void btn_yenıle_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();

            foreach (KİTAP kitap in kitaplarım)
            {
                dataGridView1.Rows.Add(kitap.getkıtapid(), kitap.getkitapisim(), kitap.getkitapyazar(), kitap.getkitapdili(), kitap.getyayınevi(), kitap.gettür(), kitap.getadet(), kitap.getsayfasayısı(), kitap.getbasımyılı());
            }

        }

        private void ÜYE_SAYFASI_Load(object sender, EventArgs e)
        {
            foreach (KİTAP kitap in kitaplarım)
            {
                dataGridView1.Rows.Add(kitap.getkıtapid(), kitap.getkitapisim(), kitap.getkitapyazar(), kitap.getkitapdili(), kitap.getyayınevi(), kitap.gettür(), kitap.getadet(), kitap.getsayfasayısı(), kitap.getbasımyılı());
            }
        }
    }
}
