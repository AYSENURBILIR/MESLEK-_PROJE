namespace Restoran_Otomasyonu
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnMasaSiparis = new System.Windows.Forms.Button();
            this.btnPaketServis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMasaSiparis
            // 
            this.btnMasaSiparis.BackColor = System.Drawing.Color.LightCoral;
            this.btnMasaSiparis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMasaSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMasaSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaSiparis.ForeColor = System.Drawing.Color.White;
            this.btnMasaSiparis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMasaSiparis.Location = new System.Drawing.Point(313, 179);
            this.btnMasaSiparis.Name = "btnMasaSiparis";
            this.btnMasaSiparis.Size = new System.Drawing.Size(139, 100);
            this.btnMasaSiparis.TabIndex = 0;
            this.btnMasaSiparis.Text = "Masa";
            this.btnMasaSiparis.UseVisualStyleBackColor = false;
            this.btnMasaSiparis.Click += new System.EventHandler(this.btnMasaSiparis_Click);
            // 
            // btnPaketServis
            // 
            this.btnPaketServis.BackColor = System.Drawing.Color.LightCoral;
            this.btnPaketServis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaketServis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaketServis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPaketServis.ForeColor = System.Drawing.Color.White;
            this.btnPaketServis.Location = new System.Drawing.Point(519, 179);
            this.btnPaketServis.Name = "btnPaketServis";
            this.btnPaketServis.Size = new System.Drawing.Size(139, 100);
            this.btnPaketServis.TabIndex = 2;
            this.btnPaketServis.Text = "Paket Sipariş";
            this.btnPaketServis.UseVisualStyleBackColor = false;
            this.btnPaketServis.Click += new System.EventHandler(this.btnPaketServis_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 574);
            this.Controls.Add(this.btnPaketServis);
            this.Controls.Add(this.btnMasaSiparis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMasaSiparis;
        private System.Windows.Forms.Button btnPaketServis;
    }
}