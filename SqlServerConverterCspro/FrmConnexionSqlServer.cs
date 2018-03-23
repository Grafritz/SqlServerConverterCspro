using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            Application.Exit();
        }

        private void FrmConnexionSqlServer_Load(object sender, EventArgs e)
        {

        }

        public void LoadInstanceSQLServer()
        {
            DataTable dt = new DataTable();

            try
            {
                // Avoir les instances pour la connexion avec la base de donnée
                SqlDataSourceEnumerator sqlds = SqlDataSourceEnumerator.Instance;
                if ( dt.Rows.Count > 0 )
                {
                    dt = sqlds.GetDataSources();
                    //List<string> listServers  = New List<string>;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

    //    Public Sub LoadInstanceSQLServer()
    //    'declare variables
    //    Dim dt As Data.DataTable = New DataTable()
    //    Dim dr As Data.DataRow = Nothing

    //    Try
    //        ''get sql server instances in to DataTable object
    //        Dim servers As Sql.SqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance

    //        ' Check if datatable is empty
    //        If dt.Rows.Count = 0 Then
    //            ' Get a datatable with info about SQL Server 2000 and 2005 instances
    //            dt = servers.GetDataSources()

    //            ' List that will be combobox’s datasource   
    //            Dim listServers As List(Of String) = New List(Of String)
    //            ' For each element in the datatable add a new element in the list

    //            For Each rowServer As DataRow In dt.Rows
    //                ' SQL Server instance could have instace name or only server name,
    //                ' check this for show the name
    //                If String.IsNullOrEmpty(rowServer("InstanceName").ToString()) Then
    //                    If rowServer("ServerName").ToString().Equals("JFDUVERS-PC") Then
    //                        listServers.Add(rowServer("ServerName").ToString() & "\MSSQLSERVER_08R2")
    //                    Else
    //                        listServers.Add(rowServer("ServerName").ToString())
    //                    End If
    //                Else
    //                    listServers.Add(rowServer("ServerName") & "\" & rowServer("InstanceName"))
    //                End If
    //            Next
    //            'Set servers list to combobox’s datasource
    //            Me.cmb_server.DataSource = listServers
    //        End If
    //    Catch ex As System.Data.SqlClient.SqlException
    //        MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error!")

    //    Catch ex As Exception
    //        MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error!")

    //    Finally
    //        'clean up ;)
    //        dr = Nothing
    //        dt = Nothing
    //    End Try
    //End Sub

    }
}
