using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ogrencieklemeekrani = new Form2(this);
            ogrencieklemeekrani.Show();
            this.Hide();
            
            

        }

        private void dan��manBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bos   
        }

        private void genel��lemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hata L�tfen sonra Tekrar Deneyiniz.");
        }
    }
}