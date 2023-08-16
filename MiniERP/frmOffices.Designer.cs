
namespace MiniERP
{
    partial class frmOffices
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
            this.btnEstatActual = new System.Windows.Forms.Button();
            this.btnEstatInicial = new System.Windows.Forms.Button();
            this.btnDesar = new System.Windows.Forms.Button();
            this.dgvOffices = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnModificades = new System.Windows.Forms.Button();
            this.btnEliminades = new System.Windows.Forms.Button();
            this.btnAfegides = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.officeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.territoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClassicModels = new MiniERP.dsClassicModels();
            this.officesTableAdapter = new MiniERP.dsClassicModelsTableAdapters.officesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClassicModels)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEstatActual
            // 
            this.btnEstatActual.Location = new System.Drawing.Point(43, 48);
            this.btnEstatActual.Name = "btnEstatActual";
            this.btnEstatActual.Size = new System.Drawing.Size(136, 56);
            this.btnEstatActual.TabIndex = 0;
            this.btnEstatActual.Text = "Estat actual";
            this.btnEstatActual.UseVisualStyleBackColor = true;
            this.btnEstatActual.Click += new System.EventHandler(this.btnEstatActual_Click);
            // 
            // btnEstatInicial
            // 
            this.btnEstatInicial.Location = new System.Drawing.Point(43, 110);
            this.btnEstatInicial.Name = "btnEstatInicial";
            this.btnEstatInicial.Size = new System.Drawing.Size(136, 56);
            this.btnEstatInicial.TabIndex = 1;
            this.btnEstatInicial.Text = "Estat inicial";
            this.btnEstatInicial.UseVisualStyleBackColor = true;
            this.btnEstatInicial.Click += new System.EventHandler(this.btnEstatInicial_Click);
            // 
            // btnDesar
            // 
            this.btnDesar.Location = new System.Drawing.Point(43, 172);
            this.btnDesar.Name = "btnDesar";
            this.btnDesar.Size = new System.Drawing.Size(136, 56);
            this.btnDesar.TabIndex = 2;
            this.btnDesar.Text = "Desar canvis";
            this.btnDesar.UseVisualStyleBackColor = true;
            this.btnDesar.Click += new System.EventHandler(this.btnDesar_Click);
            // 
            // dgvOffices
            // 
            this.dgvOffices.AutoGenerateColumns = false;
            this.dgvOffices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOffices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.officeCodeDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressLine1DataGridViewTextBoxColumn,
            this.addressLine2DataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.territoryDataGridViewTextBoxColumn});
            this.dgvOffices.DataSource = this.officesBindingSource;
            this.dgvOffices.Location = new System.Drawing.Point(220, 48);
            this.dgvOffices.Name = "dgvOffices";
            this.dgvOffices.RowHeadersWidth = 62;
            this.dgvOffices.RowTemplate.Height = 28;
            this.dgvOffices.Size = new System.Drawing.Size(1261, 776);
            this.dgvOffices.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(43, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 124);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(43, 700);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 124);
            this.button2.TabIndex = 5;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModificades
            // 
            this.btnModificades.Location = new System.Drawing.Point(43, 358);
            this.btnModificades.Name = "btnModificades";
            this.btnModificades.Size = new System.Drawing.Size(136, 56);
            this.btnModificades.TabIndex = 6;
            this.btnModificades.Text = "Modificades";
            this.btnModificades.UseVisualStyleBackColor = true;
            this.btnModificades.Click += new System.EventHandler(this.btnModificades_Click);
            // 
            // btnEliminades
            // 
            this.btnEliminades.Location = new System.Drawing.Point(43, 296);
            this.btnEliminades.Name = "btnEliminades";
            this.btnEliminades.Size = new System.Drawing.Size(136, 56);
            this.btnEliminades.TabIndex = 7;
            this.btnEliminades.Text = "Eliminades";
            this.btnEliminades.UseVisualStyleBackColor = true;
            this.btnEliminades.Click += new System.EventHandler(this.btnEliminades_Click);
            // 
            // btnAfegides
            // 
            this.btnAfegides.Location = new System.Drawing.Point(43, 234);
            this.btnAfegides.Name = "btnAfegides";
            this.btnAfegides.Size = new System.Drawing.Size(136, 56);
            this.btnAfegides.TabIndex = 8;
            this.btnAfegides.Text = "Afegides";
            this.btnAfegides.UseVisualStyleBackColor = true;
            this.btnAfegides.Click += new System.EventHandler(this.btnAfegides_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(43, 420);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(136, 56);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar fila";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // officeCodeDataGridViewTextBoxColumn
            // 
            this.officeCodeDataGridViewTextBoxColumn.DataPropertyName = "officeCode";
            this.officeCodeDataGridViewTextBoxColumn.HeaderText = "officeCode";
            this.officeCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.officeCodeDataGridViewTextBoxColumn.Name = "officeCodeDataGridViewTextBoxColumn";
            this.officeCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressLine1DataGridViewTextBoxColumn
            // 
            this.addressLine1DataGridViewTextBoxColumn.DataPropertyName = "addressLine1";
            this.addressLine1DataGridViewTextBoxColumn.HeaderText = "addressLine1";
            this.addressLine1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressLine1DataGridViewTextBoxColumn.Name = "addressLine1DataGridViewTextBoxColumn";
            this.addressLine1DataGridViewTextBoxColumn.Width = 150;
            // 
            // addressLine2DataGridViewTextBoxColumn
            // 
            this.addressLine2DataGridViewTextBoxColumn.DataPropertyName = "addressLine2";
            this.addressLine2DataGridViewTextBoxColumn.HeaderText = "addressLine2";
            this.addressLine2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressLine2DataGridViewTextBoxColumn.Name = "addressLine2DataGridViewTextBoxColumn";
            this.addressLine2DataGridViewTextBoxColumn.Width = 150;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.Width = 150;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.Width = 150;
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "postalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "postalCode";
            this.postalCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            this.postalCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // territoryDataGridViewTextBoxColumn
            // 
            this.territoryDataGridViewTextBoxColumn.DataPropertyName = "territory";
            this.territoryDataGridViewTextBoxColumn.HeaderText = "territory";
            this.territoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.territoryDataGridViewTextBoxColumn.Name = "territoryDataGridViewTextBoxColumn";
            this.territoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // officesBindingSource
            // 
            this.officesBindingSource.DataMember = "offices";
            this.officesBindingSource.DataSource = this.dsClassicModels;
            // 
            // dsClassicModels
            // 
            this.dsClassicModels.DataSetName = "dsClassicModels";
            this.dsClassicModels.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // officesTableAdapter
            // 
            this.officesTableAdapter.ClearBeforeFill = true;
            // 
            // frmOffices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 861);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAfegides);
            this.Controls.Add(this.btnEliminades);
            this.Controls.Add(this.btnModificades);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvOffices);
            this.Controls.Add(this.btnDesar);
            this.Controls.Add(this.btnEstatInicial);
            this.Controls.Add(this.btnEstatActual);
            this.Name = "frmOffices";
            this.Text = "frmOffices";
            this.Load += new System.EventHandler(this.frmOffices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClassicModels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstatActual;
        private System.Windows.Forms.Button btnEstatInicial;
        private System.Windows.Forms.Button btnDesar;
        private System.Windows.Forms.DataGridView dgvOffices;
        private dsClassicModels dsClassicModels;
        private System.Windows.Forms.BindingSource officesBindingSource;
        private dsClassicModelsTableAdapters.officesTableAdapter officesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn territoryDataGridViewTextBoxColumn;
        private dsClassicModelsTableAdapters.officesTableAdapter officesTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnModificades;
        private System.Windows.Forms.Button btnEliminades;
        private System.Windows.Forms.Button btnAfegides;
        private System.Windows.Forms.Button btnEditar;
    }
}