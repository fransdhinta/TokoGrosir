namespace GrosirSpwd
{
    partial class dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.namaToko = new System.Windows.Forms.Label();
            this.alamatToko = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namaToko
            // 
            this.namaToko.AutoSize = true;
            this.namaToko.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaToko.Location = new System.Drawing.Point(3, 0);
            this.namaToko.Name = "namaToko";
            this.namaToko.Size = new System.Drawing.Size(641, 77);
            this.namaToko.TabIndex = 0;
            this.namaToko.Text = "Toko Grosir Kalimeri";
            // 
            // alamatToko
            // 
            this.alamatToko.AutoSize = true;
            this.alamatToko.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamatToko.Location = new System.Drawing.Point(12, 53);
            this.alamatToko.Name = "alamatToko";
            this.alamatToko.Size = new System.Drawing.Size(730, 24);
            this.alamatToko.TabIndex = 1;
            this.alamatToko.Text = "Jl. Slamet No.21 RT 01 / RW 01 Sempalwadak Bululawang Kab. Malang";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.alamatToko);
            this.Controls.Add(this.namaToko);
            this.Name = "dashboard";
            this.Size = new System.Drawing.Size(1111, 742);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namaToko;
        private System.Windows.Forms.Label alamatToko;
    }
}
