using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlServerConverterCspro
{
    public partial class MainForm : Form
    {
        FrmConnexionSqlServer frmConSql;
        public MainForm()
        {
            InitializeComponent();

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            frmConSql = new FrmConnexionSqlServer();
            frmConSql.MdiParent = this;
            frmConSql.Show();
        }
    }
}
