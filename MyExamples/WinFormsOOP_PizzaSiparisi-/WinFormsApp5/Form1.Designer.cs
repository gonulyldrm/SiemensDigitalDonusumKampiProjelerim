namespace WinFormsApp5
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.cmbPizzaboy = new System.Windows.Forms.ComboBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.cmbIcecek = new System.Windows.Forms.ComboBox();
            this.txtPizzaboyAdet = new System.Windows.Forms.TextBox();
            this.txtIcecekAdet = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lsbAdSoyad = new System.Windows.Forms.ListBox();
            this.lsbTelefon = new System.Windows.Forms.ListBox();
            this.lsbAdres = new System.Windows.Forms.ListBox();
            this.lsbPizzaboyAdet = new System.Windows.Forms.ListBox();
            this.lsbIcecekAdet = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lsbUcret = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(143, 17);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(186, 27);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(143, 66);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(186, 27);
            this.txtTelefon.TabIndex = 1;
            // 
            // cmbPizzaboy
            // 
            this.cmbPizzaboy.FormattingEnabled = true;
            this.cmbPizzaboy.Items.AddRange(new object[] {
            "orta",
            "buyuk",
            "kucuk"});
            this.cmbPizzaboy.Location = new System.Drawing.Point(143, 118);
            this.cmbPizzaboy.Name = "cmbPizzaboy";
            this.cmbPizzaboy.Size = new System.Drawing.Size(186, 28);
            this.cmbPizzaboy.TabIndex = 2;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(410, 23);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(172, 81);
            this.txtAdres.TabIndex = 3;
            // 
            // cmbIcecek
            // 
            this.cmbIcecek.FormattingEnabled = true;
            this.cmbIcecek.Items.AddRange(new object[] {
            "kola",
            "fanta"});
            this.cmbIcecek.Location = new System.Drawing.Point(143, 168);
            this.cmbIcecek.Name = "cmbIcecek";
            this.cmbIcecek.Size = new System.Drawing.Size(186, 28);
            this.cmbIcecek.TabIndex = 4;
            // 
            // txtPizzaboyAdet
            // 
            this.txtPizzaboyAdet.Location = new System.Drawing.Point(440, 128);
            this.txtPizzaboyAdet.Name = "txtPizzaboyAdet";
            this.txtPizzaboyAdet.Size = new System.Drawing.Size(66, 27);
            this.txtPizzaboyAdet.TabIndex = 5;
            // 
            // txtIcecekAdet
            // 
            this.txtIcecekAdet.Location = new System.Drawing.Point(440, 174);
            this.txtIcecekAdet.Name = "txtIcecekAdet";
            this.txtIcecekAdet.Size = new System.Drawing.Size(66, 27);
            this.txtIcecekAdet.TabIndex = 6;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(667, 176);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(94, 29);
            this.Button1.TabIndex = 11;
            this.Button1.Text = "Sipariş Ver";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lsbAdSoyad
            // 
            this.lsbAdSoyad.FormattingEnabled = true;
            this.lsbAdSoyad.ItemHeight = 20;
            this.lsbAdSoyad.Location = new System.Drawing.Point(12, 315);
            this.lsbAdSoyad.Name = "lsbAdSoyad";
            this.lsbAdSoyad.Size = new System.Drawing.Size(98, 104);
            this.lsbAdSoyad.TabIndex = 13;
            // 
            // lsbTelefon
            // 
            this.lsbTelefon.FormattingEnabled = true;
            this.lsbTelefon.ItemHeight = 20;
            this.lsbTelefon.Location = new System.Drawing.Point(116, 315);
            this.lsbTelefon.Name = "lsbTelefon";
            this.lsbTelefon.Size = new System.Drawing.Size(126, 104);
            this.lsbTelefon.TabIndex = 14;
            // 
            // lsbAdres
            // 
            this.lsbAdres.FormattingEnabled = true;
            this.lsbAdres.ItemHeight = 20;
            this.lsbAdres.Location = new System.Drawing.Point(248, 315);
            this.lsbAdres.Name = "lsbAdres";
            this.lsbAdres.Size = new System.Drawing.Size(81, 104);
            this.lsbAdres.TabIndex = 15;
            // 
            // lsbPizzaboyAdet
            // 
            this.lsbPizzaboyAdet.FormattingEnabled = true;
            this.lsbPizzaboyAdet.ItemHeight = 20;
            this.lsbPizzaboyAdet.Location = new System.Drawing.Point(339, 315);
            this.lsbPizzaboyAdet.Name = "lsbPizzaboyAdet";
            this.lsbPizzaboyAdet.Size = new System.Drawing.Size(118, 104);
            this.lsbPizzaboyAdet.TabIndex = 16;
            // 
            // lsbIcecekAdet
            // 
            this.lsbIcecekAdet.FormattingEnabled = true;
            this.lsbIcecekAdet.ItemHeight = 20;
            this.lsbIcecekAdet.Location = new System.Drawing.Point(588, 315);
            this.lsbIcecekAdet.Name = "lsbIcecekAdet";
            this.lsbIcecekAdet.Size = new System.Drawing.Size(113, 104);
            this.lsbIcecekAdet.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "adSoyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "pizza boy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "içeçek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "adet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "adet";
            // 
            // lsbUcret
            // 
            this.lsbUcret.FormattingEnabled = true;
            this.lsbUcret.ItemHeight = 20;
            this.lsbUcret.Location = new System.Drawing.Point(710, 315);
            this.lsbUcret.Name = "lsbUcret";
            this.lsbUcret.Size = new System.Drawing.Size(71, 104);
            this.lsbUcret.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "adsoyad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "telefon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "adres";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 286);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "pizza boy adet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(583, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "içeçek adet";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(710, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "ücret";
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 20;
            this.listBox7.Location = new System.Drawing.Point(463, 315);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(119, 104);
            this.listBox7.TabIndex = 31;
            this.listBox7.SelectedIndexChanged += new System.EventHandler(this.listBox7_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(481, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "extra";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "sebze ",
            "peynir",
            "mantar",
            "sucuk"});
            this.checkedListBox1.Location = new System.Drawing.Point(631, 26);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(150, 114);
            this.checkedListBox1.TabIndex = 33;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(269, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "klasik pizzamiz 10 tl dir ektraları seciniz";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(359, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "adres";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(339, 241);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 20);
            this.label16.TabIndex = 36;
            this.label16.Text = "label16";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lsbUcret);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbIcecekAdet);
            this.Controls.Add(this.lsbPizzaboyAdet);
            this.Controls.Add(this.lsbAdres);
            this.Controls.Add(this.lsbTelefon);
            this.Controls.Add(this.lsbAdSoyad);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtIcecekAdet);
            this.Controls.Add(this.txtPizzaboyAdet);
            this.Controls.Add(this.cmbIcecek);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.cmbPizzaboy);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdSoyad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAdSoyad;
        private TextBox txtTelefon;
        private ComboBox cmbPizzaboy;
        private TextBox txtAdres;
        private ComboBox cmbIcecek;
        private TextBox txtPizzaboyAdet;
        private TextBox txtIcecekAdet;
        private Button Button1;
        private Button button2;
        private ListBox lsbAdSoyad;
        private ListBox lsbTelefon;
        private ListBox lsbAdres;
        private ListBox lsbPizzaboyAdet;
        private ListBox lsbIcecekAdet;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox lsbUcret;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ListBox listBox7;
        private Label label13;
        private CheckedListBox checkedListBox1;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}