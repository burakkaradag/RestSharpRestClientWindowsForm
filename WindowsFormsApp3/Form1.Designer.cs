namespace WindowsFormsApp3
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
            this.btnekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbboxsehir = new System.Windows.Forms.ComboBox();
            this.txtboxad = new System.Windows.Forms.TextBox();
            this.txtboxsoyad = new System.Windows.Forms.TextBox();
            this.txtboxıd = new System.Windows.Forms.TextBox();
            this.btnguncel = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(656, 163);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 0;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmbboxsehir
            // 
            this.cmbboxsehir.FormattingEnabled = true;
            this.cmbboxsehir.Location = new System.Drawing.Point(656, 126);
            this.cmbboxsehir.Name = "cmbboxsehir";
            this.cmbboxsehir.Size = new System.Drawing.Size(121, 21);
            this.cmbboxsehir.TabIndex = 2;
            // 
            // txtboxad
            // 
            this.txtboxad.Location = new System.Drawing.Point(656, 48);
            this.txtboxad.Name = "txtboxad";
            this.txtboxad.Size = new System.Drawing.Size(100, 20);
            this.txtboxad.TabIndex = 3;
            // 
            // txtboxsoyad
            // 
            this.txtboxsoyad.Location = new System.Drawing.Point(656, 88);
            this.txtboxsoyad.Name = "txtboxsoyad";
            this.txtboxsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtboxsoyad.TabIndex = 4;
            // 
            // txtboxıd
            // 
            this.txtboxıd.Location = new System.Drawing.Point(656, 12);
            this.txtboxıd.Name = "txtboxıd";
            this.txtboxıd.Size = new System.Drawing.Size(100, 20);
            this.txtboxıd.TabIndex = 5;
            // 
            // btnguncel
            // 
            this.btnguncel.Location = new System.Drawing.Point(656, 203);
            this.btnguncel.Name = "btnguncel";
            this.btnguncel.Size = new System.Drawing.Size(75, 23);
            this.btnguncel.TabIndex = 6;
            this.btnguncel.Text = "Güncelle";
            this.btnguncel.UseVisualStyleBackColor = true;
            this.btnguncel.Click += new System.EventHandler(this.btnguncel_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(656, 241);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 7;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncel);
            this.Controls.Add(this.txtboxıd);
            this.Controls.Add(this.txtboxsoyad);
            this.Controls.Add(this.txtboxad);
            this.Controls.Add(this.cmbboxsehir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnekle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbboxsehir;
        private System.Windows.Forms.TextBox txtboxad;
        private System.Windows.Forms.TextBox txtboxsoyad;
        private System.Windows.Forms.TextBox txtboxıd;
        private System.Windows.Forms.Button btnguncel;
        private System.Windows.Forms.Button btnsil;
    }
}

