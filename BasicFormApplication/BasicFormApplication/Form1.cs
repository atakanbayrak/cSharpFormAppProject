using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label lblTanim1 = new Label();
        Label lblTanim2 = new Label();
        TextBox txtSayi = new TextBox();
        Button btnHesapla = new Button();
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Fazla Değer Girdiniz","messageBox");

            lblTanim1.Text = "X";
            lblTanim2.Text = "Y";

            lblTanim1.Width = 50;
            lblTanim1.Location = new Point(200, 90);

            lblTanim2.Width = 50;
            lblTanim2.Location = new Point(200, 130);

            txtSayi.Width = 100;
            txtSayi.Height = 30;
            txtSayi.Location = new Point(250, 90);

            btnHesapla.Text = "Hesapla";
            btnHesapla.Width = 100;
            btnHesapla.Location = new Point(250, 170);

            btnHesapla.Click += new EventHandler(btnHesapla_Click);

            this.Controls.Add(lblTanim1);
            this.Controls.Add(lblTanim2);

            this.Controls.Add(txtSayi);
            this.Controls.Add(btnHesapla);
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Label lblYazi = new Label();
            lblYazi.Visible = true;
            lblYazi.Width = 10000;
            lblYazi.Location = new Point(250, 130);

            string birler = "";
            string onlar = "";
            string yüzler = "";
            string binler = "";
            string onbinler = "";
            string sifir = "";
            string kesirBinler = "";
            string kesirYüzler = "";
            string kesirOnlar = "";
            string kesirBirler = "";
            string kesirSifir = "";
            string para = txtSayi.Text;
            string kesirKısım = "";
            string tamSayi = "";
            string onbinlerTam = "";
            string onbinlerKesir = "";
            string binlerTam = "";
            int kesirKısım2 = 0;
            int kontrolDegiskeni = 0;
            int tamKisim = 0;

            string sayilar = "1,2,3,4,5,6,7,8,9,0,.";
            for (int i = 0; i < para.Length; i++)
            {
                if (sayilar.Contains(para[i]))
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("Hatalı Karakter Girildi");
                    Environment.Exit(0);
                }
            }

            char[] karakterler = para.ToCharArray();
            int l = 0;
            for (l = 0; l < para.Length; l++)
            {

                if (karakterler[l] == '.')
                {
                    kontrolDegiskeni = 1;
                    break;

                }
            }
            if (para.Length > 5 && kontrolDegiskeni == 0)
            {
                MessageBox.Show("Karakter Sınırı Aşıldı Veya Yetersiz Karakter Girildi");
                Environment.Exit(0);
            }

            if (kontrolDegiskeni == 1)
            {
                tamSayi = para.Substring(0, l);
                tamKisim = Convert.ToInt32(tamSayi);
                kesirKısım = para.Substring(l + 1);
                kesirKısım2 = Convert.ToInt32(kesirKısım);
            }
            else
            {
                tamKisim = Convert.ToInt32(para);
            }
            if (para.Length == 5 && kontrolDegiskeni == 0)
            {
                tamSayi = para.Substring(0, 2);
                tamKisim = Convert.ToInt32(tamSayi);

                switch ((tamKisim / 10))
                {
                    case 9: onbinlerTam = ("Doksan "); break;
                    case 8: onbinlerTam = ("Seksen "); break;
                    case 7: onbinlerTam = ("Yetmiş "); break;
                    case 6: onbinlerTam = ("Altmış "); break;
                    case 5: onbinlerTam = ("Elli "); break;
                    case 4: onbinlerTam = ("Kırk "); break;
                    case 3: onbinlerTam = ("Otuz "); break;
                    case 2: onbinlerTam = ("Yirmi "); break;
                    case 1: onbinlerTam = ("On "); break;
                }
                switch ((tamKisim % 10))
                {
                    case 9: binlerTam = ("Dokuz "); break;
                    case 8: binlerTam = ("Sekiz "); break;
                    case 7: binlerTam = ("Yedi "); break;
                    case 6: binlerTam = ("Altı "); break;
                    case 5: binlerTam = ("Beş "); break;
                    case 4: binlerTam = ("Dört "); break;
                    case 3: binlerTam = ("Üç "); break;
                    case 2: binlerTam = ("İki "); break;
                    case 1: binlerTam = ("Bir "); break;
                }
                if (tamKisim == 0)
                {
                    sifir = "Sıfır";
                }
                tamSayi = para.Substring(2);
                tamKisim = Convert.ToInt32(tamSayi);

                switch ((tamKisim % 1000) / 100)
                {
                    case 9: yüzler = ("Dokuz Yüz "); break;
                    case 8: yüzler = ("Sekiz Yüz "); break;
                    case 7: yüzler = ("Yedi Yüz "); break;
                    case 6: yüzler = ("Altı Yüz "); break;
                    case 5: yüzler = ("Beş Yüz "); break;
                    case 4: yüzler = ("Dört Yüz "); break;
                    case 3: yüzler = ("Üç Yüz "); break;
                    case 2: yüzler = ("İki Yüz "); break;
                    case 1: yüzler = ("Yüz "); break;
                }
                switch ((tamKisim % 100) / 10)
                {
                    case 9: onlar = ("Doksan "); break;
                    case 8: onlar = ("Seksen "); break;
                    case 7: onlar = ("Yetmiş "); break;
                    case 6: onlar = ("Altmış "); break;
                    case 5: onlar = ("Elli "); break;
                    case 4: onlar = ("Kırk "); break;
                    case 3: onlar = ("Otuz "); break;
                    case 2: onlar = ("Yirmi "); break;
                    case 1: onlar = ("On "); break;
                }
                switch ((tamKisim % 10))
                {
                    case 9: birler = ("Dokuz "); break;
                    case 8: birler = ("Sekiz "); break;
                    case 7: birler = ("Yedi "); break;
                    case 6: birler = ("Altı "); break;
                    case 5: birler = ("Beş "); break;
                    case 4: birler = ("Dört "); break;
                    case 3: birler = ("Üç "); break;
                    case 2: birler = ("İki "); break;
                    case 1: birler = ("Bir "); break;
                }

                lblYazi.Text = onbinlerTam + binlerTam + sifir + "Bin " + yüzler + onlar + birler + " TL";
                this.Controls.Add(lblYazi);

            }
            else
            {
                switch (tamKisim / 1000)
                {
                    case 9: binler = ("Dokuz Bin "); break;
                    case 8: binler = ("Sekiz Bin "); break;
                    case 7: binler = ("Yedi Bin "); break;
                    case 6: binler = ("Altı Bin "); break;
                    case 5: binler = ("Beş Bin "); break;
                    case 4: binler = ("Dört Bin "); break;
                    case 3: binler = ("Üç Bin "); break;
                    case 2: binler = ("İki Bin "); break;
                    case 1: binler = ("Bin "); break;
                }
                switch ((tamKisim % 1000) / 100)
                {
                    case 9: yüzler = ("Dokuz Yüz "); break;
                    case 8: yüzler = ("Sekiz Yüz "); break;
                    case 7: yüzler = ("Yedi Yüz "); break;
                    case 6: yüzler = ("Altı Yüz "); break;
                    case 5: yüzler = ("Beş Yüz "); break;
                    case 4: yüzler = ("Dört Yüz "); break;
                    case 3: yüzler = ("Üç Yüz "); break;
                    case 2: yüzler = ("İki Yüz "); break;
                    case 1: yüzler = ("Yüz "); break;
                }
                switch ((tamKisim % 100) / 10)
                {
                    case 9: onlar = ("Doksan "); break;
                    case 8: onlar = ("Seksen "); break;
                    case 7: onlar = ("Yetmiş "); break;
                    case 6: onlar = ("Altmış "); break;
                    case 5: onlar = ("Elli "); break;
                    case 4: onlar = ("Kırk "); break;
                    case 3: onlar = ("Otuz "); break;
                    case 2: onlar = ("Yirmi "); break;
                    case 1: onlar = ("On "); break;
                }
                switch ((tamKisim % 10))
                {
                    case 9: birler = ("Dokuz "); break;
                    case 8: birler = ("Sekiz "); break;
                    case 7: birler = ("Yedi "); break;
                    case 6: birler = ("Altı "); break;
                    case 5: birler = ("Beş "); break;
                    case 4: birler = ("Dört "); break;
                    case 3: birler = ("Üç "); break;
                    case 2: birler = ("İki "); break;
                    case 1: birler = ("Bir "); break;
                }
                if (tamKisim == 0)
                {
                    sifir = "Sıfır";
                }
                // KESİR KISIM BAŞLANGICI

                if (tamKisim < 10 && para.Length == 7)
                {
                    string birlerTam = "";
                    kesirKısım = para.Substring(2, 2);
                    kesirKısım2 = Convert.ToInt32(kesirKısım);

                    tamSayi = para.Substring(0, 1);
                    tamKisim = Convert.ToInt32(tamSayi);

                    switch ((tamKisim))
                    {
                        case 9: birlerTam = ("Dokuz "); break;
                        case 8: birlerTam = ("Sekiz "); break;
                        case 7: birlerTam = ("Yedi "); break;
                        case 6: birlerTam = ("Altı "); break;
                        case 5: birlerTam = ("Beş "); break;
                        case 4: birlerTam = ("Dört "); break;
                        case 3: birlerTam = ("Üç "); break;
                        case 2: birlerTam = ("İki "); break;
                        case 1: birlerTam = ("Bir "); break;
                    }

                    switch ((kesirKısım2 / 10))
                    {
                        case 9: onbinlerTam = ("Doksan "); break;
                        case 8: onbinlerTam = ("Seksen "); break;
                        case 7: onbinlerTam = ("Yetmiş "); break;
                        case 6: onbinlerTam = ("Altmış "); break;
                        case 5: onbinlerTam = ("Elli "); break;
                        case 4: onbinlerTam = ("Kırk "); break;
                        case 3: onbinlerTam = ("Otuz "); break;
                        case 2: onbinlerTam = ("Yirmi "); break;
                        case 1: onbinlerTam = ("On "); break;
                    }
                    switch ((kesirKısım2 % 10))
                    {
                        case 9: binlerTam = ("Dokuz "); break;
                        case 8: binlerTam = ("Sekiz "); break;
                        case 7: binlerTam = ("Yedi "); break;
                        case 6: binlerTam = ("Altı "); break;
                        case 5: binlerTam = ("Beş "); break;
                        case 4: binlerTam = ("Dört "); break;
                        case 3: binlerTam = ("Üç "); break;
                        case 2: binlerTam = ("İki "); break;
                        case 1: binlerTam = ("Bir "); break;
                    }
                    if (kesirKısım2 == 0)
                    {
                        sifir = "Sıfır";
                    }
                    kesirKısım = para.Substring(2);
                    kesirKısım2 = Convert.ToInt32(kesirKısım);

                    switch ((kesirKısım2 % 1000) / 100)
                    {
                        case 9: yüzler = ("Dokuz Yüz "); break;
                        case 8: yüzler = ("Sekiz Yüz "); break;
                        case 7: yüzler = ("Yedi Yüz "); break;
                        case 6: yüzler = ("Altı Yüz "); break;
                        case 5: yüzler = ("Beş Yüz "); break;
                        case 4: yüzler = ("Dört Yüz "); break;
                        case 3: yüzler = ("Üç Yüz "); break;
                        case 2: yüzler = ("İki Yüz "); break;
                        case 1: yüzler = ("Yüz "); break;
                    }
                    switch ((kesirKısım2 % 100) / 10)
                    {
                        case 9: onlar = ("Doksan "); break;
                        case 8: onlar = ("Seksen "); break;
                        case 7: onlar = ("Yetmiş "); break;
                        case 6: onlar = ("Altmış "); break;
                        case 5: onlar = ("Elli "); break;
                        case 4: onlar = ("Kırk "); break;
                        case 3: onlar = ("Otuz "); break;
                        case 2: onlar = ("Yirmi "); break;
                        case 1: onlar = ("On "); break;
                    }
                    switch ((kesirKısım2 % 10))
                    {
                        case 9: birler = ("Dokuz "); break;
                        case 8: birler = ("Sekiz "); break;
                        case 7: birler = ("Yedi "); break;
                        case 6: birler = ("Altı "); break;
                        case 5: birler = ("Beş "); break;
                        case 4: birler = ("Dört "); break;
                        case 3: birler = ("Üç "); break;
                        case 2: birler = ("İki "); break;
                        case 1: birler = ("Bir "); break;
                    }

                    lblYazi.Text = birlerTam + " TL" + onbinlerTam + binlerTam + sifir + "Bin " + yüzler + onlar + birler + " Kuruş";
                    this.Controls.Add(lblYazi);

                }
                else
                {
                    switch (kesirKısım2 / 1000)
                    {
                        case 9: kesirBinler = ("Dokuz Bin "); break;
                        case 8: kesirBinler = ("Sekiz Bin "); break;
                        case 7: kesirBinler = ("Yedi Bin "); break;
                        case 6: kesirBinler = ("Altı Bin "); break;
                        case 5: kesirBinler = ("Beş Bin "); break;
                        case 4: kesirBinler = ("Dört Bin "); break;
                        case 3: kesirBinler = ("Üç Bin "); break;
                        case 2: kesirBinler = ("İki Bin "); break;
                        case 1: kesirBinler = ("Bin "); break;
                    }
                    switch ((kesirKısım2 % 1000) / 100)
                    {
                        case 9: kesirYüzler = ("Dokuz Yüz "); break;
                        case 8: kesirYüzler = ("Sekiz Yüz "); break;
                        case 7: kesirYüzler = ("Yedi Yüz "); break;
                        case 6: kesirYüzler = ("Altı Yüz "); break;
                        case 5: kesirYüzler = ("Beş Yüz "); break;
                        case 4: kesirYüzler = ("Dört Yüz "); break;
                        case 3: kesirYüzler = ("Üç Yüz "); break;
                        case 2: kesirYüzler = ("İki Yüz "); break;
                        case 1: kesirYüzler = ("Yüz "); break;
                    }
                    switch ((kesirKısım2 % 100) / 10)
                    {
                        case 9: kesirOnlar = ("Doksan "); break;
                        case 8: kesirOnlar = ("Seksen "); break;
                        case 7: kesirOnlar = ("Yetmiş "); break;
                        case 6: kesirOnlar = ("Altmış "); break;
                        case 5: kesirOnlar = ("Elli "); break;
                        case 4: kesirOnlar = ("Kırk "); break;
                        case 3: kesirOnlar = ("Otuz "); break;
                        case 2: kesirOnlar = ("Yirmi "); break;
                        case 1: kesirOnlar = ("On "); break;
                    }
                    switch ((kesirKısım2 % 10))
                    {
                        case 9: kesirBirler = ("Dokuz "); break;
                        case 8: kesirBirler = ("Sekiz "); break;
                        case 7: kesirBirler = ("Yedi "); break;
                        case 6: kesirBirler = ("Altı "); break;
                        case 5: kesirBirler = ("Beş "); break;
                        case 4: kesirBirler = ("Dört "); break;
                        case 3: kesirBirler = ("Üç "); break;
                        case 2: kesirBirler = ("İki "); break;
                        case 1: kesirBirler = ("Bir "); break;
                    }
                    if (kesirKısım2 == 0)
                    {
                        kesirSifir = "Sıfır";
                    }
                    lblYazi.Text = onbinler + binler + yüzler + onlar + birler + sifir + " TL " + kesirBinler + kesirYüzler + kesirOnlar + kesirBirler + kesirSifir + " Kuruş ";
                    this.Controls.Add(lblYazi);
                }



            }

        }

    }
}
