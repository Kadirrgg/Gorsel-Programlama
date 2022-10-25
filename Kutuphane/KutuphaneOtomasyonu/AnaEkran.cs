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

namespace KutuphaneOtomasyonu
{
    public partial class AnaEkran : Form
    {
        
        public AnaEkran()
        {
            InitializeComponent();
            
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEklemeEkrani kitapEklemeEkrani = new KitapEklemeEkrani(this);
            kitapEklemeEkrani.Show();
            this.Hide();
        }

        public void kitapEkle(string kitapAdi)
        {
            listBox1.Items.Add(kitapAdi);
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {//düzenle
            KitapEklemeEkrani duzenle = new KitapEklemeEkrani(this);
            duzenle.Show();
            int index = listBox1.SelectedIndex;
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Items.Insert(index, duzenle);


        }

        private void button2_Click(object sender, EventArgs e)
        {//silme tusu
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
