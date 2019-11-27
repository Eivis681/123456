namespace Antroji_programavimo_praktika
{
    partial class Registracija
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
            this.Registruotis = new System.Windows.Forms.Button();
            this.RegistracijosSlaptažodzioPakartojimas = new System.Windows.Forms.TextBox();
            this.RegistracijosSpaltažodis = new System.Windows.Forms.TextBox();
            this.RegistacijosVardas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Registruotis
            // 
            this.Registruotis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registruotis.Location = new System.Drawing.Point(123, 250);
            this.Registruotis.Name = "Registruotis";
            this.Registruotis.Size = new System.Drawing.Size(177, 52);
            this.Registruotis.TabIndex = 4;
            this.Registruotis.Text = "Registruotis";
            this.Registruotis.UseVisualStyleBackColor = true;
            this.Registruotis.Click += new System.EventHandler(this.Registruotis_Click);
            // 
            // RegistracijosSlaptažodzioPakartojimas
            // 
            this.RegistracijosSlaptažodzioPakartojimas.Location = new System.Drawing.Point(106, 200);
            this.RegistracijosSlaptažodzioPakartojimas.Name = "RegistracijosSlaptažodzioPakartojimas";
            this.RegistracijosSlaptažodzioPakartojimas.Size = new System.Drawing.Size(207, 22);
            this.RegistracijosSlaptažodzioPakartojimas.TabIndex = 5;
            this.RegistracijosSlaptažodzioPakartojimas.UseSystemPasswordChar = true;
            // 
            // RegistracijosSpaltažodis
            // 
            this.RegistracijosSpaltažodis.Location = new System.Drawing.Point(106, 127);
            this.RegistracijosSpaltažodis.Name = "RegistracijosSpaltažodis";
            this.RegistracijosSpaltažodis.Size = new System.Drawing.Size(207, 22);
            this.RegistracijosSpaltažodis.TabIndex = 6;
            this.RegistracijosSpaltažodis.UseSystemPasswordChar = true;
            // 
            // RegistacijosVardas
            // 
            this.RegistacijosVardas.Location = new System.Drawing.Point(106, 53);
            this.RegistacijosVardas.Name = "RegistacijosVardas";
            this.RegistacijosVardas.Size = new System.Drawing.Size(207, 22);
            this.RegistacijosVardas.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vartotojo vardas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Slaptažodis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pakartoti slaptažodi:";
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegistacijosVardas);
            this.Controls.Add(this.RegistracijosSpaltažodis);
            this.Controls.Add(this.RegistracijosSlaptažodzioPakartojimas);
            this.Controls.Add(this.Registruotis);
            this.Name = "Registracija";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registruotis;
        private System.Windows.Forms.TextBox RegistacijosVardas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox RegistracijosSpaltažodis;
        public System.Windows.Forms.TextBox RegistracijosSlaptažodzioPakartojimas;
    }
}