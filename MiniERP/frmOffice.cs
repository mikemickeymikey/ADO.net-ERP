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
    public partial class frmOffice : Form
    {
        DataGridViewRow filaModificada;
        dsClassicModels ds;
        public frmOffice(dsClassicModels ds, DataGridViewRow fila)
        {
            InitializeComponent();
            this.ds = ds;
            filaModificada = fila;
            tbCodi.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbCodi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDesar_Click(object sender, EventArgs e)
        {
            try
            {
                if (filaModificada == null)
                {
                    DataRow novaFila = ds.products.NewRow();
                    novaFila["officeCode "] = tbCodi.Text;
                    novaFila["city"] = tbCiutat.Text;
                    novaFila["phone"] = tbTelf.Text;
                    novaFila["addressLine1"] = tbAdress1.Text;
                    novaFila["addressLine2"] = tbAddress2.Text;
                    novaFila["state"] = tbState.Text;
                    novaFila["country"] = tbCountry.Text;
                    novaFila["postalCode"] = tbCp.Text;
                    novaFila["territory"] = tbTerritori.Text;
                    ds.products.AddproductsRow((dsClassicModels.productsRow)novaFila);
                    DialogResult dialogResult = MessageBox.Show("Segur que vols guardar?", "Guardar", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Dades guardades.");
                        officesTableAdapter1.Update(novaFila);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Dades no guardades.");
                    }

                }
                else
                {
                    DataRow filaUpdate = ds.Tables["offices"].Select("productcode = '" + tbCodi.Text + "'")[0];
                    filaUpdate.BeginEdit();
                    filaUpdate["officeCode"] = tbCodi.Text;
                    filaUpdate["city"] = tbCiutat.Text;
                    filaUpdate["phone"] = tbTelf.Text;
                    filaUpdate["addressLine1"] = tbAdress1.Text;
                    filaUpdate["addressLine2"] = tbAddress2.Text;
                    filaUpdate["state"] = tbState.Text;
                    filaUpdate["country"] = tbCountry.Text;
                    filaUpdate["postalCode"] = tbCp.Text;
                    filaUpdate["territory"] = tbTerritori.Text;
                    filaUpdate.EndEdit();
                    DialogResult dialogResult = MessageBox.Show("Segur que vols guardar?", "Guardar", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        officesTableAdapter1.Update(ds.offices);
                        MessageBox.Show("Dades guardades.");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Dades no guardades.");
                    }
                }
            }
            catch (Exception) { MessageBox.Show("No s'han pogut guardar les dades.", "Error"); }
        }

        private void frmOffice_Load(object sender, EventArgs e)
        {
            if (filaModificada != null)
            {
                tbCodi.Text = filaModificada.Cells["officeCode"].Value.ToString();
                tbCiutat.Text = filaModificada.Cells["city"].Value.ToString();
                tbTelf.Text = filaModificada.Cells["phone"].Value.ToString();
                tbAdress1.Text = filaModificada.Cells["addressLine1"].Value.ToString();
                tbAddress2.Text = filaModificada.Cells["addressLine2"].Value.ToString();
                tbState.Text = filaModificada.Cells["state"].Value.ToString();
                tbCountry.Text = filaModificada.Cells["country"].Value.ToString();
                tbCp.Text = filaModificada.Cells["postalCode"].Value.ToString();
                tbTerritori.Text = filaModificada.Cells["territory"].Value.ToString();
            }
            /*try
            {
                if (filaModificada != null)
                {
                    tbCodi.Text = filaModificada.Cells["officeCode"].Value.ToString();
                    tbCiutat.Text = filaModificada.Cells["city"].Value.ToString();
                    tbTelf.Text = filaModificada.Cells["phone"].Value.ToString();
                    tbAdress1.Text = filaModificada.Cells["addressLine1"].Value.ToString();
                    tbAddress2.Text = filaModificada.Cells["addressLine2"].Value.ToString();
                    tbState.Text = filaModificada.Cells["state"].Value.ToString();
                    tbCountry.Text = filaModificada.Cells["country"].Value.ToString();
                    tbCp.Text = filaModificada.Cells["postalCode"].Value.ToString();
                    tbTerritori.Text = filaModificada.Cells["territory"].Value.ToString();
                }
            }
            catch (Exception) { MessageBox.Show("No funciona."); }*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
