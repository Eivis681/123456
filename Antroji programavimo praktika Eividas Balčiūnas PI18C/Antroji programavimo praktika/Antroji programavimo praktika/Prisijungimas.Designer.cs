namespace Antroji_programavimo_praktika
{
    partial class Prisijungimas
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
            this.Prisijungti = new System.Windows.Forms.Button();
            this.PrisijungimoSlaptazodis = new System.Windows.Forms.TextBox();
            this.PrisijungimoVardas = new System.Windows.Forms.TextBox();
            this.Registruotis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Prisijungti
            // 
            this.Prisijungti.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prisijungti.Location = new System.Drawing.Point(73, 170);
            this.Prisijungti.Name = "Prisijungti";
            this.Prisijungti.Size = new System.Drawing.Size(177, 52);
            this.Prisijungti.TabIndex = 0;
            this.Prisijungti.Text = "Prisijungti";
            this.Prisijungti.UseVisualStyleBackColor = true;
            this.Prisijungti.Click += new System.EventHandler(this.Prisijungti_Click);
            // 
            // PrisijungimoSlaptazodis
            // 
            this.PrisijungimoSlaptazodis.Location = new System.Drawing.Point(59, 133);
            this.PrisijungimoSlaptazodis.Name = "PrisijungimoSlaptazodis";
            this.PrisijungimoSlaptazodis.Size = new System.Drawing.Size(207, 22);
            this.PrisijungimoSlaptazodis.TabIndex = 1;
            this.PrisijungimoSlaptazodis.UseSystemPasswordChar = true;
            // 
            // PrisijungimoVardas
            // 
            this.PrisijungimoVardas.Location = new System.Drawing.Point(59, 58);
            this.PrisijungimoVardas.Name = "PrisijungimoVardas";
            this.PrisijungimoVardas.Size = new System.Drawing.Size(207, 22);
            this.PrisijungimoVardas.TabIndex = 2;
            // 
            // Registruotis
            // 
            this.Registruotis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registruotis.Location = new System.Drawing.Point(73, 239);
            this.Registruotis.Name = "Registruotis";
            this.Registruotis.Size = new System.Drawing.Size(177, 52);
            this.Registruotis.TabIndex = 3;
            this.Registruotis.Text = "Registruotis";
            this.Registruotis.UseVisualStyleBackColor = true;
            this.Registruotis.Click += new System.EventHandler(this.Registruotis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vartotojo vardas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Slaptažodis:";
            // 
            // Prisijungimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registruotis);
            this.Controls.Add(this.PrisijungimoVardas);
            this.Controls.Add(this.PrisijungimoSlaptazodis);
            this.Controls.Add(this.Prisijungti);
            this.Name = "Prisijungimas";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Prisijungti;
        private System.Windows.Forms.TextBox PrisijungimoSlaptazodis;
        private System.Windows.Forms.TextBox PrisijungimoVardas;
        private System.Windows.Forms.Button Registruotis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

