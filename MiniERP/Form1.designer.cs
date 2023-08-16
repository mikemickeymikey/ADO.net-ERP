
namespace MiniERP
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arxiuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestióToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arxiuToolStripMenuItem,
            this.gestióToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arxiuToolStripMenuItem
            // 
            this.arxiuToolStripMenuItem.Name = "arxiuToolStripMenuItem";
            this.arxiuToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.arxiuToolStripMenuItem.Text = "Arxiu";
            // 
            // gestióToolStripMenuItem
            // 
            this.gestióToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productesToolStripMenuItem,
            this.empleatsToolStripMenuItem,
            this.officesToolStripMenuItem});
            this.gestióToolStripMenuItem.Name = "gestióToolStripMenuItem";
            this.gestióToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.gestióToolStripMenuItem.Text = "Gestió";
            this.gestióToolStripMenuItem.Click += new System.EventHandler(this.gestióToolStripMenuItem_Click);
            // 
            // productesToolStripMenuItem
            // 
            this.productesToolStripMenuItem.Name = "productesToolStripMenuItem";
            this.productesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.productesToolStripMenuItem.Text = "Productes";
            this.productesToolStripMenuItem.Click += new System.EventHandler(this.productesToolStripMenuItem_Click);
            // 
            // empleatsToolStripMenuItem
            // 
            this.empleatsToolStripMenuItem.Name = "empleatsToolStripMenuItem";
            this.empleatsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.empleatsToolStripMenuItem.Text = "Empleats";
            this.empleatsToolStripMenuItem.Click += new System.EventHandler(this.empleatsToolStripMenuItem_Click);
            // 
            // officesToolStripMenuItem
            // 
            this.officesToolStripMenuItem.Name = "officesToolStripMenuItem";
            this.officesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.officesToolStripMenuItem.Text = "Offices";
            this.officesToolStripMenuItem.Click += new System.EventHandler(this.officesToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "MINI ERP";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arxiuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestióToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officesToolStripMenuItem;
    }
}

