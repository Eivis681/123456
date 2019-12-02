namespace Antroji_programavimo_praktika
{
    partial class PI18A
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
            this.label1 = new System.Windows.Forms.Label();
            this.Studentai = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PridetiStudenta = new System.Windows.Forms.Button();
            this.IstrintiStudenta = new System.Windows.Forms.Button();
            this.PridetiPazimi = new System.Windows.Forms.Button();
            this.GrižtiAtgal = new System.Windows.Forms.Button();
            this.StudentoVardas = new System.Windows.Forms.TextBox();
            this.StudentoPavarde = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Atnaujinti = new System.Windows.Forms.Button();
            this.StudentoPazimys = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentoVidurkis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Grupė:";
            // 
            // Studentai
            // 
            this.Studentai.FormattingEnabled = true;
            this.Studentai.ItemHeight = 16;
            this.Studentai.Location = new System.Drawing.Point(37, 105);
            this.Studentai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Studentai.Name = "Studentai";
            this.Studentai.Size = new System.Drawing.Size(263, 308);
            this.Studentai.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Studentai:";
            // 
            // PridetiStudenta
            // 
            this.PridetiStudenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PridetiStudenta.Location = new System.Drawing.Point(37, 508);
            this.PridetiStudenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PridetiStudenta.Name = "PridetiStudenta";
            this.PridetiStudenta.Size = new System.Drawing.Size(177, 52);
            this.PridetiStudenta.TabIndex = 14;
            this.PridetiStudenta.Text = "Pridėti studentą";
            this.PridetiStudenta.UseVisualStyleBackColor = true;
            this.PridetiStudenta.Click += new System.EventHandler(this.PridetiStudenta_Click);
            // 
            // IstrintiStudenta
            // 
            this.IstrintiStudenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IstrintiStudenta.Location = new System.Drawing.Point(307, 105);
            this.IstrintiStudenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IstrintiStudenta.Name = "IstrintiStudenta";
            this.IstrintiStudenta.Size = new System.Drawing.Size(177, 52);
            this.IstrintiStudenta.TabIndex = 15;
            this.IstrintiStudenta.Text = "Ištrinti studentą";
            this.IstrintiStudenta.UseVisualStyleBackColor = true;
            this.IstrintiStudenta.Click += new System.EventHandler(this.IstrintiStudenta_Click);
            // 
            // PridetiPazimi
            // 
            this.PridetiPazimi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PridetiPazimi.Location = new System.Drawing.Point(289, 508);
            this.PridetiPazimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PridetiPazimi.Name = "PridetiPazimi";
            this.PridetiPazimi.Size = new System.Drawing.Size(177, 52);
            this.PridetiPazimi.TabIndex = 16;
            this.PridetiPazimi.Text = "Pirdėti pažimy";
            this.PridetiPazimi.UseVisualStyleBackColor = true;
            this.PridetiPazimi.Click += new System.EventHandler(this.PridetiPazimi_Click_1);
            // 
            // GrižtiAtgal
            // 
            this.GrižtiAtgal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrižtiAtgal.Location = new System.Drawing.Point(306, 273);
            this.GrižtiAtgal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrižtiAtgal.Name = "GrižtiAtgal";
            this.GrižtiAtgal.Size = new System.Drawing.Size(177, 52);
            this.GrižtiAtgal.TabIndex = 17;
            this.GrižtiAtgal.Text = "Grižti atgal";
            this.GrižtiAtgal.UseVisualStyleBackColor = true;
            this.GrižtiAtgal.Click += new System.EventHandler(this.GrižtiAtgal_Click);
            // 
            // StudentoVardas
            // 
            this.StudentoVardas.Location = new System.Drawing.Point(37, 434);
            this.StudentoVardas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentoVardas.Name = "StudentoVardas";
            this.StudentoVardas.Size = new System.Drawing.Size(207, 22);
            this.StudentoVardas.TabIndex = 21;
            // 
            // StudentoPavarde
            // 
            this.StudentoPavarde.Location = new System.Drawing.Point(37, 481);
            this.StudentoPavarde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentoPavarde.Name = "StudentoPavarde";
            this.StudentoPavarde.Size = new System.Drawing.Size(207, 22);
            this.StudentoPavarde.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Studento vardas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Studento pavardė:";
            // 
            // Atnaujinti
            // 
            this.Atnaujinti.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atnaujinti.Location = new System.Drawing.Point(306, 217);
            this.Atnaujinti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Atnaujinti.Name = "Atnaujinti";
            this.Atnaujinti.Size = new System.Drawing.Size(177, 52);
            this.Atnaujinti.TabIndex = 26;
            this.Atnaujinti.Text = "Atnaujinti";
            this.Atnaujinti.UseVisualStyleBackColor = true;
            this.Atnaujinti.Click += new System.EventHandler(this.Atnaujinti_Click);
            // 
            // StudentoPazimys
            // 
            this.StudentoPazimys.Location = new System.Drawing.Point(276, 434);
            this.StudentoPazimys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentoPazimys.Name = "StudentoPazimys";
            this.StudentoPazimys.Size = new System.Drawing.Size(207, 22);
            this.StudentoPazimys.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Studento pažimys:";
            // 
            // StudentoVidurkis
            // 
            this.StudentoVidurkis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentoVidurkis.Location = new System.Drawing.Point(307, 161);
            this.StudentoVidurkis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentoVidurkis.Name = "StudentoVidurkis";
            this.StudentoVidurkis.Size = new System.Drawing.Size(177, 52);
            this.StudentoVidurkis.TabIndex = 29;
            this.StudentoVidurkis.Text = "Studento vidurkis";
            this.StudentoVidurkis.UseVisualStyleBackColor = true;
            this.StudentoVidurkis.Click += new System.EventHandler(this.StudentoVidurkis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 33);
            this.label4.TabIndex = 30;
            this.label4.Text = "PI18A";
            // 
            // PI18A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 571);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StudentoVidurkis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentoPazimys);
            this.Controls.Add(this.Atnaujinti);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StudentoPavarde);
            this.Controls.Add(this.StudentoVardas);
            this.Controls.Add(this.GrižtiAtgal);
            this.Controls.Add(this.PridetiPazimi);
            this.Controls.Add(this.IstrintiStudenta);
            this.Controls.Add(this.PridetiStudenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Studentai);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PI18A";
            this.Text = "PI18A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Studentai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PridetiStudenta;
        private System.Windows.Forms.Button IstrintiStudenta;
        private System.Windows.Forms.Button PridetiPazimi;
        private System.Windows.Forms.Button GrižtiAtgal;
        private System.Windows.Forms.TextBox StudentoVardas;
        private System.Windows.Forms.TextBox StudentoPavarde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Atnaujinti;
        private System.Windows.Forms.TextBox StudentoPazimys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StudentoVidurkis;
        private System.Windows.Forms.Label label4;
    }
}