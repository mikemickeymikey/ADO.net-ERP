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
    public partial class frmArticle : Form
    {
        dsClassicModels ds;
        String currentProductLine;
        DataGridViewRow filaModificada;
        public frmArticle(dsClassicModels ds , string pLine ,  DataGridViewRow fila)
        {
            InitializeComponent();
            currentProductLine = pLine;
            this.ds = ds;
            filaModificada = fila;
            productCodeTextBox.ReadOnly = true;
            productLineTextBox.ReadOnly = true;
        }

        private void frmArticle_Load(object sender, EventArgs e)
        {
            productLineTextBox.Text = currentProductLine;
            if (filaModificada!=null)
            {
                productDescriptionTextBox.Text = filaModificada.Cells["productdescription"].Value.ToString();
                productCodeTextBox.Text = filaModificada.Cells["productcode"].Value.ToString();
                productNameTextBox.Text = filaModificada.Cells["productname"].Value.ToString();
                productScaleTextBox.Text= filaModificada.Cells["productscale"].Value.ToString();
                productVendorTextBox.Text= filaModificada.Cells["productvendor"].Value.ToString();
                quantityInStockTextBox.Text= filaModificada.Cells["quantityinstock"].Value.ToString();
                buyPriceTextBox.Text = filaModificada.Cells["buyprice"].Value.ToString();
                mSRPTextBox.Text = filaModificada.Cells["msrp"].Value.ToString();
            }

        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string[] camps = productScaleTextBox.Text.Split(':');
                if (camps.Length != 2 || !Char.IsDigit(productScaleTextBox.Text[productScaleTextBox.Text.Length - 1]))
                {
                    MessageBox.Show("La escala del producte no és correcta. Torna a escriurela.");
                    productScaleTextBox.Text = "";
                }
                else
                {
                    if (filaModificada == null)
                    {
                        DataRow novaFila = ds.products.NewRow();
                        novaFila["productline"] = productLineTextBox.Text;
                        novaFila["productcode"] = productCodeTextBox.Text;
                        novaFila["productdescription"] = productDescriptionTextBox.Text;
                        novaFila["productname"] = productNameTextBox.Text;
                        novaFila["productvendor"] = productVendorTextBox.Text;
                        novaFila["productscale"] = productScaleTextBox.Text;
                        novaFila["quantityinstock"] = Convert.ToInt32(quantityInStockTextBox.Text);
                        novaFila["buyprice"] = Convert.ToDouble(buyPriceTextBox.Text);
                        novaFila["msrp"] = Convert.ToDouble(mSRPTextBox.Text);
                        ds.products.AddproductsRow((dsClassicModels.productsRow)novaFila);
                        DialogResult dialogResult = MessageBox.Show("Segur que vols guardar?", "Guardar", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            MessageBox.Show("Dades guardades.");
                            productsTableAdapter1.Update(novaFila);
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("Dades no guardades.");
                        }

                    }
                    else
                    {/*
                productsTableAdapter1.UpdateQuery(productNameTextBox.Text, productLineTextBox.Text, productScaleTextBox.Text
                    , productVendorTextBox.Text, productDescriptionTextBox.Text, Convert.ToInt16(quantityInStockTextBox.Text)
                    , Convert.ToDecimal(buyPriceTextBox.Text), Convert.ToDecimal(mSRPTextBox.Text), productCodeTextBox.Text);
                */
                        DataRow filaUpdate = ds.Tables["products"].Select("productcode = '" + productCodeTextBox.Text + "'")[0];
                        filaUpdate.BeginEdit();
                        filaUpdate["productdescription"] = productDescriptionTextBox.Text;
                        filaUpdate["productname"] = productNameTextBox.Text;
                        filaUpdate["productvendor"] = productVendorTextBox.Text;
                        filaUpdate["productscale"] = productScaleTextBox.Text;
                        filaUpdate["quantityinstock"] = Convert.ToInt32(quantityInStockTextBox.Text);
                        filaUpdate["buyprice"] = Convert.ToDouble(buyPriceTextBox.Text);
                        filaUpdate["msrp"] = Convert.ToDouble(mSRPTextBox.Text);
                        filaUpdate.EndEdit();
                        DialogResult dialogResult = MessageBox.Show("Segur que vols guardar?", "Guardar", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            productsTableAdapter1.Update(ds.products);
                            MessageBox.Show("Dades guardades.");
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("Dades no guardades.");
                        }
                    }

                }
            }
            catch(Exception) { MessageBox.Show("No s'han pogut guardar les dades.", "Error"); }
        }

        private void quantityInStockTextBox_TextChanged(object sender, EventArgs e)
        {
            int x;
            if(!int.TryParse(quantityInStockTextBox.Text, out x))
            {
                for (int i = 0; i < quantityInStockTextBox.Text.Length; i++)
                {
                    if (!Char.IsDigit(quantityInStockTextBox.Text[i])) quantityInStockTextBox.Text = quantityInStockTextBox.Text.Remove(i, 1);
                }
            }
        }

        private void buyPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!EsPreu(buyPriceTextBox))
            {
                for(int i = 0; i < buyPriceTextBox.Text.Length; i++)
                {
                    if (!Char.IsDigit(buyPriceTextBox.Text[i]) && !(buyPriceTextBox.Text[i] == ',')) buyPriceTextBox.Text = buyPriceTextBox.Text.Remove(i, 1);
                }
            }
        }

        private void mSRPTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!EsPreu(mSRPTextBox))
            {
                for (int i = 0; i < mSRPTextBox.Text.Length; i++)
                {
                    if (!Char.IsDigit(mSRPTextBox.Text[i]) && !(mSRPTextBox.Text[i] == ',')) mSRPTextBox.Text = mSRPTextBox.Text.Remove(i, 1);
                }
            }
        }

        private bool EsPreu(TextBox tb)
        {
            decimal d;
            if (!decimal.TryParse(tb.Text, out d))
            {
                return false;
            }
            else return true;
        }

        private void productScaleTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
