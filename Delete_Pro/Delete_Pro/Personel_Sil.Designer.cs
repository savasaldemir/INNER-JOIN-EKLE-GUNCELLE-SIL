namespace Delete_Pro
{
    partial class Personel_Sil
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
            this.lbl_İsim = new System.Windows.Forms.Label();
            this.lbl_Soyisim = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_Soyisim = new System.Windows.Forms.TextBox();
            this.btn_Personelsil = new System.Windows.Forms.Button();
            this.dataGrid_Bilgiler = new System.Windows.Forms.DataGridView();
            this.lbl_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Bilgiler)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_İsim
            // 
            this.lbl_İsim.AutoSize = true;
            this.lbl_İsim.BackColor = System.Drawing.Color.Silver;
            this.lbl_İsim.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_İsim.Location = new System.Drawing.Point(47, 56);
            this.lbl_İsim.Name = "lbl_İsim";
            this.lbl_İsim.Size = new System.Drawing.Size(36, 16);
            this.lbl_İsim.TabIndex = 0;
            this.lbl_İsim.Text = "İsim";
            // 
            // lbl_Soyisim
            // 
            this.lbl_Soyisim.AutoSize = true;
            this.lbl_Soyisim.BackColor = System.Drawing.Color.Silver;
            this.lbl_Soyisim.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Soyisim.Location = new System.Drawing.Point(35, 109);
            this.lbl_Soyisim.Name = "lbl_Soyisim";
            this.lbl_Soyisim.Size = new System.Drawing.Size(59, 16);
            this.lbl_Soyisim.TabIndex = 1;
            this.lbl_Soyisim.Text = "Soyisim";
            // 
            // txt_isim
            // 
            this.txt_isim.BackColor = System.Drawing.Color.Silver;
            this.txt_isim.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_isim.Location = new System.Drawing.Point(108, 56);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(165, 22);
            this.txt_isim.TabIndex = 2;
            // 
            // txt_Soyisim
            // 
            this.txt_Soyisim.BackColor = System.Drawing.Color.Silver;
            this.txt_Soyisim.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Soyisim.Location = new System.Drawing.Point(108, 105);
            this.txt_Soyisim.Name = "txt_Soyisim";
            this.txt_Soyisim.Size = new System.Drawing.Size(165, 22);
            this.txt_Soyisim.TabIndex = 2;
            // 
            // btn_Personelsil
            // 
            this.btn_Personelsil.BackColor = System.Drawing.Color.Silver;
            this.btn_Personelsil.FlatAppearance.BorderSize = 0;
            this.btn_Personelsil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btn_Personelsil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Personelsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Personelsil.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Personelsil.Location = new System.Drawing.Point(50, 157);
            this.btn_Personelsil.Name = "btn_Personelsil";
            this.btn_Personelsil.Size = new System.Drawing.Size(223, 76);
            this.btn_Personelsil.TabIndex = 3;
            this.btn_Personelsil.Text = "Personel Sil";
            this.btn_Personelsil.UseVisualStyleBackColor = false;
            this.btn_Personelsil.Click += new System.EventHandler(this.btn_Personelsil_Click);
            // 
            // dataGrid_Bilgiler
            // 
            this.dataGrid_Bilgiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Bilgiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Bilgiler.Location = new System.Drawing.Point(291, 12);
            this.dataGrid_Bilgiler.Name = "dataGrid_Bilgiler";
            this.dataGrid_Bilgiler.Size = new System.Drawing.Size(338, 219);
            this.dataGrid_Bilgiler.TabIndex = 4;
            this.dataGrid_Bilgiler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Bilgiler_CellContentClick);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ID.Location = new System.Drawing.Point(217, 21);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(28, 18);
            this.lbl_ID.TabIndex = 5;
            this.lbl_ID.Text = "ID";
            // 
            // Personel_Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(641, 245);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.dataGrid_Bilgiler);
            this.Controls.Add(this.btn_Personelsil);
            this.Controls.Add(this.txt_Soyisim);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.lbl_Soyisim);
            this.Controls.Add(this.lbl_İsim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Personel_Sil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL SİL";
            this.Load += new System.EventHandler(this.Personel_Sil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Bilgiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_İsim;
        private System.Windows.Forms.Label lbl_Soyisim;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_Soyisim;
        private System.Windows.Forms.Button btn_Personelsil;
        private System.Windows.Forms.DataGridView dataGrid_Bilgiler;
        private System.Windows.Forms.Label lbl_ID;
    }
}