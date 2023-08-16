
namespace MiniERP
{
    partial class frmOffice
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
            this.tbCodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTerritori = new System.Windows.Forms.TextBox();
            this.tbCp = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbAddress2 = new System.Windows.Forms.TextBox();
            this.tbAdress1 = new System.Windows.Forms.TextBox();
            this.tbTelf = new System.Windows.Forms.TextBox();
            this.tbCiutat = new System.Windows.Forms.TextBox();
            this.btnDesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Office Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbCodi
            // 
            this.tbCodi.Location = new System.Drawing.Point(129, 21);
            this.tbCodi.Name = "tbCodi";
            this.tbCodi.Size = new System.Drawing.Size(226, 26);
            this.tbCodi.TabIndex = 1;
            this.tbCodi.TextChanged += new System.EventHandler(this.tbCodi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Territory";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Postal Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Country";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "State";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 30);
            this.label7.TabIndex = 7;
            this.label7.Text = "Address 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 30);
            this.label8.TabIndex = 8;
            this.label8.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 30);
            this.label9.TabIndex = 9;
            this.label9.Text = "City";
            // 
            // tbTerritori
            // 
            this.tbTerritori.Location = new System.Drawing.Point(129, 276);
            this.tbTerritori.Name = "tbTerritori";
            this.tbTerritori.Size = new System.Drawing.Size(226, 26);
            this.tbTerritori.TabIndex = 10;
            // 
            // tbCp
            // 
            this.tbCp.Location = new System.Drawing.Point(129, 244);
            this.tbCp.Name = "tbCp";
            this.tbCp.Size = new System.Drawing.Size(226, 26);
            this.tbCp.TabIndex = 11;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(129, 212);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(226, 26);
            this.tbCountry.TabIndex = 12;
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(129, 181);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(226, 26);
            this.tbState.TabIndex = 13;
            // 
            // tbAddress2
            // 
            this.tbAddress2.Location = new System.Drawing.Point(129, 149);
            this.tbAddress2.Name = "tbAddress2";
            this.tbAddress2.Size = new System.Drawing.Size(226, 26);
            this.tbAddress2.TabIndex = 14;
            // 
            // tbAdress1
            // 
            this.tbAdress1.Location = new System.Drawing.Point(129, 117);
            this.tbAdress1.Name = "tbAdress1";
            this.tbAdress1.Size = new System.Drawing.Size(226, 26);
            this.tbAdress1.TabIndex = 15;
            // 
            // tbTelf
            // 
            this.tbTelf.Location = new System.Drawing.Point(129, 85);
            this.tbTelf.Name = "tbTelf";
            this.tbTelf.Size = new System.Drawing.Size(226, 26);
            this.tbTelf.TabIndex = 16;
            // 
            // tbCiutat
            // 
            this.tbCiutat.Location = new System.Drawing.Point(129, 53);
            this.tbCiutat.Name = "tbCiutat";
            this.tbCiutat.Size = new System.Drawing.Size(226, 26);
            this.tbCiutat.TabIndex = 17;
            // 
            // btnDesar
            // 
            this.btnDesar.Location = new System.Drawing.Point(129, 345);
            this.btnDesar.Name = "btnDesar";
            this.btnDesar.Size = new System.Drawing.Size(121, 56);
            this.btnDesar.TabIndex = 18;
            this.btnDesar.Text = "Desar";
            this.btnDesar.UseVisualStyleBackColor = true;
            this.btnDesar.Click += new System.EventHandler(this.btnDesar_Click);
            // 
            // frmOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 432);
            this.Controls.Add(this.btnDesar);
            this.Controls.Add(this.tbCiutat);
            this.Controls.Add(this.tbTelf);
            this.Controls.Add(this.tbAdress1);
            this.Controls.Add(this.tbAddress2);
            this.Controls.Add(this.tbState);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.tbCp);
            this.Controls.Add(this.tbTerritori);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCodi);
            this.Controls.Add(this.label1);
            this.Name = "frmOffice";
            this.Text = "frmOffice";
            this.Load += new System.EventHandler(this.frmOffice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTerritori;
        private System.Windows.Forms.TextBox tbCp;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbAddress2;
        private System.Windows.Forms.TextBox tbAdress1;
        private System.Windows.Forms.TextBox tbTelf;
        private System.Windows.Forms.TextBox tbCiutat;
        private System.Windows.Forms.Button btnDesar;
        private dsClassicModelsTableAdapters.officesTableAdapter officesTableAdapter1;
    }
}