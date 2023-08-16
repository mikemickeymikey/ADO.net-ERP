
namespace MiniERP
{
    partial class frmEmpleats
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
            this.btnFiltraNom = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.btnFiltraOficina = new System.Windows.Forms.Button();
            this.cmbOficines = new System.Windows.Forms.ComboBox();
            this.btnEliminarFiltres = new System.Windows.Forms.Button();
            this.btnOrdenarCognom = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClassicModels = new MiniERP.dsClassicModels();
            this.employeesTableAdapter = new MiniERP.dsClassicModelsTableAdapters.employeesTableAdapter();
            this.officesTableAdapter = new MiniERP.dsClassicModelsTableAdapters.officesTableAdapter();
            this.employeeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClassicModels)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltraNom
            // 
            this.btnFiltraNom.Location = new System.Drawing.Point(12, 11);
            this.btnFiltraNom.Name = "btnFiltraNom";
            this.btnFiltraNom.Size = new System.Drawing.Size(185, 71);
            this.btnFiltraNom.TabIndex = 0;
            this.btnFiltraNom.Text = "Filtra per nom o cognom";
            this.btnFiltraNom.UseVisualStyleBackColor = true;
            this.btnFiltraNom.Click += new System.EventHandler(this.btnFiltraNom_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(12, 88);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(267, 26);
            this.tbNom.TabIndex = 1;
            // 
            // btnFiltraOficina
            // 
            this.btnFiltraOficina.Location = new System.Drawing.Point(12, 130);
            this.btnFiltraOficina.Name = "btnFiltraOficina";
            this.btnFiltraOficina.Size = new System.Drawing.Size(185, 71);
            this.btnFiltraOficina.TabIndex = 2;
            this.btnFiltraOficina.Text = "Filtra per oficina";
            this.btnFiltraOficina.UseVisualStyleBackColor = true;
            this.btnFiltraOficina.Click += new System.EventHandler(this.btnFiltraOficina_Click);
            // 
            // cmbOficines
            // 
            this.cmbOficines.FormattingEnabled = true;
            this.cmbOficines.Location = new System.Drawing.Point(12, 207);
            this.cmbOficines.Name = "cmbOficines";
            this.cmbOficines.Size = new System.Drawing.Size(267, 28);
            this.cmbOficines.TabIndex = 3;
            // 
            // btnEliminarFiltres
            // 
            this.btnEliminarFiltres.Location = new System.Drawing.Point(12, 250);
            this.btnEliminarFiltres.Name = "btnEliminarFiltres";
            this.btnEliminarFiltres.Size = new System.Drawing.Size(185, 71);
            this.btnEliminarFiltres.TabIndex = 4;
            this.btnEliminarFiltres.Text = "Eliminar filtres";
            this.btnEliminarFiltres.UseVisualStyleBackColor = true;
            this.btnEliminarFiltres.Click += new System.EventHandler(this.btnEliminarFiltres_Click);
            // 
            // btnOrdenarCognom
            // 
            this.btnOrdenarCognom.Location = new System.Drawing.Point(12, 327);
            this.btnOrdenarCognom.Name = "btnOrdenarCognom";
            this.btnOrdenarCognom.Size = new System.Drawing.Size(185, 71);
            this.btnOrdenarCognom.TabIndex = 5;
            this.btnOrdenarCognom.Text = "Ordenar per cognom";
            this.btnOrdenarCognom.UseVisualStyleBackColor = true;
            this.btnOrdenarCognom.Click += new System.EventHandler(this.btnOrdenarCognom_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoGenerateColumns = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeNumberDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.extensionDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.jobTitleDataGridViewTextBoxColumn,
            this.officeCode});
            this.dgvEmployees.DataSource = this.employeesBindingSource;
            this.dgvEmployees.Location = new System.Drawing.Point(303, 12);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidth = 62;
            this.dgvEmployees.RowTemplate.Height = 28;
            this.dgvEmployees.Size = new System.Drawing.Size(976, 740);
            this.dgvEmployees.TabIndex = 6;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.dsClassicModels;
            // 
            // dsClassicModels
            // 
            this.dsClassicModels.DataSetName = "dsClassicModels";
            this.dsClassicModels.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // officesTableAdapter
            // 
            this.officesTableAdapter.ClearBeforeFill = true;
            // 
            // employeeNumberDataGridViewTextBoxColumn
            // 
            this.employeeNumberDataGridViewTextBoxColumn.DataPropertyName = "employeeNumber";
            this.employeeNumberDataGridViewTextBoxColumn.HeaderText = "employeeNumber";
            this.employeeNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.employeeNumberDataGridViewTextBoxColumn.Name = "employeeNumberDataGridViewTextBoxColumn";
            this.employeeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // extensionDataGridViewTextBoxColumn
            // 
            this.extensionDataGridViewTextBoxColumn.DataPropertyName = "extension";
            this.extensionDataGridViewTextBoxColumn.HeaderText = "extension";
            this.extensionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.extensionDataGridViewTextBoxColumn.Name = "extensionDataGridViewTextBoxColumn";
            this.extensionDataGridViewTextBoxColumn.ReadOnly = true;
            this.extensionDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // jobTitleDataGridViewTextBoxColumn
            // 
            this.jobTitleDataGridViewTextBoxColumn.DataPropertyName = "jobTitle";
            this.jobTitleDataGridViewTextBoxColumn.HeaderText = "jobTitle";
            this.jobTitleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
            this.jobTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobTitleDataGridViewTextBoxColumn.Width = 150;
            // 
            // officeCode
            // 
            this.officeCode.DataPropertyName = "officeCode";
            this.officeCode.HeaderText = "officeCode";
            this.officeCode.MinimumWidth = 8;
            this.officeCode.Name = "officeCode";
            this.officeCode.ReadOnly = true;
            this.officeCode.Visible = false;
            this.officeCode.Width = 150;
            // 
            // frmEmpleats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 776);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnOrdenarCognom);
            this.Controls.Add(this.btnEliminarFiltres);
            this.Controls.Add(this.cmbOficines);
            this.Controls.Add(this.btnFiltraOficina);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.btnFiltraNom);
            this.Name = "frmEmpleats";
            this.Text = "frmEmpleats";
            this.Load += new System.EventHandler(this.frmEmpleats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClassicModels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltraNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button btnFiltraOficina;
        private System.Windows.Forms.ComboBox cmbOficines;
        private System.Windows.Forms.Button btnEliminarFiltres;
        private System.Windows.Forms.Button btnOrdenarCognom;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private dsClassicModels dsClassicModels;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private dsClassicModelsTableAdapters.employeesTableAdapter employeesTableAdapter;
        private dsClassicModelsTableAdapters.officesTableAdapter officesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeCode;
    }
}