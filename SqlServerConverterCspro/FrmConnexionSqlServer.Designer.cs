namespace SqlServerConverterCspro
{
    partial class FrmConnexionSqlServer
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
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.cmb_server = new System.Windows.Forms.ComboBox();
            this.rcmb_DatabaseName = new System.Windows.Forms.ComboBox();
            this.GrpBox_DB = new System.Windows.Forms.GroupBox();
            this.rbtn_PostGres = new System.Windows.Forms.RadioButton();
            this.rbtn_MySql = new System.Windows.Forms.RadioButton();
            this.rbtn_SqlServer = new System.Windows.Forms.RadioButton();
            this.rbtn_Oracle = new System.Windows.Forms.RadioButton();
            this.Btn_ConnexionServerName = new System.Windows.Forms.Button();
            this.txt_DatabaseName = new System.Windows.Forms.TextBox();
            this.lbl_Database_port = new System.Windows.Forms.Label();
            this.txt_ServerName = new System.Windows.Forms.TextBox();
            this.Txt_Login = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lbl_Servername = new System.Windows.Forms.Label();
            this.GroupBox4.SuspendLayout();
            this.GrpBox_DB.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox4
            // 
            this.GroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox4.Controls.Add(this.cmb_server);
            this.GroupBox4.Controls.Add(this.rcmb_DatabaseName);
            this.GroupBox4.Controls.Add(this.GrpBox_DB);
            this.GroupBox4.Controls.Add(this.Btn_ConnexionServerName);
            this.GroupBox4.Controls.Add(this.txt_DatabaseName);
            this.GroupBox4.Controls.Add(this.lbl_Database_port);
            this.GroupBox4.Controls.Add(this.txt_ServerName);
            this.GroupBox4.Controls.Add(this.Txt_Login);
            this.GroupBox4.Controls.Add(this.Txt_Password);
            this.GroupBox4.Controls.Add(this.Label5);
            this.GroupBox4.Controls.Add(this.Label4);
            this.GroupBox4.Controls.Add(this.lbl_Servername);
            this.GroupBox4.Location = new System.Drawing.Point(13, 14);
            this.GroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox4.Size = new System.Drawing.Size(544, 340);
            this.GroupBox4.TabIndex = 2;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Paramètres Connexion Base de donnees";
            // 
            // cmb_server
            // 
            this.cmb_server.FormattingEnabled = true;
            this.cmb_server.Location = new System.Drawing.Point(132, 92);
            this.cmb_server.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_server.Name = "cmb_server";
            this.cmb_server.Size = new System.Drawing.Size(383, 28);
            this.cmb_server.TabIndex = 4;
            // 
            // rcmb_DatabaseName
            // 
            this.rcmb_DatabaseName.FormattingEnabled = true;
            this.rcmb_DatabaseName.Location = new System.Drawing.Point(132, 222);
            this.rcmb_DatabaseName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rcmb_DatabaseName.Name = "rcmb_DatabaseName";
            this.rcmb_DatabaseName.Size = new System.Drawing.Size(383, 28);
            this.rcmb_DatabaseName.TabIndex = 7;
            // 
            // GrpBox_DB
            // 
            this.GrpBox_DB.Controls.Add(this.rbtn_PostGres);
            this.GrpBox_DB.Controls.Add(this.rbtn_MySql);
            this.GrpBox_DB.Controls.Add(this.rbtn_SqlServer);
            this.GrpBox_DB.Controls.Add(this.rbtn_Oracle);
            this.GrpBox_DB.Location = new System.Drawing.Point(9, 28);
            this.GrpBox_DB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpBox_DB.Name = "GrpBox_DB";
            this.GrpBox_DB.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpBox_DB.Size = new System.Drawing.Size(508, 55);
            this.GrpBox_DB.TabIndex = 13;
            this.GrpBox_DB.TabStop = false;
            // 
            // rbtn_PostGres
            // 
            this.rbtn_PostGres.AutoSize = true;
            this.rbtn_PostGres.Location = new System.Drawing.Point(400, 20);
            this.rbtn_PostGres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn_PostGres.Name = "rbtn_PostGres";
            this.rbtn_PostGres.Size = new System.Drawing.Size(97, 24);
            this.rbtn_PostGres.TabIndex = 3;
            this.rbtn_PostGres.Text = "Postgres";
            this.rbtn_PostGres.UseVisualStyleBackColor = true;
            // 
            // rbtn_MySql
            // 
            this.rbtn_MySql.AutoSize = true;
            this.rbtn_MySql.Location = new System.Drawing.Point(266, 20);
            this.rbtn_MySql.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn_MySql.Name = "rbtn_MySql";
            this.rbtn_MySql.Size = new System.Drawing.Size(86, 24);
            this.rbtn_MySql.TabIndex = 2;
            this.rbtn_MySql.Text = "MySQL";
            this.rbtn_MySql.UseVisualStyleBackColor = true;
            // 
            // rbtn_SqlServer
            // 
            this.rbtn_SqlServer.AutoSize = true;
            this.rbtn_SqlServer.Checked = true;
            this.rbtn_SqlServer.Location = new System.Drawing.Point(123, 20);
            this.rbtn_SqlServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn_SqlServer.Name = "rbtn_SqlServer";
            this.rbtn_SqlServer.Size = new System.Drawing.Size(112, 24);
            this.rbtn_SqlServer.TabIndex = 1;
            this.rbtn_SqlServer.TabStop = true;
            this.rbtn_SqlServer.Text = "SQLServer";
            this.rbtn_SqlServer.UseVisualStyleBackColor = true;
            // 
            // rbtn_Oracle
            // 
            this.rbtn_Oracle.AutoSize = true;
            this.rbtn_Oracle.Location = new System.Drawing.Point(9, 20);
            this.rbtn_Oracle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn_Oracle.Name = "rbtn_Oracle";
            this.rbtn_Oracle.Size = new System.Drawing.Size(80, 24);
            this.rbtn_Oracle.TabIndex = 0;
            this.rbtn_Oracle.Text = "Oracle";
            this.rbtn_Oracle.UseVisualStyleBackColor = true;
            // 
            // Btn_ConnexionServerName
            // 
            this.Btn_ConnexionServerName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ConnexionServerName.Enabled = false;
            this.Btn_ConnexionServerName.Location = new System.Drawing.Point(130, 275);
            this.Btn_ConnexionServerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_ConnexionServerName.Name = "Btn_ConnexionServerName";
            this.Btn_ConnexionServerName.Size = new System.Drawing.Size(156, 45);
            this.Btn_ConnexionServerName.TabIndex = 8;
            this.Btn_ConnexionServerName.Text = "Connexion";
            this.Btn_ConnexionServerName.UseVisualStyleBackColor = true;
            // 
            // txt_DatabaseName
            // 
            this.txt_DatabaseName.Location = new System.Drawing.Point(296, 282);
            this.txt_DatabaseName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DatabaseName.Name = "txt_DatabaseName";
            this.txt_DatabaseName.Size = new System.Drawing.Size(28, 26);
            this.txt_DatabaseName.TabIndex = 1;
            this.txt_DatabaseName.Visible = false;
            // 
            // lbl_Database_port
            // 
            this.lbl_Database_port.AutoSize = true;
            this.lbl_Database_port.Location = new System.Drawing.Point(17, 228);
            this.lbl_Database_port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Database_port.Name = "lbl_Database_port";
            this.lbl_Database_port.Size = new System.Drawing.Size(85, 20);
            this.lbl_Database_port.TabIndex = 7;
            this.lbl_Database_port.Text = "DataBase:";
            // 
            // txt_ServerName
            // 
            this.txt_ServerName.Location = new System.Drawing.Point(334, 282);
            this.txt_ServerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ServerName.Name = "txt_ServerName";
            this.txt_ServerName.Size = new System.Drawing.Size(28, 26);
            this.txt_ServerName.TabIndex = 0;
            this.txt_ServerName.Visible = false;
            // 
            // Txt_Login
            // 
            this.Txt_Login.Location = new System.Drawing.Point(130, 132);
            this.Txt_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.Size = new System.Drawing.Size(385, 26);
            this.Txt_Login.TabIndex = 5;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(130, 172);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(385, 26);
            this.Txt_Password.TabIndex = 6;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(17, 182);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(82, 20);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Password:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(17, 142);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(52, 20);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Login:";
            // 
            // lbl_Servername
            // 
            this.lbl_Servername.AutoSize = true;
            this.lbl_Servername.Location = new System.Drawing.Point(15, 98);
            this.lbl_Servername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Servername.Name = "lbl_Servername";
            this.lbl_Servername.Size = new System.Drawing.Size(105, 20);
            this.lbl_Servername.TabIndex = 5;
            this.lbl_Servername.Text = "Server Name:";
            // 
            // FrmConnexionSqlServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 379);
            this.Controls.Add(this.GroupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConnexionSqlServer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion SqlServer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConnexionSqlServer_FormClosed);
            this.Load += new System.EventHandler(this.FrmConnexionSqlServer_Load);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GrpBox_DB.ResumeLayout(false);
            this.GrpBox_DB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.ComboBox cmb_server;
        internal System.Windows.Forms.ComboBox rcmb_DatabaseName;
        internal System.Windows.Forms.GroupBox GrpBox_DB;
        internal System.Windows.Forms.RadioButton rbtn_PostGres;
        internal System.Windows.Forms.RadioButton rbtn_MySql;
        internal System.Windows.Forms.RadioButton rbtn_SqlServer;
        internal System.Windows.Forms.RadioButton rbtn_Oracle;
        internal System.Windows.Forms.Button Btn_ConnexionServerName;
        internal System.Windows.Forms.TextBox txt_DatabaseName;
        internal System.Windows.Forms.Label lbl_Database_port;
        internal System.Windows.Forms.TextBox txt_ServerName;
        internal System.Windows.Forms.TextBox Txt_Login;
        internal System.Windows.Forms.TextBox Txt_Password;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lbl_Servername;
    }
}