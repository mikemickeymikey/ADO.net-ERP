
namespace MiniERP
{
    partial class frmArticles
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
            this.components = new System.ComponentModel.Container();
            this.cmbProductLines = new System.Windows.Forms.ComboBox();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.txtDescripcio = new System.Windows.Forms.TextBox();
            this.txtCodi = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.productsTableAdapter1 = new MiniERP.dsClassicModelsTableAdapters.productsTableAdapter();
            this.productlinesTableAdapter1 = new MiniERP.dsClassicModelsTableAdapters.productlinesTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dsClassicModels = new MiniERP.dsClassicModels();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new MiniERP.dsClassicModelsTableAdapters.ordersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.orderdetailsibfk1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderdetailsTableAdapter = new MiniERP.dsClassicModelsTableAdapters.orderdetailsTableAdapter();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.orderdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderdetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClassicModels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailsibfk1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProductLines
            // 
            this.cmbProductLines.FormattingEnabled = true;
            this.cmbProductLines.Location = new System.Drawing.Point(58, 38);
            this.cmbProductLines.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProductLines.Name = "cmbProductLines";
            this.cmbProductLines.Size = new System.Drawing.Size(282, 28);
            this.cmbProductLines.TabIndex = 0;
            this.cmbProductLines.SelectedIndexChanged += new System.EventHandler(this.cmbProductLines_SelectedIndexChanged);
            // 
            // dgvArticles
            // 
            this.dgvArticles.AllowUserToAddRows = false;
            this.dgvArticles.AllowUserToDeleteRows = false;
            this.dgvArticles.AllowUserToResizeColumns = false;
            this.dgvArticles.AllowUserToResizeRows = false;
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.Location = new System.Drawing.Point(58, 100);
            this.dgvArticles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.ReadOnly = true;
            this.dgvArticles.RowHeadersWidth = 62;
            this.dgvArticles.ShowEditingIcon = false;
            this.dgvArticles.Size = new System.Drawing.Size(1228, 231);
            this.dgvArticles.TabIndex = 1;
            this.dgvArticles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticles_CellClick);
            this.dgvArticles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticles_CellContentClick);
            this.dgvArticles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticles_RowEnter);
            this.dgvArticles.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvArticles_RowPrePaint);
            this.dgvArticles.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticles_RowValidated);
            this.dgvArticles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvArticles_KeyPress);
            this.dgvArticles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvArticles_MouseDoubleClick);
            this.dgvArticles.MouseHover += new System.EventHandler(this.dgvArticles_MouseHover);
            // 
            // txtDescripcio
            // 
            this.txtDescripcio.Location = new System.Drawing.Point(432, 383);
            this.txtDescripcio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcio.Multiline = true;
            this.txtDescripcio.Name = "txtDescripcio";
            this.txtDescripcio.Size = new System.Drawing.Size(853, 92);
            this.txtDescripcio.TabIndex = 2;
            // 
            // txtCodi
            // 
            this.txtCodi.Location = new System.Drawing.Point(212, 383);
            this.txtCodi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodi.Name = "txtCodi";
            this.txtCodi.Size = new System.Drawing.Size(190, 26);
            this.txtCodi.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(212, 446);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(190, 26);
            this.txtNom.TabIndex = 4;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(38, 388);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(163, 20);
            this.lblCurrent.TabIndex = 5;
            this.lblCurrent.Text = "Article Seleccionat -->";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(1296, 263);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 68);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "+";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // productlinesTableAdapter1
            // 
            this.productlinesTableAdapter1.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1296, 185);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 68);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "-";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dsClassicModels
            // 
            this.dsClassicModels.DataSetName = "dsClassicModels";
            this.dsClassicModels.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.dsClassicModels;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Orders:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // orderdetailsibfk1BindingSource
            // 
            this.orderdetailsibfk1BindingSource.DataMember = "orderdetails_ibfk_1";
            this.orderdetailsibfk1BindingSource.DataSource = this.ordersBindingSource;
            // 
            // orderdetailsTableAdapter
            // 
            this.orderdetailsTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "orders";
            this.ordersBindingSource1.DataSource = this.dsClassicModels;
            // 
            // ordersBindingSource2
            // 
            this.ordersBindingSource2.DataMember = "orders";
            this.ordersBindingSource2.DataSource = this.dsClassicModels;
            // 
            // orderdetailsBindingSource
            // 
            this.orderdetailsBindingSource.DataMember = "orderdetails";
            this.orderdetailsBindingSource.DataSource = this.dsClassicModels;
            // 
            // orderdetailsBindingSource1
            // 
            this.orderdetailsBindingSource1.DataMember = "orderdetails";
            this.orderdetailsBindingSource1.DataSource = this.dsClassicModels;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(58, 541);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 62;
            this.dgvOrders.RowTemplate.Height = 28;
            this.dgvOrders.Size = new System.Drawing.Size(1228, 349);
            this.dgvOrders.TabIndex = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(371, 38);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 42);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 902);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtCodi);
            this.Controls.Add(this.txtDescripcio);
            this.Controls.Add(this.dgvArticles);
            this.Controls.Add(this.cmbProductLines);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmArticles";
            this.Text = "ARTICLES";
            this.Load += new System.EventHandler(this.frmArticles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClassicModels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailsibfk1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProductLines;
        private System.Windows.Forms.DataGridView dgvArticles;
        private dsClassicModelsTableAdapters.productsTableAdapter productsTableAdapter1;
        private dsClassicModelsTableAdapters.productlinesTableAdapter productlinesTableAdapter1;
        private System.Windows.Forms.TextBox txtDescripcio;
        private System.Windows.Forms.TextBox txtCodi;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private dsClassicModels dsClassicModels;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private dsClassicModelsTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource orderdetailsibfk1BindingSource;
        private dsClassicModelsTableAdapters.orderdetailsTableAdapter orderdetailsTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private System.Windows.Forms.BindingSource ordersBindingSource2;
        private System.Windows.Forms.BindingSource orderdetailsBindingSource;
        private System.Windows.Forms.BindingSource orderdetailsBindingSource1;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnRefresh;
    }
}