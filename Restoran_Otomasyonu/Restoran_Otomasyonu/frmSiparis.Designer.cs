namespace Restoran_Otomasyonu
{
    partial class frmSiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiparis));
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.btnYemekler = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvMenu = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvSiparisler = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.AutoSize = true;
            this.lblMasaNo.BackColor = System.Drawing.Color.Transparent;
            this.lblMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNo.ForeColor = System.Drawing.Color.Transparent;
            this.lblMasaNo.Location = new System.Drawing.Point(120, 82);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(104, 29);
            this.lblMasaNo.TabIndex = 0;
            this.lblMasaNo.Text = "MASA 1";
            // 
            // btnYemekler
            // 
            this.btnYemekler.BackColor = System.Drawing.Color.White;
            this.btnYemekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYemekler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYemekler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYemekler.ForeColor = System.Drawing.Color.Transparent;
            this.btnYemekler.Image = ((System.Drawing.Image)(resources.GetObject("btnYemekler.Image")));
            this.btnYemekler.Location = new System.Drawing.Point(65, 115);
            this.btnYemekler.Name = "btnYemekler";
            this.btnYemekler.Size = new System.Drawing.Size(119, 74);
            this.btnYemekler.TabIndex = 0;
            this.btnYemekler.Text = "Yemekler";
            this.btnYemekler.UseVisualStyleBackColor = false;
            this.btnYemekler.Click += new System.EventHandler(this.btnYemekler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnYemekler);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(40, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 339);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menü";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lvMenu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(389, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 250);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menü";
            // 
            // lvMenu
            // 
            this.lvMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvMenu.GridLines = true;
            this.lvMenu.HideSelection = false;
            this.lvMenu.Location = new System.Drawing.Point(6, 31);
            this.lvMenu.Name = "lvMenu";
            this.lvMenu.Size = new System.Drawing.Size(400, 203);
            this.lvMenu.TabIndex = 0;
            this.lvMenu.UseCompatibleStateImageBehavior = false;
            this.lvMenu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Fiyatı";
            this.columnHeader2.Width = 141;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün No";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ürün Adı";
            this.columnHeader4.Width = 129;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lvSiparisler);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(389, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 250);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menü";
            // 
            // lvSiparisler
            // 
            this.lvSiparisler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader9});
            this.lvSiparisler.GridLines = true;
            this.lvSiparisler.HideSelection = false;
            this.lvSiparisler.Location = new System.Drawing.Point(6, 32);
            this.lvSiparisler.Name = "lvSiparisler";
            this.lvSiparisler.Size = new System.Drawing.Size(400, 203);
            this.lvSiparisler.TabIndex = 0;
            this.lvSiparisler.UseCompatibleStateImageBehavior = false;
            this.lvSiparisler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ürün Adeti";
            this.columnHeader5.Width = 122;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ürün Adı";
            this.columnHeader6.Width = 129;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ürün Fiyatı";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "UrunId";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SatisId";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "SilinenId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(390, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ürün No";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(520, 0);
            this.txtAra.Multiline = true;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(138, 37);
            this.txtAra.TabIndex = 11;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.LightCoral;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.ForeColor = System.Drawing.Color.Transparent;
            this.btn1.Location = new System.Drawing.Point(888, 114);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(81, 63);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.LightCoral;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.ForeColor = System.Drawing.Color.Transparent;
            this.btn2.Location = new System.Drawing.Point(975, 114);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(81, 63);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.LightCoral;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.ForeColor = System.Drawing.Color.Transparent;
            this.btn3.Location = new System.Drawing.Point(1062, 114);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(81, 63);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.LightCoral;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn6.ForeColor = System.Drawing.Color.Transparent;
            this.btn6.Location = new System.Drawing.Point(1062, 184);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(81, 63);
            this.btn6.TabIndex = 17;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.LightCoral;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn5.ForeColor = System.Drawing.Color.Transparent;
            this.btn5.Location = new System.Drawing.Point(975, 184);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(81, 63);
            this.btn5.TabIndex = 16;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.LightCoral;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.ForeColor = System.Drawing.Color.Transparent;
            this.btn4.Location = new System.Drawing.Point(888, 184);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(81, 63);
            this.btn4.TabIndex = 15;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.LightCoral;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn9.ForeColor = System.Drawing.Color.Transparent;
            this.btn9.Location = new System.Drawing.Point(1062, 257);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(81, 63);
            this.btn9.TabIndex = 20;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.LightCoral;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn8.ForeColor = System.Drawing.Color.Transparent;
            this.btn8.Location = new System.Drawing.Point(975, 257);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(81, 63);
            this.btn8.TabIndex = 19;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.LightCoral;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn7.ForeColor = System.Drawing.Color.Transparent;
            this.btn7.Location = new System.Drawing.Point(888, 257);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(81, 63);
            this.btn7.TabIndex = 18;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.LightCoral;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.Transparent;
            this.btnTemizle.Location = new System.Drawing.Point(888, 328);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(168, 63);
            this.btnTemizle.TabIndex = 21;
            this.btnTemizle.Text = "C";
            this.btnTemizle.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.LightCoral;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn0.ForeColor = System.Drawing.Color.Transparent;
            this.btn0.Location = new System.Drawing.Point(1062, 328);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(81, 63);
            this.btn0.TabIndex = 22;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(888, 71);
            this.txtAdet.Multiline = true;
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(255, 37);
            this.txtAdet.TabIndex = 23;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.LightCoral;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Transparent;
            this.btnCikis.Location = new System.Drawing.Point(171, 562);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(101, 70);
            this.btnCikis.TabIndex = 25;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.LightCoral;
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.ForeColor = System.Drawing.Color.Transparent;
            this.btnGeriDon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGeriDon.Location = new System.Drawing.Point(55, 562);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(97, 70);
            this.btnGeriDon.TabIndex = 24;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnOdeme
            // 
            this.btnOdeme.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOdeme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOdeme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdeme.ForeColor = System.Drawing.Color.Black;
            this.btnOdeme.Location = new System.Drawing.Point(999, 433);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(144, 74);
            this.btnOdeme.TabIndex = 8;
            this.btnOdeme.Text = "Ödeme";
            this.btnOdeme.UseVisualStyleBackColor = false;
            // 
            // btnSiparis
            // 
            this.btnSiparis.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSiparis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiparis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparis.ForeColor = System.Drawing.Color.Black;
            this.btnSiparis.Location = new System.Drawing.Point(888, 433);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(105, 74);
            this.btnSiparis.TabIndex = 26;
            this.btnSiparis.Text = "Sipariş";
            this.btnSiparis.UseVisualStyleBackColor = false;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Gainsboro;
            this.btnIptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.Black;
            this.btnIptal.Location = new System.Drawing.Point(888, 513);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(255, 74);
            this.btnIptal.TabIndex = 27;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            // 
            // frmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1191, 734);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMasaNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSiparis";
            this.Text = "frmSiparis";
            this.Load += new System.EventHandler(this.frmSiparis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Button btnYemekler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvMenu;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvSiparisler;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnIptal;
    }
}