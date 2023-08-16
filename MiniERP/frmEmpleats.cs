using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP
{
    public partial class frmEmpleats : Form
    {
        dsClassicModels ds;
        public frmEmpleats(dsClassicModels ds)
        {
            InitializeComponent();
            this.ds = ds;
        }

        private void frmEmpleats_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsClassicModels.employees' Puede moverla o quitarla según sea necesario.
            this.employeesTableAdapter.Fill(this.dsClassicModels.employees);
            officesTableAdapter.Fill(ds.offices);
            cmbOficines.DataSource = ds.offices;
            cmbOficines.DisplayMember = "offices";
            cmbOficines.ValueMember = "city";
        }

        private void btnFiltraNom_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvEmployees.DataSource;
            bs.Filter += dgvEmployees.Columns[1].HeaderText.ToString() + " LIKE '%" + tbNom.Text + "%' OR " 
                + dgvEmployees.Columns[2].HeaderText.ToString() + " LIKE '%" + tbNom.Text + "%'";
            if (bs.Count == 0) MessageBox.Show("No s'han trobat resultats.");
            dgvEmployees.DataSource = bs;
        }

        private void btnFiltraOficina_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvEmployees.DataSource;
            bs.Filter += dgvEmployees.Columns[6].HeaderText.ToString() + " LIKE '" + (cmbOficines.SelectedIndex + 1) + "'";
            if (bs.Count == 0) MessageBox.Show("No s'han trobat resultats.");
            dgvEmployees.DataSource = bs;
        }

        private void btnEliminarFiltres_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvEmployees.DataSource;
            bs.Filter += dgvEmployees.Columns[1].HeaderText.ToString() + " LIKE '%%'";
            dgvEmployees.DataSource = bs;
            MessageBox.Show("Filtres eliminats");
        }

        private void btnOrdenarCognom_Click(object sender, EventArgs e)
        {
            dgvEmployees.Sort(dgvEmployees.Columns[1], ListSortDirection.Ascending);
        }

    }
}
