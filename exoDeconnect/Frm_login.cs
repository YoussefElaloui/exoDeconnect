using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace exoDeconnect
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_loginin_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["exoDeconnect.Properties.Settings.cs"].ConnectionString);
            sc.Open();
            SqlCommand com = new SqlCommand("select * from Utilisateur where Login=@login and Password=@pass", sc);
            com.Parameters.AddWithValue("@login",txt_username.Text);
            com.Parameters.AddWithValue("@pass",txt_pass.Text);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds, "Utilisateur");
            DataTable table = ds.Tables["Utilisateur"];
            if (table.Rows.Count != 0)
            {
                Frm_menu f = new Frm_menu();
                this.Visible = false;
                f.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Username or Password is Incorect");
        }
    }
}
