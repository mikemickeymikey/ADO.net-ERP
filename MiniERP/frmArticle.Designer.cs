
namespace MiniERP
{
    partial class frmArticle
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
            System.Windows.Forms.Label productCodeLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label productLineLabel;
            System.Windows.Forms.Label productScaleLabel;
            System.Windows.Forms.Label productVendorLabel;
            System.Windows.Forms.Label productDescriptionLabel;
            System.Windows.Forms.Label quantityInStockLabel;
            System.Windows.Forms.Label buyPriceLabel;
            System.Windows.Forms.Label mSRPLabel;
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productLineTextBox = new System.Windows.Forms.TextBox();
            this.productScaleTextBox = new System.Windows.Forms.TextBox();
            this.productVendorTextBox = new System.Windows.Forms.TextBox();
            this.productDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.quantityInStockTextBox = new System.Windows.Forms.TextBox();
            this.buyPriceTextBox = new System.Windows.Forms.TextBox();
            this.mSRPTextBox = new System.Windows.Forms.TextBox();
            this.productsTableAdapter1 = new MiniERP.dsClassicModelsTableAdapters.productsTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            productCodeLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            productLineLabel = new System.Windows.Forms.Label();
            productScaleLabel = new System.Windows.Forms.Label();
            productVendorLabel = new System.Windows.Forms.Label();
            productDescriptionLabel = new System.Windows.Forms.Label();
            quantityInStockLabel = new System.Windows.Forms.Label();
            buyPriceLabel = new System.Windows.Forms.Label();
            mSRPLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productCodeLabel
            // 
            productCodeLabel.AutoSize = true;
            productCodeLabel.Location = new System.Drawing.Point(258, 166);
            productCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productCodeLabel.Name = "productCodeLabel";
            productCodeLabel.Size = new System.Drawing.Size(109, 20);
            productCodeLabel.TabIndex = 1;
            productCodeLabel.Text = "product Code:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(258, 206);
            productNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(113, 20);
            productNameLabel.TabIndex = 3;
            productNameLabel.Text = "product Name:";
            // 
            // productLineLabel
            // 
            productLineLabel.AutoSize = true;
            productLineLabel.Location = new System.Drawing.Point(70, 42);
            productLineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productLineLabel.Name = "productLineLabel";
            productLineLabel.Size = new System.Drawing.Size(101, 20);
            productLineLabel.TabIndex = 5;
            productLineLabel.Text = "product Line:";
            // 
            // productScaleLabel
            // 
            productScaleLabel.AutoSize = true;
            productScaleLabel.Location = new System.Drawing.Point(258, 286);
            productScaleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productScaleLabel.Name = "productScaleLabel";
            productScaleLabel.Size = new System.Drawing.Size(111, 20);
            productScaleLabel.TabIndex = 7;
            productScaleLabel.Text = "product Scale:";
            // 
            // productVendorLabel
            // 
            productVendorLabel.AutoSize = true;
            productVendorLabel.Location = new System.Drawing.Point(258, 326);
            productVendorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productVendorLabel.Name = "productVendorLabel";
            productVendorLabel.Size = new System.Drawing.Size(123, 20);
            productVendorLabel.TabIndex = 9;
            productVendorLabel.Text = "product Vendor:";
            // 
            // productDescriptionLabel
            // 
            productDescriptionLabel.AutoSize = true;
            productDescriptionLabel.Location = new System.Drawing.Point(258, 366);
            productDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productDescriptionLabel.Name = "productDescriptionLabel";
            productDescriptionLabel.Size = new System.Drawing.Size(151, 20);
            productDescriptionLabel.TabIndex = 11;
            productDescriptionLabel.Text = "product Description:";
            // 
            // quantityInStockLabel
            // 
            quantityInStockLabel.AutoSize = true;
            quantityInStockLabel.Location = new System.Drawing.Point(258, 488);
            quantityInStockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            quantityInStockLabel.Name = "quantityInStockLabel";
            quantityInStockLabel.Size = new System.Drawing.Size(132, 20);
            quantityInStockLabel.TabIndex = 13;
            quantityInStockLabel.Text = "quantity In Stock:";
            // 
            // buyPriceLabel
            // 
            buyPriceLabel.AutoSize = true;
            buyPriceLabel.Location = new System.Drawing.Point(258, 528);
            buyPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            buyPriceLabel.Name = "buyPriceLabel";
            buyPriceLabel.Size = new System.Drawing.Size(77, 20);
            buyPriceLabel.TabIndex = 15;
            buyPriceLabel.Text = "buy Price:";
            // 
            // mSRPLabel
            // 
            mSRPLabel.AutoSize = true;
            mSRPLabel.Location = new System.Drawing.Point(258, 568);
            mSRPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mSRPLabel.Name = "mSRPLabel";
            mSRPLabel.Size = new System.Drawing.Size(59, 20);
            mSRPLabel.TabIndex = 17;
            mSRPLabel.Text = "MSRP:";
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.Location = new System.Drawing.Point(420, 162);
            this.productCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(148, 26);
            this.productCodeTextBox.TabIndex = 2;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(420, 202);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(148, 26);
            this.productNameTextBox.TabIndex = 4;
            // 
            // productLineTextBox
            // 
            this.productLineTextBox.Location = new System.Drawing.Point(232, 37);
            this.productLineTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productLineTextBox.Name = "productLineTextBox";
            this.productLineTextBox.Size = new System.Drawing.Size(148, 26);
            this.productLineTextBox.TabIndex = 6;
            // 
            // productScaleTextBox
            // 
            this.productScaleTextBox.Location = new System.Drawing.Point(420, 282);
            this.productScaleTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productScaleTextBox.Name = "productScaleTextBox";
            this.productScaleTextBox.Size = new System.Drawing.Size(148, 26);
            this.productScaleTextBox.TabIndex = 8;
            this.productScaleTextBox.TextChanged += new System.EventHandler(this.productScaleTextBox_TextChanged);
            // 
            // productVendorTextBox
            // 
            this.productVendorTextBox.Location = new System.Drawing.Point(420, 322);
            this.productVendorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productVendorTextBox.Name = "productVendorTextBox";
            this.productVendorTextBox.Size = new System.Drawing.Size(374, 26);
            this.productVendorTextBox.TabIndex = 10;
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.Location = new System.Drawing.Point(420, 362);
            this.productDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productDescriptionTextBox.Multiline = true;
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(374, 110);
            this.productDescriptionTextBox.TabIndex = 12;
            // 
            // quantityInStockTextBox
            // 
            this.quantityInStockTextBox.Location = new System.Drawing.Point(420, 483);
            this.quantityInStockTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantityInStockTextBox.Name = "quantityInStockTextBox";
            this.quantityInStockTextBox.Size = new System.Drawing.Size(148, 26);
            this.quantityInStockTextBox.TabIndex = 14;
            this.quantityInStockTextBox.TextChanged += new System.EventHandler(this.quantityInStockTextBox_TextChanged);
            // 
            // buyPriceTextBox
            // 
            this.buyPriceTextBox.Location = new System.Drawing.Point(420, 523);
            this.buyPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buyPriceTextBox.Name = "buyPriceTextBox";
            this.buyPriceTextBox.Size = new System.Drawing.Size(148, 26);
            this.buyPriceTextBox.TabIndex = 16;
            this.buyPriceTextBox.TextChanged += new System.EventHandler(this.buyPriceTextBox_TextChanged);
            // 
            // mSRPTextBox
            // 
            this.mSRPTextBox.Location = new System.Drawing.Point(420, 563);
            this.mSRPTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mSRPTextBox.Name = "mSRPTextBox";
            this.mSRPTextBox.Size = new System.Drawing.Size(148, 26);
            this.mSRPTextBox.TabIndex = 18;
            this.mSRPTextBox.TextChanged += new System.EventHandler(this.mSRPTextBox_TextChanged);
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(684, 162);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "DESAR";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(productCodeLabel);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(productLineLabel);
            this.Controls.Add(this.productLineTextBox);
            this.Controls.Add(productScaleLabel);
            this.Controls.Add(this.productScaleTextBox);
            this.Controls.Add(productVendorLabel);
            this.Controls.Add(this.productVendorTextBox);
            this.Controls.Add(productDescriptionLabel);
            this.Controls.Add(this.productDescriptionTextBox);
            this.Controls.Add(quantityInStockLabel);
            this.Controls.Add(this.quantityInStockTextBox);
            this.Controls.Add(buyPriceLabel);
            this.Controls.Add(this.buyPriceTextBox);
            this.Controls.Add(mSRPLabel);
            this.Controls.Add(this.mSRPTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmArticle";
            this.Text = "iguel";
            this.Load += new System.EventHandler(this.frmArticle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productLineTextBox;
        private System.Windows.Forms.TextBox productScaleTextBox;
        private System.Windows.Forms.TextBox productVendorTextBox;
        private System.Windows.Forms.TextBox productDescriptionTextBox;
        private System.Windows.Forms.TextBox quantityInStockTextBox;
        private System.Windows.Forms.TextBox buyPriceTextBox;
        private System.Windows.Forms.TextBox mSRPTextBox;
        private dsClassicModelsTableAdapters.productsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.Button btnSave;
    }
}