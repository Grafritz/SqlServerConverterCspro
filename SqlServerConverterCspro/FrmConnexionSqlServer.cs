using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer;
using Microsoft.SqlServer.Management;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace SqlServerConverterCspro
{
    public partial class FrmConnexionSqlServer : Form
    {
        public FrmConnexionSqlServer()
        {
            InitializeComponent();
        }

        private void FrmConnexionSqlServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void FrmConnexionSqlServer_Load(object sender, EventArgs e)
        {
            LoadInstanceSQLServer();
        }

        public void LoadInstanceSQLServer()
        {
            DataTable dt = new DataTable();
            //String resultCol = "", resultRow="";

            try
            {
                // Avoir les instances pour la connexion avec la base de donnée
                SqlDataSourceEnumerator sqlds = SqlDataSourceEnumerator.Instance;
                if ( dt.Rows.Count == 0 )
                {
                    dt = sqlds.GetDataSources();
                    List<String> listServers = new List<String>();
                    foreach (DataRow drow in dt.Rows)
                    {
                            listServers.Add(drow["ServerName"].ToString()+"\\"+ drow["InstanceName"].ToString());                        
                    }
                    cmb_ServerName.DataSource = listServers;
                }
                //MessageBox.Show("resultCol: " + resultCol +"\n\n"+ "resultRow: " + resultRow );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!");
            }
            finally
            {
                dt.Clear();
            }

        }

        private void rcmb_DatabaseName_DropDown(object sender, EventArgs e)
        {
            try
            {
                rcmb_DatabaseName.Items.Clear();
                var serverCon = new ServerConnection(cmb_ServerName.Text);
                serverCon.LoginSecure = false;
                serverCon.Login = Txt_Login.Text;
                serverCon.Password = Txt_Password.Text;
                var server = new Server(serverCon);
                foreach (Database db in server.Databases )
                {
                     rcmb_DatabaseName.Items.Add(db.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!");
            }            
        }

        private void rcmb_DatabaseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rcmb_DatabaseName.Text != "")
            {
                txt_DatabaseName.Text = rcmb_DatabaseName.Text;
                EnableBtnConnexion();
            }
        }

        private void EnableBtnConnexion()
        {
            Btn_ConnexionServerName.Enabled = (cmb_ServerName.Text.Trim().Equals("") & rcmb_DatabaseName.Text.Trim().Equals("") & Txt_Login.Text.Trim().Equals("")? false: true);
        }
       
    }
}
