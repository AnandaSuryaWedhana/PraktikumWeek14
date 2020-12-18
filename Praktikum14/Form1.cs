using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum14
{
    public partial class Praktikum : Form
    {
        public Praktikum()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void reversebutton_Click(object sender, EventArgs e)
        {
            if (Masukkan.Text == "")
            {
                MessageBox.Show("Tolong Isi textbox terlebih dahulu");
            }
            
            char[] pecahan = Masukkan.Text.ToCharArray();
            Array.Reverse(pecahan);
            hasil.Text = string.Concat(pecahan);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Urutkan_Click(object sender, EventArgs e)
        {
            if (Masukkan.Text == "")
            {
                MessageBox.Show("Tolong Isi Textbox terlebih dahulu");
            }

            char [] mecah = Masukkan.Text.ToCharArray();
            Array.Sort(mecah);
            hasil.Text = string.Concat(mecah);
        }
    }
}
