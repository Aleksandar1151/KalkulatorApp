
namespace KalkulatorApp
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
            this.rezultatBox = new System.Windows.Forms.TextBox();
            this.labelPozadina = new System.Windows.Forms.Label();
            this.dugme1 = new System.Windows.Forms.Button();
            this.dugme2 = new System.Windows.Forms.Button();
            this.dugme3 = new System.Windows.Forms.Button();
            this.dugme4 = new System.Windows.Forms.Button();
            this.dugme5 = new System.Windows.Forms.Button();
            this.dugme6 = new System.Windows.Forms.Button();
            this.dugme7 = new System.Windows.Forms.Button();
            this.dugme8 = new System.Windows.Forms.Button();
            this.dugme9 = new System.Windows.Forms.Button();
            this.dugme0 = new System.Windows.Forms.Button();
            this.dugmeSabiranje = new System.Windows.Forms.Button();
            this.dugmeOduzimanje = new System.Windows.Forms.Button();
            this.dugmeMnozenje = new System.Windows.Forms.Button();
            this.dugmeJednako = new System.Windows.Forms.Button();
            this.dugmeDijeljenje = new System.Windows.Forms.Button();
            this.labelIstorija = new System.Windows.Forms.Label();
            this.dugmeOcisti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rezultatBox
            // 
            this.rezultatBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rezultatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rezultatBox.Enabled = false;
            this.rezultatBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezultatBox.Location = new System.Drawing.Point(12, 24);
            this.rezultatBox.Name = "rezultatBox";
            this.rezultatBox.ReadOnly = true;
            this.rezultatBox.Size = new System.Drawing.Size(360, 33);
            this.rezultatBox.TabIndex = 0;
            this.rezultatBox.Text = "0";
            this.rezultatBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPozadina
            // 
            this.labelPozadina.BackColor = System.Drawing.Color.White;
            this.labelPozadina.Location = new System.Drawing.Point(-3, -5);
            this.labelPozadina.Margin = new System.Windows.Forms.Padding(0);
            this.labelPozadina.Name = "labelPozadina";
            this.labelPozadina.Size = new System.Drawing.Size(391, 92);
            this.labelPozadina.TabIndex = 2;
            // 
            // dugme1
            // 
            this.dugme1.BackColor = System.Drawing.Color.DimGray;
            this.dugme1.FlatAppearance.BorderSize = 0;
            this.dugme1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme1.ForeColor = System.Drawing.Color.White;
            this.dugme1.Location = new System.Drawing.Point(12, 261);
            this.dugme1.Name = "dugme1";
            this.dugme1.Size = new System.Drawing.Size(75, 75);
            this.dugme1.TabIndex = 3;
            this.dugme1.Text = "1";
            this.dugme1.UseVisualStyleBackColor = false;
            this.dugme1.Click += new System.EventHandler(this.Dugme1Klik);
            // 
            // dugme2
            // 
            this.dugme2.BackColor = System.Drawing.Color.DimGray;
            this.dugme2.FlatAppearance.BorderSize = 0;
            this.dugme2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme2.ForeColor = System.Drawing.Color.White;
            this.dugme2.Location = new System.Drawing.Point(93, 261);
            this.dugme2.Name = "dugme2";
            this.dugme2.Size = new System.Drawing.Size(75, 75);
            this.dugme2.TabIndex = 4;
            this.dugme2.Text = "2";
            this.dugme2.UseVisualStyleBackColor = false;
            this.dugme2.Click += new System.EventHandler(this.Dugme2Klik);
            // 
            // dugme3
            // 
            this.dugme3.BackColor = System.Drawing.Color.DimGray;
            this.dugme3.FlatAppearance.BorderSize = 0;
            this.dugme3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme3.ForeColor = System.Drawing.Color.White;
            this.dugme3.Location = new System.Drawing.Point(174, 261);
            this.dugme3.Name = "dugme3";
            this.dugme3.Size = new System.Drawing.Size(75, 75);
            this.dugme3.TabIndex = 5;
            this.dugme3.Text = "3";
            this.dugme3.UseVisualStyleBackColor = false;
            this.dugme3.Click += new System.EventHandler(this.Dugme3Klik);
            // 
            // dugme4
            // 
            this.dugme4.BackColor = System.Drawing.Color.DimGray;
            this.dugme4.FlatAppearance.BorderSize = 0;
            this.dugme4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme4.ForeColor = System.Drawing.Color.White;
            this.dugme4.Location = new System.Drawing.Point(12, 180);
            this.dugme4.Name = "dugme4";
            this.dugme4.Size = new System.Drawing.Size(75, 75);
            this.dugme4.TabIndex = 6;
            this.dugme4.Text = "4";
            this.dugme4.UseVisualStyleBackColor = false;
            this.dugme4.Click += new System.EventHandler(this.Dugme4Klik);
            // 
            // dugme5
            // 
            this.dugme5.BackColor = System.Drawing.Color.DimGray;
            this.dugme5.FlatAppearance.BorderSize = 0;
            this.dugme5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme5.ForeColor = System.Drawing.Color.White;
            this.dugme5.Location = new System.Drawing.Point(93, 180);
            this.dugme5.Name = "dugme5";
            this.dugme5.Size = new System.Drawing.Size(75, 75);
            this.dugme5.TabIndex = 7;
            this.dugme5.Text = "5";
            this.dugme5.UseVisualStyleBackColor = false;
            this.dugme5.Click += new System.EventHandler(this.Dugme5Klik);
            // 
            // dugme6
            // 
            this.dugme6.BackColor = System.Drawing.Color.DimGray;
            this.dugme6.FlatAppearance.BorderSize = 0;
            this.dugme6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme6.ForeColor = System.Drawing.Color.White;
            this.dugme6.Location = new System.Drawing.Point(174, 180);
            this.dugme6.Name = "dugme6";
            this.dugme6.Size = new System.Drawing.Size(75, 75);
            this.dugme6.TabIndex = 8;
            this.dugme6.Text = "6";
            this.dugme6.UseVisualStyleBackColor = false;
            this.dugme6.Click += new System.EventHandler(this.Dugme6Klik);
            // 
            // dugme7
            // 
            this.dugme7.BackColor = System.Drawing.Color.DimGray;
            this.dugme7.FlatAppearance.BorderSize = 0;
            this.dugme7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme7.ForeColor = System.Drawing.Color.White;
            this.dugme7.Location = new System.Drawing.Point(12, 99);
            this.dugme7.Name = "dugme7";
            this.dugme7.Size = new System.Drawing.Size(75, 75);
            this.dugme7.TabIndex = 9;
            this.dugme7.Text = "7";
            this.dugme7.UseVisualStyleBackColor = false;
            this.dugme7.Click += new System.EventHandler(this.Dugme7Klik);
            // 
            // dugme8
            // 
            this.dugme8.BackColor = System.Drawing.Color.DimGray;
            this.dugme8.FlatAppearance.BorderSize = 0;
            this.dugme8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme8.ForeColor = System.Drawing.Color.White;
            this.dugme8.Location = new System.Drawing.Point(93, 99);
            this.dugme8.Name = "dugme8";
            this.dugme8.Size = new System.Drawing.Size(75, 75);
            this.dugme8.TabIndex = 10;
            this.dugme8.Text = "8";
            this.dugme8.UseVisualStyleBackColor = false;
            this.dugme8.Click += new System.EventHandler(this.Dugme8Klik);
            // 
            // dugme9
            // 
            this.dugme9.BackColor = System.Drawing.Color.DimGray;
            this.dugme9.FlatAppearance.BorderSize = 0;
            this.dugme9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme9.ForeColor = System.Drawing.Color.White;
            this.dugme9.Location = new System.Drawing.Point(174, 99);
            this.dugme9.Name = "dugme9";
            this.dugme9.Size = new System.Drawing.Size(75, 75);
            this.dugme9.TabIndex = 11;
            this.dugme9.Text = "9";
            this.dugme9.UseVisualStyleBackColor = false;
            this.dugme9.Click += new System.EventHandler(this.Dugme9Klik);
            // 
            // dugme0
            // 
            this.dugme0.BackColor = System.Drawing.Color.DimGray;
            this.dugme0.FlatAppearance.BorderSize = 0;
            this.dugme0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme0.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme0.ForeColor = System.Drawing.Color.White;
            this.dugme0.Location = new System.Drawing.Point(93, 342);
            this.dugme0.Name = "dugme0";
            this.dugme0.Size = new System.Drawing.Size(75, 75);
            this.dugme0.TabIndex = 12;
            this.dugme0.Text = "0";
            this.dugme0.UseVisualStyleBackColor = false;
            this.dugme0.Click += new System.EventHandler(this.Dugme0Klik);
            // 
            // dugmeSabiranje
            // 
            this.dugmeSabiranje.BackColor = System.Drawing.Color.DimGray;
            this.dugmeSabiranje.FlatAppearance.BorderSize = 0;
            this.dugmeSabiranje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeSabiranje.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeSabiranje.ForeColor = System.Drawing.Color.White;
            this.dugmeSabiranje.Location = new System.Drawing.Point(255, 99);
            this.dugmeSabiranje.Name = "dugmeSabiranje";
            this.dugmeSabiranje.Size = new System.Drawing.Size(117, 75);
            this.dugmeSabiranje.TabIndex = 13;
            this.dugmeSabiranje.Text = "+";
            this.dugmeSabiranje.UseVisualStyleBackColor = false;
            this.dugmeSabiranje.Click += new System.EventHandler(this.DugmeSabiranjeKlik);
            // 
            // dugmeOduzimanje
            // 
            this.dugmeOduzimanje.BackColor = System.Drawing.Color.DimGray;
            this.dugmeOduzimanje.FlatAppearance.BorderSize = 0;
            this.dugmeOduzimanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeOduzimanje.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeOduzimanje.ForeColor = System.Drawing.Color.White;
            this.dugmeOduzimanje.Location = new System.Drawing.Point(255, 180);
            this.dugmeOduzimanje.Name = "dugmeOduzimanje";
            this.dugmeOduzimanje.Size = new System.Drawing.Size(117, 75);
            this.dugmeOduzimanje.TabIndex = 14;
            this.dugmeOduzimanje.Text = "-";
            this.dugmeOduzimanje.UseVisualStyleBackColor = false;
            this.dugmeOduzimanje.Click += new System.EventHandler(this.DugmeOduzimanjeKlik);
            // 
            // dugmeMnozenje
            // 
            this.dugmeMnozenje.BackColor = System.Drawing.Color.DimGray;
            this.dugmeMnozenje.FlatAppearance.BorderSize = 0;
            this.dugmeMnozenje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeMnozenje.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeMnozenje.ForeColor = System.Drawing.Color.White;
            this.dugmeMnozenje.Location = new System.Drawing.Point(255, 261);
            this.dugmeMnozenje.Name = "dugmeMnozenje";
            this.dugmeMnozenje.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.dugmeMnozenje.Size = new System.Drawing.Size(117, 75);
            this.dugmeMnozenje.TabIndex = 15;
            this.dugmeMnozenje.Text = "*";
            this.dugmeMnozenje.UseVisualStyleBackColor = false;
            this.dugmeMnozenje.Click += new System.EventHandler(this.DugmeMnozenjeKlik);
            // 
            // dugmeJednako
            // 
            this.dugmeJednako.BackColor = System.Drawing.Color.DimGray;
            this.dugmeJednako.FlatAppearance.BorderSize = 0;
            this.dugmeJednako.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeJednako.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeJednako.ForeColor = System.Drawing.Color.White;
            this.dugmeJednako.Location = new System.Drawing.Point(174, 342);
            this.dugmeJednako.Name = "dugmeJednako";
            this.dugmeJednako.Size = new System.Drawing.Size(75, 75);
            this.dugmeJednako.TabIndex = 16;
            this.dugmeJednako.Text = "=";
            this.dugmeJednako.UseVisualStyleBackColor = false;
            this.dugmeJednako.Click += new System.EventHandler(this.dugmeJednakoKlik);
            // 
            // dugmeDijeljenje
            // 
            this.dugmeDijeljenje.BackColor = System.Drawing.Color.DimGray;
            this.dugmeDijeljenje.FlatAppearance.BorderSize = 0;
            this.dugmeDijeljenje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeDijeljenje.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeDijeljenje.ForeColor = System.Drawing.Color.White;
            this.dugmeDijeljenje.Location = new System.Drawing.Point(255, 342);
            this.dugmeDijeljenje.Name = "dugmeDijeljenje";
            this.dugmeDijeljenje.Size = new System.Drawing.Size(117, 75);
            this.dugmeDijeljenje.TabIndex = 17;
            this.dugmeDijeljenje.Text = "/";
            this.dugmeDijeljenje.UseVisualStyleBackColor = false;
            this.dugmeDijeljenje.Click += new System.EventHandler(this.DugmeDijeljenjeKlik);
            // 
            // labelIstorija
            // 
            this.labelIstorija.BackColor = System.Drawing.Color.White;
            this.labelIstorija.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIstorija.ForeColor = System.Drawing.Color.Gray;
            this.labelIstorija.Location = new System.Drawing.Point(162, 9);
            this.labelIstorija.Name = "labelIstorija";
            this.labelIstorija.Size = new System.Drawing.Size(198, 19);
            this.labelIstorija.TabIndex = 18;
            this.labelIstorija.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dugmeOcisti
            // 
            this.dugmeOcisti.BackColor = System.Drawing.Color.DimGray;
            this.dugmeOcisti.FlatAppearance.BorderSize = 0;
            this.dugmeOcisti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeOcisti.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeOcisti.ForeColor = System.Drawing.Color.White;
            this.dugmeOcisti.Location = new System.Drawing.Point(12, 342);
            this.dugmeOcisti.Name = "dugmeOcisti";
            this.dugmeOcisti.Size = new System.Drawing.Size(75, 75);
            this.dugmeOcisti.TabIndex = 19;
            this.dugmeOcisti.Text = "C";
            this.dugmeOcisti.UseVisualStyleBackColor = false;
            this.dugmeOcisti.Click += new System.EventHandler(this.DugmeOcistiKlik);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(384, 434);
            this.Controls.Add(this.dugmeOcisti);
            this.Controls.Add(this.labelIstorija);
            this.Controls.Add(this.dugmeDijeljenje);
            this.Controls.Add(this.dugmeJednako);
            this.Controls.Add(this.dugmeMnozenje);
            this.Controls.Add(this.dugmeOduzimanje);
            this.Controls.Add(this.dugmeSabiranje);
            this.Controls.Add(this.dugme0);
            this.Controls.Add(this.dugme9);
            this.Controls.Add(this.dugme8);
            this.Controls.Add(this.dugme7);
            this.Controls.Add(this.dugme6);
            this.Controls.Add(this.dugme5);
            this.Controls.Add(this.dugme4);
            this.Controls.Add(this.dugme3);
            this.Controls.Add(this.dugme2);
            this.Controls.Add(this.dugme1);
            this.Controls.Add(this.rezultatBox);
            this.Controls.Add(this.labelPozadina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rezultatBox;
        private System.Windows.Forms.Label labelPozadina;
        private System.Windows.Forms.Button dugme1;
        private System.Windows.Forms.Button dugme2;
        private System.Windows.Forms.Button dugme3;
        private System.Windows.Forms.Button dugme4;
        private System.Windows.Forms.Button dugme5;
        private System.Windows.Forms.Button dugme6;
        private System.Windows.Forms.Button dugme7;
        private System.Windows.Forms.Button dugme8;
        private System.Windows.Forms.Button dugme9;
        private System.Windows.Forms.Button dugme0;
        private System.Windows.Forms.Button dugmeSabiranje;
        private System.Windows.Forms.Button dugmeOduzimanje;
        private System.Windows.Forms.Button dugmeMnozenje;
        private System.Windows.Forms.Button dugmeJednako;
        private System.Windows.Forms.Button dugmeDijeljenje;
        private System.Windows.Forms.Label labelIstorija;
        private System.Windows.Forms.Button dugmeOcisti;
    }
}

