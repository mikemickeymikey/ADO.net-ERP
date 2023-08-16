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
    public partial class frmOffices : Form
    {
        dsClassicModels ds;
        DataTable dtActual = new DataTable();
        DataTable dtInicial = new DataTable();
        public frmOffices(dsClassicModels ds)
        {
            InitializeComponent();
            this.ds = ds;
        }

        private void frmOffices_Load(object sender, EventArgs e)
        {
            this.officesTableAdapter.Fill(this.dsClassicModels.offices);
            dtInicial = ds.offices.Clone();
            dtActual = ds.offices.Clone();
        }

        private void btnEstatActual_Click(object sender, EventArgs e)
        {
            dgvOffices.DataSource = dtActual;
        }

        private void btnEstatInicial_Click(object sender, EventArgs e)
        {
            dgvOffices.DataSource = dtInicial;
        }

        private void btnDesar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Segur que vols guardar?", "Guardar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var dataTable = (DataTable)dgvOffices.DataSource;
                    var changes = dataTable.GetChanges();
                    if (changes != null)
                    {
                        foreach (DataRow row in changes.Rows)
                        {
                            officesTableAdapter1.Update(row);
                        }
                        MessageBox.Show("S'han guardat les dades.", "Canvis persistents.");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Dades no guardades.");
                }
            }
            catch (Exception) { MessageBox.Show("No s'han pogut guardar les dades.", "Error"); }
        }

        //Afegir
        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Eliminar
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAfegides_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminades_Click(object sender, EventArgs e)
        {

        }

        private void btnModificades_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvOffices.CurrentRow != null)
            {
                DataGridViewRow filaAct = dgvOffices.CurrentRow;
                frmOffice fOffice = new frmOffice(ds, filaAct);
                fOffice.ShowDialog();
            }
        }
    }
}
