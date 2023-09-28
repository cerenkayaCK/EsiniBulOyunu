namespace EsiniBulOyunu
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        int boyut = 6; //sat�r ve s�tun say�s�
        List<string> resimler = new List<string>();
        List<string> kartlar = new List<string>();
        List<PictureBox> aciklar = new List<PictureBox>();
        int yokEdilenAdet = 0;
        public Form1()
        {

            ResimleriYukle();
            InitializeComponent(); // bu ��elerin �zelliklerini (�rne�in, konumlar�, boyutlar�, metin i�erikleri vb.) ba�latan ve ayarlayan bir otomatik �retim metodur.


        }

        private void KartlariSec()
        {
            int ciftAdet = boyut * boyut / 2;
            while (kartlar.Count < ciftAdet)
            {
                string resim = resimler[rnd.Next(resimler.Count)];
                if (!kartlar.Contains(resim))
                    kartlar.Add(resim);
            }
            kartlar.AddRange(kartlar); //AddRange() bir koleksiyonu di�er bir koleksiyona eklemek istedi�inizde kullan�l�r.
            KartlarKaristir();
            //kari�tir.
        }

        private void KartlarKaristir() //yer de�i�tir.
        {
            string yedek;
            int talihliIndeks;
            for (int i = 0; i < kartlar.Count - 1; i++)
            {
                talihliIndeks = rnd.Next(i, kartlar.Count);
                yedek = kartlar[i];
                kartlar[i] = kartlar[talihliIndeks];
                kartlar[talihliIndeks] = yedek;
            }
        }



        private void ResimleriYukle()
        {
            DirectoryInfo klasor = new DirectoryInfo("image"); // Burada DirectoryInfo s�n�f�n� kullanarak klas�rlerin olu�turulmas�, i�eriklerinin listelenmesi ve di�er i�lemler ger�ekle�tirilmektedir
            FileInfo[] dosyalar = klasor.GetFiles();

            foreach (FileInfo item in dosyalar)
                resimler.Add(item.Name);
        }


        private void KartlariDiz()
        {
            int bosluk = 10;
            int gen = ((pnlKartlar.Width - (boyut - 1) * bosluk)) / boyut;
            int yuk = ((pnlKartlar.Height - (boyut - 1) * bosluk)) / boyut;
            int i = 0;

            for (int y = 0; y < boyut; y++)

            {

                for (int x = 0; x < boyut; x++)

                {

                    PictureBox resimKutusu = new PictureBox();
                    resimKutusu.Tag = i;
                    resimKutusu.BackColor = Color.Bisque;
                    resimKutusu.Size = new Size(gen, yuk);
                    resimKutusu.Left = x * (resimKutusu.Width + bosluk);
                    resimKutusu.Top = y * (resimKutusu.Height + bosluk);
                    resimKutusu.ImageLocation = "back.jpg";
                    resimKutusu.SizeMode = PictureBoxSizeMode.Zoom;
                    resimKutusu.Click += ResimKutusu_Click;
                    pnlKartlar.Controls.Add(resimKutusu);

                    i++;

                }

            }




        }
        //sender t�klanan resim kutsuunu ta��r
        private void ResimKutusu_Click(object? sender, EventArgs e)
        {
            //�nceden a��lanlar�n kapanmas�
            if (aciklar.Count == 2)
            {

                AciklarKapat();
            }
            PictureBox tiklanan = (PictureBox)sender;
            // e�er ayn� karta ikinci defa t�klandysa bir �ey yapmadan ��k
            if (aciklar.Count == 1 && aciklar[0] == tiklanan)
                return;

            int kartIndeks = (int)tiklanan.Tag;
            string resim = kartlar[kartIndeks];
            tiklanan.ImageLocation = "image\\" + resim;
            aciklar.Add(tiklanan);
            //2.Kart� a�t���nda yap�lacak e�le�me kontrol�
            if (aciklar.Count == 2 && aciklar[0].ImageLocation == aciklar[1].ImageLocation)
            {
                Application.DoEvents(); //2 resmi ayn� anda g�strip sonra yok ediyor : aray�z�n yenilenmesini sa�layarak gecikmeli yok et. 
                AciklariGecikmeliYokEt();
                AciklarKapat();
                //oyun bitti mi ?
                if (yokEdilenAdet == kartlar.Count)
                {
                    MessageBox.Show("Oyun Bitti!");
                    OyunuSifirla();
                }
            }


        }

        private void OyunuSifirla()
        {
            pnlKartlar.Controls.Clear();
            yokEdilenAdet = 0;
            kartlar.Clear();
            aciklar.Clear();
            gboYeniOyun.Show();
            pnlKartlar.BackColor = Color.Transparent;
        }




        private void AciklarKapat()
        {
            foreach (PictureBox kutu in aciklar)
            {
                kutu.ImageLocation = "back.jpg";
            }
            aciklar.Clear();

        }

        private void AciklariGecikmeliYokEt()
        {
            Thread.Sleep(500);

            foreach (PictureBox kutu in aciklar)
            {
                pnlKartlar.Controls.Remove(kutu);
                yokEdilenAdet++;
            }

        }

        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            OyunuBaslat();
        }

        private void OyunuBaslat()
        {
            pnlKartlar.BackColor = Color.WhiteSmoke;
            SeviyeyeKararVer();
            gboYeniOyun.Hide();
            KartlariSec();
            KartlariDiz();


        }

        private void SeviyeyeKararVer()
        {
            if (rb1.Checked) boyut = 2;
            else if (rb2.Checked) boyut = 4;
            else if (rb3.Checked) boyut = 6;
            else if (rb4.Checked) boyut = 8;
            else boyut = 10;
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {

            OyunuSifirla();
        }
    }
}