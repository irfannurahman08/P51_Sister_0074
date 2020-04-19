namespace P51_Sister_0074
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSuhuC = new System.Windows.Forms.TextBox();
            this.buttonKonversi = new System.Windows.Forms.Button();
            this.textBoxReamur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFahrenheit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKelvin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suhu Celcius";
            // 
            // textBoxSuhuC
            // 
            this.textBoxSuhuC.Location = new System.Drawing.Point(165, 23);
            this.textBoxSuhuC.Name = "textBoxSuhuC";
            this.textBoxSuhuC.Size = new System.Drawing.Size(132, 20);
            this.textBoxSuhuC.TabIndex = 1;
            // 
            // buttonKonversi
            // 
            this.buttonKonversi.Location = new System.Drawing.Point(57, 88);
            this.buttonKonversi.Name = "buttonKonversi";
            this.buttonKonversi.Size = new System.Drawing.Size(196, 33);
            this.buttonKonversi.TabIndex = 2;
            this.buttonKonversi.Text = "Konversi";
            this.buttonKonversi.UseVisualStyleBackColor = true;
            this.buttonKonversi.Click += new System.EventHandler(this.buttonKonversi_Click);
            // 
            // textBoxReamur
            // 
            this.textBoxReamur.Location = new System.Drawing.Point(165, 166);
            this.textBoxReamur.Name = "textBoxReamur";
            this.textBoxReamur.Size = new System.Drawing.Size(132, 20);
            this.textBoxReamur.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Suhu Reamur";
            // 
            // textBoxFahrenheit
            // 
            this.textBoxFahrenheit.Location = new System.Drawing.Point(165, 200);
            this.textBoxFahrenheit.Name = "textBoxFahrenheit";
            this.textBoxFahrenheit.Size = new System.Drawing.Size(132, 20);
            this.textBoxFahrenheit.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Suhu Fahrenheit";
            // 
            // textBoxKelvin
            // 
            this.textBoxKelvin.Location = new System.Drawing.Point(165, 236);
            this.textBoxKelvin.Name = "textBoxKelvin";
            this.textBoxKelvin.Size = new System.Drawing.Size(132, 20);
            this.textBoxKelvin.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Suhu Kelvin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 325);
            this.Controls.Add(this.textBoxKelvin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFahrenheit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxReamur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonKonversi);
            this.Controls.Add(this.textBoxSuhuC);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Konversi Suhu - Irfan Nurahman 18.11.0074";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSuhuC;
        private System.Windows.Forms.Button buttonKonversi;
        private System.Windows.Forms.TextBox textBoxReamur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFahrenheit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKelvin;
        private System.Windows.Forms.Label label4;
    }
}

