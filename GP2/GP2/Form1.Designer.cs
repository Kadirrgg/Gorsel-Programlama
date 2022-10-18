namespace GP2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.genelİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelBilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danışmanBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınavTakvimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersProgramıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stajBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harçBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelDuyurularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersVeDönemİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersEkleBırakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dönemOrtalamalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diğerBelgelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelenMesajlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gönderilenMesajlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDEğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epostaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(32, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 129);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ogrenci Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 194);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(537, 108);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notlar :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genelİşlemlerToolStripMenuItem,
            this.dersVeDönemİşlemleriToolStripMenuItem,
            this.kullanıcıİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(581, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // genelİşlemlerToolStripMenuItem
            // 
            this.genelİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genelBilgiToolStripMenuItem,
            this.danışmanBilgisiToolStripMenuItem,
            this.sınavTakvimiToolStripMenuItem,
            this.dersProgramıToolStripMenuItem,
            this.stajBilgileriToolStripMenuItem,
            this.harçBilgileriToolStripMenuItem,
            this.genelDuyurularToolStripMenuItem});
            this.genelİşlemlerToolStripMenuItem.Name = "genelİşlemlerToolStripMenuItem";
            this.genelİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.genelİşlemlerToolStripMenuItem.Text = "Genel İşlemler";
            this.genelİşlemlerToolStripMenuItem.Click += new System.EventHandler(this.genelİşlemlerToolStripMenuItem_Click);
            // 
            // genelBilgiToolStripMenuItem
            // 
            this.genelBilgiToolStripMenuItem.Name = "genelBilgiToolStripMenuItem";
            this.genelBilgiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.genelBilgiToolStripMenuItem.Text = "Genel Bilgi";
            // 
            // danışmanBilgisiToolStripMenuItem
            // 
            this.danışmanBilgisiToolStripMenuItem.Name = "danışmanBilgisiToolStripMenuItem";
            this.danışmanBilgisiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.danışmanBilgisiToolStripMenuItem.Text = "Danışman Bilgisi";
            this.danışmanBilgisiToolStripMenuItem.Click += new System.EventHandler(this.danışmanBilgisiToolStripMenuItem_Click);
            // 
            // sınavTakvimiToolStripMenuItem
            // 
            this.sınavTakvimiToolStripMenuItem.Name = "sınavTakvimiToolStripMenuItem";
            this.sınavTakvimiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sınavTakvimiToolStripMenuItem.Text = "Sınav Takvimi";
            // 
            // dersProgramıToolStripMenuItem
            // 
            this.dersProgramıToolStripMenuItem.Name = "dersProgramıToolStripMenuItem";
            this.dersProgramıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dersProgramıToolStripMenuItem.Text = "Ders Programı ";
            // 
            // stajBilgileriToolStripMenuItem
            // 
            this.stajBilgileriToolStripMenuItem.Name = "stajBilgileriToolStripMenuItem";
            this.stajBilgileriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stajBilgileriToolStripMenuItem.Text = "Staj Bilgileri ";
            // 
            // harçBilgileriToolStripMenuItem
            // 
            this.harçBilgileriToolStripMenuItem.Name = "harçBilgileriToolStripMenuItem";
            this.harçBilgileriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.harçBilgileriToolStripMenuItem.Text = "Harç Bilgileri";
            // 
            // genelDuyurularToolStripMenuItem
            // 
            this.genelDuyurularToolStripMenuItem.Name = "genelDuyurularToolStripMenuItem";
            this.genelDuyurularToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.genelDuyurularToolStripMenuItem.Text = "Genel Duyurular";
            // 
            // dersVeDönemİşlemleriToolStripMenuItem
            // 
            this.dersVeDönemİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersKayıtToolStripMenuItem,
            this.dersEkleBırakToolStripMenuItem,
            this.notBilgisiToolStripMenuItem,
            this.dönemOrtalamalarıToolStripMenuItem,
            this.diğerBelgelerToolStripMenuItem});
            this.dersVeDönemİşlemleriToolStripMenuItem.Name = "dersVeDönemİşlemleriToolStripMenuItem";
            this.dersVeDönemİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.dersVeDönemİşlemleriToolStripMenuItem.Text = "Ders Ve Dönem İşlemleri";
            // 
            // dersKayıtToolStripMenuItem
            // 
            this.dersKayıtToolStripMenuItem.Name = "dersKayıtToolStripMenuItem";
            this.dersKayıtToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.dersKayıtToolStripMenuItem.Text = "Ders Kayıt";
            // 
            // dersEkleBırakToolStripMenuItem
            // 
            this.dersEkleBırakToolStripMenuItem.Name = "dersEkleBırakToolStripMenuItem";
            this.dersEkleBırakToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.dersEkleBırakToolStripMenuItem.Text = "Ders Ekle/Bırak";
            // 
            // notBilgisiToolStripMenuItem
            // 
            this.notBilgisiToolStripMenuItem.Name = "notBilgisiToolStripMenuItem";
            this.notBilgisiToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.notBilgisiToolStripMenuItem.Text = "Not Bilgisi";
            // 
            // dönemOrtalamalarıToolStripMenuItem
            // 
            this.dönemOrtalamalarıToolStripMenuItem.Name = "dönemOrtalamalarıToolStripMenuItem";
            this.dönemOrtalamalarıToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.dönemOrtalamalarıToolStripMenuItem.Text = "Dönem Ortalamaları";
            // 
            // diğerBelgelerToolStripMenuItem
            // 
            this.diğerBelgelerToolStripMenuItem.Name = "diğerBelgelerToolStripMenuItem";
            this.diğerBelgelerToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.diğerBelgelerToolStripMenuItem.Text = "Diğer Belgeler";
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelenMesajlarToolStripMenuItem,
            this.gönderilenMesajlarToolStripMenuItem,
            this.şifreDEğiştirToolStripMenuItem,
            this.epostaİşlemleriToolStripMenuItem});
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // gelenMesajlarToolStripMenuItem
            // 
            this.gelenMesajlarToolStripMenuItem.Name = "gelenMesajlarToolStripMenuItem";
            this.gelenMesajlarToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.gelenMesajlarToolStripMenuItem.Text = "Gelen Mesajlar";
            // 
            // gönderilenMesajlarToolStripMenuItem
            // 
            this.gönderilenMesajlarToolStripMenuItem.Name = "gönderilenMesajlarToolStripMenuItem";
            this.gönderilenMesajlarToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.gönderilenMesajlarToolStripMenuItem.Text = "Gönderilen Mesajlar";
            // 
            // şifreDEğiştirToolStripMenuItem
            // 
            this.şifreDEğiştirToolStripMenuItem.Name = "şifreDEğiştirToolStripMenuItem";
            this.şifreDEğiştirToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.şifreDEğiştirToolStripMenuItem.Text = "Şifre Değiştir";
            // 
            // epostaİşlemleriToolStripMenuItem
            // 
            this.epostaİşlemleriToolStripMenuItem.Name = "epostaİşlemleriToolStripMenuItem";
            this.epostaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.epostaİşlemleriToolStripMenuItem.Text = "E-posta İşlemleri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "OBS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem genelİşlemlerToolStripMenuItem;
        private ToolStripMenuItem genelBilgiToolStripMenuItem;
        private ToolStripMenuItem danışmanBilgisiToolStripMenuItem;
        private ToolStripMenuItem sınavTakvimiToolStripMenuItem;
        private ToolStripMenuItem dersProgramıToolStripMenuItem;
        private ToolStripMenuItem stajBilgileriToolStripMenuItem;
        private ToolStripMenuItem harçBilgileriToolStripMenuItem;
        private ToolStripMenuItem dersVeDönemİşlemleriToolStripMenuItem;
        private ToolStripMenuItem dersKayıtToolStripMenuItem;
        private ToolStripMenuItem dersEkleBırakToolStripMenuItem;
        private ToolStripMenuItem notBilgisiToolStripMenuItem;
        private ToolStripMenuItem dönemOrtalamalarıToolStripMenuItem;
        private ToolStripMenuItem diğerBelgelerToolStripMenuItem;
        private ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private ToolStripMenuItem gelenMesajlarToolStripMenuItem;
        private ToolStripMenuItem gönderilenMesajlarToolStripMenuItem;
        private ToolStripMenuItem şifreDEğiştirToolStripMenuItem;
        private ToolStripMenuItem epostaİşlemleriToolStripMenuItem;
        private ToolStripMenuItem genelDuyurularToolStripMenuItem;
    }
}