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
    public partial class frmMain : Form
    {
        dsClassicModels ds;
        public frmMain()
        {
            InitializeComponent();
            ds = new dsClassicModels();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void productesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticles fArticles = new frmArticles(ds);
            fArticles.ShowDialog();
        }

        private void empleatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleats fEmpleats = new frmEmpleats(ds);
            fEmpleats.ShowDialog();
        }

        private void gestióToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void officesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOffices fOffices = new frmOffices(ds);
            fOffices.ShowDialog();
        }
    }
}
