using System;
using System.Windows.Forms;

namespace spacewar2
{
    public partial class Form1 : Form
    {
        public string playername { get; set; }



        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void startgamebutton_Click(object sender, EventArgs e)
        {
            playername = textBox1.Text;



            if (string.IsNullOrWhiteSpace(playername))
            {
                MessageBox.Show("Lütfen bir isim giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            Form2 form2 = new Form2();
            form2.Show();




        }

       
    }
}
