using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace spacewar2
{
    public partial class Form2 : Form
    {
        private System.Windows.Forms.Timer hareket;
        private const int hız = 10;
        private bool yukarıHareket, aşağıHareket, solaHareket, sağaHareket;

        private List<PictureBox> mermiler; // Birden fazla mermi için liste

        public Form2()
        {
            InitializeComponent();
            hareket = new System.Windows.Forms.Timer();
            hareket.Interval = 10;
            hareket.Tick += HareketZamanlayıcı_Tick;
            this.KeyPreview = true;
            this.KeyDown += Form2_TusBasildi;
            this.KeyUp += Form2_TusBirakildi;

            mermiler = new List<PictureBox>(); // Mermiler listesini başlat
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Oyuncu aracını pencerenin sol tarafının ortasına yerleştir
            oyuncuaracı.Location = new Point(
                10, // Sol kenardan 10 piksel uzaklıkta
                this.ClientSize.Height / 2 - oyuncuaracı.Height / 2
            );
            hareket.Start();

            // Fare olayını ekle
            this.MouseDown += Form2_MouseDown;
        }

        private void HareketZamanlayıcı_Tick(object sender, EventArgs e)
        {
            int x = oyuncuaracı.Location.X;
            int y = oyuncuaracı.Location.Y;

            if (yukarıHareket)
                y = Math.Max(0, y - hız);
            if (aşağıHareket)
                y = Math.Min(this.ClientSize.Height - oyuncuaracı.Height, y + hız);
            if (solaHareket)
                x = Math.Max(0, x - hız);
            if (sağaHareket)
                x = Math.Min(this.ClientSize.Width - oyuncuaracı.Width, x + hız);

            oyuncuaracı.Location = new Point(x, y);

            // Mermileri hareket ettir
            for (int i = mermiler.Count - 1; i >= 0; i--)
            {
                var mermi = mermiler[i];
                mermi.Left += 10; // Mermiyi sağa doğru hareket ettir

                if (mermi.Left > this.ClientSize.Width) // Ekrandan çıktıysa
                {
                    this.Controls.Remove(mermi); // Formdan kaldır
                    mermiler.RemoveAt(i);       // Listeden kaldır
                }
            }
        }

        private void Form2_TusBasildi(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    yukarıHareket = true;
                    break;
                case Keys.S:
                    aşağıHareket = true;
                    break;
                case Keys.A:
                    solaHareket = true;
                    break;
                case Keys.D:
                    sağaHareket = true;
                    break;
            }
        }

        private void Form2_TusBirakildi(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    yukarıHareket = false;
                    break;
                case Keys.S:
                    aşağıHareket = false;
                    break;
                case Keys.A:
                    solaHareket = false;
                    break;
                case Keys.D:
                    sağaHareket = false;
                    break;
            }
        }

        private void AteşEt()
        {
            // Yeni bir mermi oluştur
            PictureBox mermi = new PictureBox();
            mermi.Size = new Size(10, 5); // Mermi boyutu
            mermi.BackColor = Color.Red; // Mermi rengi
            mermi.Left = oyuncuaracı.Right; // Mermiyi oyuncu aracının sağ kenarına yerleştir
            mermi.Top = oyuncuaracı.Top + (oyuncuaracı.Height / 2) - (mermi.Height / 2); // Mermiyi oyuncu aracının ortasına hizala
            this.Controls.Add(mermi);    // Form kontrolüne ekle
            mermiler.Add(mermi);         // Listeye ekle
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            // Sol tıklama kontrolü
            if (e.Button == MouseButtons.Left)
            {
                AteşEt();
            }
        }

        private void Basitdusman_Click(object sender, EventArgs e)
        {

        }
    }
}
