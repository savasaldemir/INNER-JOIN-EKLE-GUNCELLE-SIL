namespace Delete_Pro
{
    partial class Guncelle
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
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.lbl_isim_Guncelle = new System.Windows.Forms.Label();
            this.lbl_Soyisim = new System.Windows.Forms.Label();
            this.txt_Isim = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.dataGrid_Bilgiler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Bilgiler)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Guncelle.FlatAppearance.BorderSize = 0;
            this.btn_Guncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btn_Guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guncelle.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(0, 212);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(549, 47);
            this.btn_Guncelle.TabIndex = 2;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // lbl_isim_Guncelle
            // 
            this.lbl_isim_Guncelle.AutoSize = true;
            this.lbl_isim_Guncelle.BackColor = System.Drawing.Color.Silver;
            this.lbl_isim_Guncelle.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isim_Guncelle.Location = new System.Drawing.Point(23, 36);
            this.lbl_isim_Guncelle.Name = "lbl_isim_Guncelle";
            this.lbl_isim_Guncelle.Size = new System.Drawing.Size(36, 16);
            this.lbl_isim_Guncelle.TabIndex = 1;
            this.lbl_isim_Guncelle.Text = "İsim";
            // 
            // lbl_Soyisim
            // 
            this.lbl_Soyisim.AutoSize = true;
            this.lbl_Soyisim.BackColor = System.Drawing.Color.Silver;
            this.lbl_Soyisim.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Soyisim.Location = new System.Drawing.Point(22, 88);
            this.lbl_Soyisim.Name = "lbl_Soyisim";
            this.lbl_Soyisim.Size = new System.Drawing.Size(59, 16);
            this.lbl_Soyisim.TabIndex = 2;
            this.lbl_Soyisim.Text = "Soyisim";
            // 
            // txt_Isim
            // 
            this.txt_Isim.BackColor = System.Drawing.Color.Silver;
            this.txt_Isim.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Isim.Location = new System.Drawing.Point(94, 29);
            this.txt_Isim.Name = "txt_Isim";
            this.txt_Isim.Size = new System.Drawing.Size(135, 22);
            this.txt_Isim.TabIndex = 0;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.BackColor = System.Drawing.Color.Silver;
            this.txt_soyisim.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyisim.Location = new System.Drawing.Point(94, 81);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(135, 22);
            this.txt_soyisim.TabIndex = 1;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(204, 130);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(50, 13);
            this.lbl_ID.TabIndex = 5;
            this.lbl_ID.Text = "ID değeri";
            // 
            // dataGrid_Bilgiler
            // 
            this.dataGrid_Bilgiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Bilgiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Bilgiler.Location = new System.Drawing.Point(272, 12);
            this.dataGrid_Bilgiler.Name = "dataGrid_Bilgiler";
            this.dataGrid_Bilgiler.Size = new System.Drawing.Size(268, 131);
            this.dataGrid_Bilgiler.TabIndex = 6;
            this.dataGrid_Bilgiler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Bilgiler_CellContentClick);
            // 
            // Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(549, 259);
            this.Controls.Add(this.dataGrid_Bilgiler);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.txt_Isim);
            this.Controls.Add(this.lbl_Soyisim);
            this.Controls.Add(this.lbl_isim_Guncelle);
            this.Controls.Add(this.btn_Guncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Guncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Güncelle";
            this.Load += new System.EventHandler(this.Guncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Bilgiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Label lbl_isim_Guncelle;
        private System.Windows.Forms.Label lbl_Soyisim;
        private System.Windows.Forms.TextBox txt_Isim;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.DataGridView dataGrid_Bilgiler;
    }
}