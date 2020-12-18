namespace Hotelli_Sivu
{
    partial class Hallitse_Huoneita
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Ei_RButon = new System.Windows.Forms.RadioButton();
            this.Kyllä_RButon = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.HuoneetCBx = new System.Windows.Forms.ComboBox();
            this.Tyhjenä_Huo_Tiedot = new System.Windows.Forms.Button();
            this.Poista_Huo = new System.Windows.Forms.Button();
            this.Muokaa_Huo = new System.Windows.Forms.Button();
            this.Lisää_Uusi_Huone = new System.Windows.Forms.Button();
            this.Huoneet_Data_Grid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Puhelin_Huo_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.huoneNum_TB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Huoneet_Data_Grid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.HuoneetCBx);
            this.panel1.Controls.Add(this.Tyhjenä_Huo_Tiedot);
            this.panel1.Controls.Add(this.Poista_Huo);
            this.panel1.Controls.Add(this.Muokaa_Huo);
            this.panel1.Controls.Add(this.Lisää_Uusi_Huone);
            this.panel1.Controls.Add(this.Huoneet_Data_Grid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Puhelin_Huo_TB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.huoneNum_TB);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 518);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.Ei_RButon);
            this.panel3.Controls.Add(this.Kyllä_RButon);
            this.panel3.Location = new System.Drawing.Point(164, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 36);
            this.panel3.TabIndex = 19;
            // 
            // Ei_RButon
            // 
            this.Ei_RButon.AutoSize = true;
            this.Ei_RButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ei_RButon.ForeColor = System.Drawing.Color.Maroon;
            this.Ei_RButon.Location = new System.Drawing.Point(92, 4);
            this.Ei_RButon.Name = "Ei_RButon";
            this.Ei_RButon.Size = new System.Drawing.Size(47, 28);
            this.Ei_RButon.TabIndex = 1;
            this.Ei_RButon.TabStop = true;
            this.Ei_RButon.Text = "Ei";
            this.Ei_RButon.UseVisualStyleBackColor = true;
            // 
            // Kyllä_RButon
            // 
            this.Kyllä_RButon.AutoSize = true;
            this.Kyllä_RButon.Checked = true;
            this.Kyllä_RButon.Cursor = System.Windows.Forms.Cursors.Default;
            this.Kyllä_RButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kyllä_RButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Kyllä_RButon.Location = new System.Drawing.Point(11, 4);
            this.Kyllä_RButon.Name = "Kyllä_RButon";
            this.Kyllä_RButon.Size = new System.Drawing.Size(72, 28);
            this.Kyllä_RButon.TabIndex = 0;
            this.Kyllä_RButon.TabStop = true;
            this.Kyllä_RButon.Text = "Kyllä";
            this.Kyllä_RButon.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Vapaa:";
            // 
            // HuoneetCBx
            // 
            this.HuoneetCBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HuoneetCBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuoneetCBx.FormattingEnabled = true;
            this.HuoneetCBx.Location = new System.Drawing.Point(164, 188);
            this.HuoneetCBx.Name = "HuoneetCBx";
            this.HuoneetCBx.Size = new System.Drawing.Size(220, 32);
            this.HuoneetCBx.TabIndex = 16;
            // 
            // Tyhjenä_Huo_Tiedot
            // 
            this.Tyhjenä_Huo_Tiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tyhjenä_Huo_Tiedot.Location = new System.Drawing.Point(152, 417);
            this.Tyhjenä_Huo_Tiedot.Name = "Tyhjenä_Huo_Tiedot";
            this.Tyhjenä_Huo_Tiedot.Size = new System.Drawing.Size(232, 33);
            this.Tyhjenä_Huo_Tiedot.TabIndex = 15;
            this.Tyhjenä_Huo_Tiedot.Text = "Tyhjenä Tiedot";
            this.Tyhjenä_Huo_Tiedot.UseVisualStyleBackColor = true;
            this.Tyhjenä_Huo_Tiedot.Click += new System.EventHandler(this.Tyhjenä_Huo_Tiedot_Click);
            // 
            // Poista_Huo
            // 
            this.Poista_Huo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poista_Huo.Location = new System.Drawing.Point(24, 417);
            this.Poista_Huo.Name = "Poista_Huo";
            this.Poista_Huo.Size = new System.Drawing.Size(122, 32);
            this.Poista_Huo.TabIndex = 14;
            this.Poista_Huo.Text = "Poista";
            this.Poista_Huo.UseVisualStyleBackColor = true;
            this.Poista_Huo.Click += new System.EventHandler(this.Poista_Huo_Click);
            // 
            // Muokaa_Huo
            // 
            this.Muokaa_Huo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Muokaa_Huo.Location = new System.Drawing.Point(242, 379);
            this.Muokaa_Huo.Name = "Muokaa_Huo";
            this.Muokaa_Huo.Size = new System.Drawing.Size(142, 32);
            this.Muokaa_Huo.TabIndex = 13;
            this.Muokaa_Huo.Text = "Muokaa";
            this.Muokaa_Huo.UseVisualStyleBackColor = true;
            this.Muokaa_Huo.Click += new System.EventHandler(this.Muokaa_Huo_Click);
            // 
            // Lisää_Uusi_Huone
            // 
            this.Lisää_Uusi_Huone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lisää_Uusi_Huone.Location = new System.Drawing.Point(24, 379);
            this.Lisää_Uusi_Huone.Name = "Lisää_Uusi_Huone";
            this.Lisää_Uusi_Huone.Size = new System.Drawing.Size(212, 32);
            this.Lisää_Uusi_Huone.TabIndex = 12;
            this.Lisää_Uusi_Huone.Text = "Lisää Uusi Huone";
            this.Lisää_Uusi_Huone.UseVisualStyleBackColor = true;
            this.Lisää_Uusi_Huone.Click += new System.EventHandler(this.Lisää_Uusi_Huone_Click);
            // 
            // Huoneet_Data_Grid
            // 
            this.Huoneet_Data_Grid.AllowUserToAddRows = false;
            this.Huoneet_Data_Grid.AllowUserToDeleteRows = false;
            this.Huoneet_Data_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Huoneet_Data_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Huoneet_Data_Grid.Location = new System.Drawing.Point(398, 103);
            this.Huoneet_Data_Grid.Name = "Huoneet_Data_Grid";
            this.Huoneet_Data_Grid.ReadOnly = true;
            this.Huoneet_Data_Grid.Size = new System.Drawing.Size(619, 403);
            this.Huoneet_Data_Grid.TabIndex = 11;
            this.Huoneet_Data_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Huoneet_Data_Grid_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Puhelin Num:";
            // 
            // Puhelin_Huo_TB
            // 
            this.Puhelin_Huo_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puhelin_Huo_TB.Location = new System.Drawing.Point(164, 235);
            this.Puhelin_Huo_TB.Name = "Puhelin_Huo_TB";
            this.Puhelin_Huo_TB.Size = new System.Drawing.Size(220, 29);
            this.Puhelin_Huo_TB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Huone Tyypi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Huone Numero:";
            // 
            // huoneNum_TB
            // 
            this.huoneNum_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneNum_TB.Location = new System.Drawing.Point(164, 147);
            this.huoneNum_TB.Name = "huoneNum_TB";
            this.huoneNum_TB.Size = new System.Drawing.Size(135, 29);
            this.huoneNum_TB.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 82);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1040, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hallitse Huoneita";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hallitse_Huoneita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 518);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1055, 557);
            this.MinimumSize = new System.Drawing.Size(1055, 557);
            this.Name = "Hallitse_Huoneita";
            this.Text = "Hallitse_Huoneita";
            this.Load += new System.EventHandler(this.Hallitse_Huoneita_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Huoneet_Data_Grid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox HuoneetCBx;
        private System.Windows.Forms.Button Tyhjenä_Huo_Tiedot;
        private System.Windows.Forms.Button Poista_Huo;
        private System.Windows.Forms.Button Muokaa_Huo;
        private System.Windows.Forms.Button Lisää_Uusi_Huone;
        private System.Windows.Forms.DataGridView Huoneet_Data_Grid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Puhelin_Huo_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox huoneNum_TB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton Kyllä_RButon;
        private System.Windows.Forms.RadioButton Ei_RButon;
    }
}