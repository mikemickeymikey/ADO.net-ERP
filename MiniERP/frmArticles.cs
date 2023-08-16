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
    public partial class frmArticles : Form
    {
        dsClassicModels ds;
        string codiArticle;
        public frmArticles(dsClassicModels ds)
        {
            InitializeComponent();
            this.ds = ds;
            txtDescripcio.ReadOnly = true;
            txtCodi.ReadOnly = true;
            txtNom.ReadOnly = true;
        }

        private void frmArticles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsClassicModels.orderdetails' Puede moverla o quitarla según sea necesario.
            this.orderdetailsTableAdapter.Fill(this.dsClassicModels.orderdetails);
            // TODO: esta línea de código carga datos en la tabla 'dsClassicModels.orders' Puede moverla o quitarla según sea necesario.
            this.ordersTableAdapter.Fill(this.dsClassicModels.orders);
            // TODO: esta línea de código carga datos en la tabla 'dsClassicModels.productlines' Puede moverla o quitarla según sea necesario.
            productlinesTableAdapter1.Fill(ds.productlines);
            
            cmbProductLines.DataSource = ds.productlines;
            cmbProductLines.DisplayMember = "productline";
            cmbProductLines.ValueMember = "productline";
            //----

            this.productsTableAdapter1.FillByProductLine(ds.products, cmbProductLines.Text);
            dgvArticles.DataSource = ds.products;
            dgvArticles.AutoResizeColumns();
            dgvArticles.Columns["productline"].Visible = false;
            dgvArticles.Columns["productdescription"].Visible = false;
            dgvArticles.Refresh();
            

        }

        private void cmbProductLines_SelectedIndexChanged(object sender, EventArgs e)
        {

            //this.productsTableAdapter1.FillByProductLine(ds.products, cmbProductLines.Text);
            //dgvArticles.DataSource = ds.products;
            //dgvArticles.AutoResizeColumns();
            //dgvArticles.Columns["productline"].Visible = false;
            //dgvArticles.Refresh();
            this.productsTableAdapter1.FillByProductLine(ds.products, cmbProductLines.Text);
        }

        private void dgvArticles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvArticles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDescripcio.Text = dgvArticles.CurrentRow.Cells["productdescription"].Value.ToString();
            codiArticle = dgvArticles.CurrentRow.Cells["productCode"].Value.ToString();
            DataView dvOrderDetails = new DataView(ds.orderdetails);
            if (!dvOrderDetails.Table.Columns.Contains("CustomerCode")) dvOrderDetails.Table.Columns.Add("CustomerCode", typeof(string));
            if (!dvOrderDetails.Table.Columns.Contains("CustomerName")) dvOrderDetails.Table.Columns.Add("CustomerName", typeof(string));
            dvOrderDetails.RowFilter = "productCode='" + codiArticle + "'";
            foreach(DataRowView row in dvOrderDetails)
            {
                string orderNumber = row["orderNumber"].ToString();
                DataView dvOrder = new DataView(ds.orders);
                dvOrder.RowFilter = "orderNumber = '" + orderNumber + "'";
                if(dvOrder.Count > 0)
                {
                    string customerNumber = dvOrder[0]["customerNumber"].ToString();
                    DataView dvCustomer = new DataView(ds.customers);
                    dvCustomer.RowFilter = "customerNumber='" + customerNumber + "'";
                    string customerName = dvCustomer[0]["customerName"].ToString();
                    row["CustomerCode"] = customerNumber;
                    row["CustomerName"] = customerName;
                }
            }
            dgvOrders.DataSource = dvOrderDetails;
        }

        private void dgvArticles_RowEnter(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private void dgvArticles_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvArticles_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void dgvArticles_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dgvArticles_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgvArticles.CurrentRow != null)
            {
                txtDescripcio.Text = dgvArticles.CurrentRow.Cells["productdescription"].Value.ToString();
                txtCodi.Text = dgvArticles.CurrentRow.Cells["productcode"].Value.ToString();
                txtNom.Text = dgvArticles.CurrentRow.Cells["productname"].Value.ToString();
                txtDescripcio.Text = dgvArticles.CurrentRow.Cells["productdescription"].Value.ToString();
                codiArticle = dgvArticles.CurrentRow.Cells["productCode"].Value.ToString();

                //if (dgvOrders.RowCount == 0) btnDelete.Enabled = false; 

                /*DataView dvOrders = new DataView(ds.orders);
                if (!dvOrders.Table.Columns.Contains("CustomerName")) dvOrders.Table.Columns.Add("CustomerName", typeof(string));
                DataView dvOrderDetails = new DataView(ds.orderdetails);
                dvOrderDetails.RowFilter = "productCode='" + codiArticle + "'";
                string orderNumber = dvOrderDetails[0]["orderNumber"].ToString();
                dvOrders.RowFilter = "orderNumber = '" + orderNumber + "'";
                foreach (DataRowView row in dvOrders)
                {
                    string customerNumber = dvOrders[0]["customerNumber"].ToString();
                    DataView dvCustomer = new DataView(ds.customers);
                    dvCustomer.RowFilter = "customerNumber='" + customerNumber + "'";
                    string customerName = dvCustomer[0]["customerName"].ToString();
                    row["customerNumber"] = customerNumber;
                    row["customerName"] = customerName;
                }*/
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmArticle fArticle = new frmArticle(ds,cmbProductLines.Text,null);
            fArticle.ShowDialog();
            
        }

        private void dgvArticles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvArticles.CurrentRow != null)
            {
                DataGridViewRow filaAct = dgvArticles.CurrentRow;
                frmArticle fArticle = new frmArticle(ds, cmbProductLines.Text,filaAct );
                
                fArticle.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Segur que vols eliminar?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.dgvArticles.SelectedRows)
                    {
                        dgvArticles.Rows.RemoveAt(item.Index);
                    }
                    productsTableAdapter1.Update(ds.products);
                    MessageBox.Show("Dades eliminades.");
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Dades no eliminades.");
                }
                dgvArticles.Refresh();
            }
            catch(Exception) { MessageBox.Show("Aquest article té relacions amb altres taules, no es pot eliminar", "Acció il·legal"); }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int i = cmbProductLines.SelectedIndex;
            cmbProductLines.SelectedIndex = 1;
            cmbProductLines.SelectedIndex = i;
        }
    }
}
