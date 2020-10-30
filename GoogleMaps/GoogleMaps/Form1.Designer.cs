namespace GoogleMaps
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_moja_pozicija = new System.Windows.Forms.Label();
            this.textbox_moja_pozicija_x = new System.Windows.Forms.TextBox();
            this.textbox_moja_pozicija_y = new System.Windows.Forms.TextBox();
            this.label_final_pozicija = new System.Windows.Forms.Label();
            this.textbox_final_pozicija_y = new System.Windows.Forms.TextBox();
            this.textbox_final_pozicija_x = new System.Windows.Forms.TextBox();
            this.button_putanja = new System.Windows.Forms.Button();
            this.label_dodaj_cvor = new System.Windows.Forms.Label();
            this.textbox_dodaj_koordinata_y = new System.Windows.Forms.TextBox();
            this.textbox_dodaj_koordinata_x = new System.Windows.Forms.TextBox();
            this.button_dodaj_cvor_koordinate = new System.Windows.Forms.Button();
            this.textbox_dodaj_cvor1 = new System.Windows.Forms.TextBox();
            this.textbox_dodaj_cvor2 = new System.Windows.Forms.TextBox();
            this.textbox_dodaj_udaljenost2 = new System.Windows.Forms.TextBox();
            this.textbox_dodaj_udaljenost1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.listBox_karakteristike = new System.Windows.Forms.ListBox();
            this.radioButton_mojaPoz = new System.Windows.Forms.RadioButton();
            this.radioButton_finalPoz = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox_posao = new System.Windows.Forms.ListBox();
            this.checkBox_dvosmjerna = new System.Windows.Forms.CheckBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_iscrtaj_sve_karakteristike = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label_moja_pozicija
            // 
            this.label_moja_pozicija.AutoSize = true;
            this.label_moja_pozicija.Location = new System.Drawing.Point(13, 13);
            this.label_moja_pozicija.Name = "label_moja_pozicija";
            this.label_moja_pozicija.Size = new System.Drawing.Size(69, 13);
            this.label_moja_pozicija.TabIndex = 0;
            this.label_moja_pozicija.Text = "Moja Pozicija";
            // 
            // textbox_moja_pozicija_x
            // 
            this.textbox_moja_pozicija_x.Location = new System.Drawing.Point(99, 6);
            this.textbox_moja_pozicija_x.Name = "textbox_moja_pozicija_x";
            this.textbox_moja_pozicija_x.Size = new System.Drawing.Size(49, 20);
            this.textbox_moja_pozicija_x.TabIndex = 1;
            // 
            // textbox_moja_pozicija_y
            // 
            this.textbox_moja_pozicija_y.Location = new System.Drawing.Point(154, 6);
            this.textbox_moja_pozicija_y.Name = "textbox_moja_pozicija_y";
            this.textbox_moja_pozicija_y.Size = new System.Drawing.Size(49, 20);
            this.textbox_moja_pozicija_y.TabIndex = 2;
            // 
            // label_final_pozicija
            // 
            this.label_final_pozicija.AutoSize = true;
            this.label_final_pozicija.Location = new System.Drawing.Point(13, 35);
            this.label_final_pozicija.Name = "label_final_pozicija";
            this.label_final_pozicija.Size = new System.Drawing.Size(80, 13);
            this.label_final_pozicija.TabIndex = 3;
            this.label_final_pozicija.Text = "Finalna Pozicija";
            // 
            // textbox_final_pozicija_y
            // 
            this.textbox_final_pozicija_y.Location = new System.Drawing.Point(154, 32);
            this.textbox_final_pozicija_y.Name = "textbox_final_pozicija_y";
            this.textbox_final_pozicija_y.Size = new System.Drawing.Size(49, 20);
            this.textbox_final_pozicija_y.TabIndex = 5;
            // 
            // textbox_final_pozicija_x
            // 
            this.textbox_final_pozicija_x.Location = new System.Drawing.Point(99, 32);
            this.textbox_final_pozicija_x.Name = "textbox_final_pozicija_x";
            this.textbox_final_pozicija_x.Size = new System.Drawing.Size(49, 20);
            this.textbox_final_pozicija_x.TabIndex = 4;
            // 
            // button_putanja
            // 
            this.button_putanja.Location = new System.Drawing.Point(17, 80);
            this.button_putanja.Name = "button_putanja";
            this.button_putanja.Size = new System.Drawing.Size(75, 23);
            this.button_putanja.TabIndex = 6;
            this.button_putanja.Text = "Traži put";
            this.button_putanja.UseVisualStyleBackColor = true;
            this.button_putanja.Click += new System.EventHandler(this.button_putanja_Click);
            // 
            // label_dodaj_cvor
            // 
            this.label_dodaj_cvor.AutoSize = true;
            this.label_dodaj_cvor.Location = new System.Drawing.Point(13, 187);
            this.label_dodaj_cvor.Name = "label_dodaj_cvor";
            this.label_dodaj_cvor.Size = new System.Drawing.Size(59, 13);
            this.label_dodaj_cvor.TabIndex = 7;
            this.label_dodaj_cvor.Text = "Dodaj čvor";
            this.label_dodaj_cvor.Click += new System.EventHandler(this.label_dodaj_cvor_Click);
            // 
            // textbox_dodaj_koordinata_y
            // 
            this.textbox_dodaj_koordinata_y.Location = new System.Drawing.Point(154, 184);
            this.textbox_dodaj_koordinata_y.Name = "textbox_dodaj_koordinata_y";
            this.textbox_dodaj_koordinata_y.Size = new System.Drawing.Size(49, 20);
            this.textbox_dodaj_koordinata_y.TabIndex = 9;
            this.textbox_dodaj_koordinata_y.TextChanged += new System.EventHandler(this.textbox_dodaj_koordinata_y_TextChanged);
            // 
            // textbox_dodaj_koordinata_x
            // 
            this.textbox_dodaj_koordinata_x.Location = new System.Drawing.Point(99, 184);
            this.textbox_dodaj_koordinata_x.Name = "textbox_dodaj_koordinata_x";
            this.textbox_dodaj_koordinata_x.Size = new System.Drawing.Size(49, 20);
            this.textbox_dodaj_koordinata_x.TabIndex = 8;
            this.textbox_dodaj_koordinata_x.TextChanged += new System.EventHandler(this.textbox_dodaj_koordinata_x_TextChanged);
            // 
            // button_dodaj_cvor_koordinate
            // 
            this.button_dodaj_cvor_koordinate.Location = new System.Drawing.Point(12, 203);
            this.button_dodaj_cvor_koordinate.Name = "button_dodaj_cvor_koordinate";
            this.button_dodaj_cvor_koordinate.Size = new System.Drawing.Size(75, 23);
            this.button_dodaj_cvor_koordinate.TabIndex = 10;
            this.button_dodaj_cvor_koordinate.Text = "Dodaj";
            this.button_dodaj_cvor_koordinate.UseVisualStyleBackColor = true;
            this.button_dodaj_cvor_koordinate.Click += new System.EventHandler(this.button_dodaj_cvor_koordinate_Click);
            // 
            // textbox_dodaj_cvor1
            // 
            this.textbox_dodaj_cvor1.Location = new System.Drawing.Point(99, 235);
            this.textbox_dodaj_cvor1.Name = "textbox_dodaj_cvor1";
            this.textbox_dodaj_cvor1.Size = new System.Drawing.Size(49, 20);
            this.textbox_dodaj_cvor1.TabIndex = 11;
            // 
            // textbox_dodaj_cvor2
            // 
            this.textbox_dodaj_cvor2.Location = new System.Drawing.Point(221, 235);
            this.textbox_dodaj_cvor2.Name = "textbox_dodaj_cvor2";
            this.textbox_dodaj_cvor2.Size = new System.Drawing.Size(49, 20);
            this.textbox_dodaj_cvor2.TabIndex = 12;
            // 
            // textbox_dodaj_udaljenost2
            // 
            this.textbox_dodaj_udaljenost2.Location = new System.Drawing.Point(221, 261);
            this.textbox_dodaj_udaljenost2.Name = "textbox_dodaj_udaljenost2";
            this.textbox_dodaj_udaljenost2.Size = new System.Drawing.Size(49, 20);
            this.textbox_dodaj_udaljenost2.TabIndex = 14;
            // 
            // textbox_dodaj_udaljenost1
            // 
            this.textbox_dodaj_udaljenost1.Location = new System.Drawing.Point(99, 261);
            this.textbox_dodaj_udaljenost1.Name = "textbox_dodaj_udaljenost1";
            this.textbox_dodaj_udaljenost1.Size = new System.Drawing.Size(49, 20);
            this.textbox_dodaj_udaljenost1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cvor1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Udaljenost2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cvor2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Udaljenost1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tip linije";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(400, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(750, 500);
            this.pictureBox.TabIndex = 30;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // listBox_karakteristike
            // 
            this.listBox_karakteristike.FormattingEnabled = true;
            this.listBox_karakteristike.Items.AddRange(new object[] {
            "Trgovina",
            "Benzinska",
            "Posta",
            "Banka",
            "Tisak",
            "Dvorana",
            "Skola",
            "Fakultet",
            "Kuca",
            "Kolodvor",
            "Trg",
            "Restoran",
            "Pekara",
            "Slasticarna",
            "Disko",
            "CaffeBar",
            "Lunapark",
            "Zooloski",
            "Vrtic",
            "Igraonica",
            "ShoppingCentar",
            "Kino",
            "Knjiznica",
            "Teretana",
            "Jezero",
            "Rijeka",
            "Suma",
            "Park"});
            this.listBox_karakteristike.Location = new System.Drawing.Point(276, 184);
            this.listBox_karakteristike.Name = "listBox_karakteristike";
            this.listBox_karakteristike.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_karakteristike.Size = new System.Drawing.Size(103, 160);
            this.listBox_karakteristike.TabIndex = 31;
            this.listBox_karakteristike.SelectedIndexChanged += new System.EventHandler(this.listBox_karakteristike_SelectedIndexChanged);
            // 
            // radioButton_mojaPoz
            // 
            this.radioButton_mojaPoz.AutoSize = true;
            this.radioButton_mojaPoz.Location = new System.Drawing.Point(210, 8);
            this.radioButton_mojaPoz.Name = "radioButton_mojaPoz";
            this.radioButton_mojaPoz.Size = new System.Drawing.Size(126, 17);
            this.radioButton_mojaPoz.TabIndex = 32;
            this.radioButton_mojaPoz.TabStop = true;
            this.radioButton_mojaPoz.Text = "Odaberi moju lokaciju";
            this.radioButton_mojaPoz.UseVisualStyleBackColor = true;
            this.radioButton_mojaPoz.CheckedChanged += new System.EventHandler(this.radioButton_mojaPoz_CheckedChanged);
            // 
            // radioButton_finalPoz
            // 
            this.radioButton_finalPoz.AutoSize = true;
            this.radioButton_finalPoz.Location = new System.Drawing.Point(209, 33);
            this.radioButton_finalPoz.Name = "radioButton_finalPoz";
            this.radioButton_finalPoz.Size = new System.Drawing.Size(150, 17);
            this.radioButton_finalPoz.TabIndex = 33;
            this.radioButton_finalPoz.TabStop = true;
            this.radioButton_finalPoz.Text = "Odaberi odredišnu lokaciju";
            this.radioButton_finalPoz.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Usputni posao(opcionalno)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // listBox_posao
            // 
            this.listBox_posao.FormattingEnabled = true;
            this.listBox_posao.Items.AddRange(new object[] {
            "Trgovina",
            "Benzinska",
            "Posta",
            "Banka",
            "Tisak",
            "Dvorana",
            "Skola",
            "Fakultet",
            "Kuca",
            "Kolodvor",
            "Trg",
            "Restoran",
            "Pekara",
            "Slasticarna",
            "Disko",
            "CaffeBar",
            "Lunapark",
            "Zooloski",
            "Vrtic",
            "Igraonica",
            "ShoppingCentar",
            "Kino",
            "Knjiznica",
            "Teretana",
            "Jezero",
            "Rijeka",
            "Suma",
            "Park"});
            this.listBox_posao.Location = new System.Drawing.Point(154, 60);
            this.listBox_posao.Name = "listBox_posao";
            this.listBox_posao.Size = new System.Drawing.Size(205, 82);
            this.listBox_posao.TabIndex = 35;
            // 
            // checkBox_dvosmjerna
            // 
            this.checkBox_dvosmjerna.AutoSize = true;
            this.checkBox_dvosmjerna.Location = new System.Drawing.Point(76, 327);
            this.checkBox_dvosmjerna.Name = "checkBox_dvosmjerna";
            this.checkBox_dvosmjerna.Size = new System.Drawing.Size(82, 17);
            this.checkBox_dvosmjerna.TabIndex = 36;
            this.checkBox_dvosmjerna.Text = "Dvosmjerna";
            this.checkBox_dvosmjerna.UseVisualStyleBackColor = true;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(15, 350);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 38;
            this.button_Clear.Text = "ClearLines";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_iscrtaj_sve_karakteristike
            // 
            this.button_iscrtaj_sve_karakteristike.Location = new System.Drawing.Point(18, 109);
            this.button_iscrtaj_sve_karakteristike.Name = "button_iscrtaj_sve_karakteristike";
            this.button_iscrtaj_sve_karakteristike.Size = new System.Drawing.Size(75, 23);
            this.button_iscrtaj_sve_karakteristike.TabIndex = 39;
            this.button_iscrtaj_sve_karakteristike.Text = "Iscrtaj sve";
            this.button_iscrtaj_sve_karakteristike.UseVisualStyleBackColor = true;
            this.button_iscrtaj_sve_karakteristike.Click += new System.EventHandler(this.button_iscrtaj_sve_karakteristike_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.button_iscrtaj_sve_karakteristike);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.checkBox_dvosmjerna);
            this.Controls.Add(this.listBox_posao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButton_finalPoz);
            this.Controls.Add(this.radioButton_mojaPoz);
            this.Controls.Add(this.listBox_karakteristike);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_dodaj_udaljenost2);
            this.Controls.Add(this.textbox_dodaj_udaljenost1);
            this.Controls.Add(this.textbox_dodaj_cvor2);
            this.Controls.Add(this.textbox_dodaj_cvor1);
            this.Controls.Add(this.button_dodaj_cvor_koordinate);
            this.Controls.Add(this.textbox_dodaj_koordinata_y);
            this.Controls.Add(this.textbox_dodaj_koordinata_x);
            this.Controls.Add(this.label_dodaj_cvor);
            this.Controls.Add(this.button_putanja);
            this.Controls.Add(this.textbox_final_pozicija_y);
            this.Controls.Add(this.textbox_final_pozicija_x);
            this.Controls.Add(this.label_final_pozicija);
            this.Controls.Add(this.textbox_moja_pozicija_y);
            this.Controls.Add(this.textbox_moja_pozicija_x);
            this.Controls.Add(this.label_moja_pozicija);
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Form1";
            this.Text = "GPS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_moja_pozicija;
        private System.Windows.Forms.TextBox textbox_moja_pozicija_x;
        private System.Windows.Forms.TextBox textbox_moja_pozicija_y;
        private System.Windows.Forms.Label label_final_pozicija;
        private System.Windows.Forms.TextBox textbox_final_pozicija_y;
        private System.Windows.Forms.TextBox textbox_final_pozicija_x;
        private System.Windows.Forms.Button button_putanja;
        private System.Windows.Forms.Label label_dodaj_cvor;
        private System.Windows.Forms.TextBox textbox_dodaj_koordinata_y;
        private System.Windows.Forms.TextBox textbox_dodaj_koordinata_x;
        private System.Windows.Forms.Button button_dodaj_cvor_koordinate;
        private System.Windows.Forms.TextBox textbox_dodaj_cvor1;
        private System.Windows.Forms.TextBox textbox_dodaj_cvor2;
        private System.Windows.Forms.TextBox textbox_dodaj_udaljenost2;
        private System.Windows.Forms.TextBox textbox_dodaj_udaljenost1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListBox listBox_karakteristike;
        private System.Windows.Forms.RadioButton radioButton_mojaPoz;
        private System.Windows.Forms.RadioButton radioButton_finalPoz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox_posao;
        private System.Windows.Forms.CheckBox checkBox_dvosmjerna;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_iscrtaj_sve_karakteristike;
    }
}

