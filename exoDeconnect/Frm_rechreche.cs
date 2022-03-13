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
    public partial class Frm_rechreche : Form
    {
        public Frm_rechreche()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["exoDeconnect.Properties.Settings.cs"].ConnectionString);
        SqlDataAdapter da,da_taches,da_Emp;
        SqlCommand com,comT,com_Emp;
        BindingSource bs,bs_taches,bs_Emp;
        private void Frm_rechreche_Load(object sender, EventArgs e)
        {
            sc.Open();
            com = new SqlCommand("select * from projet", sc);
            da = new SqlDataAdapter(com);
            da.Fill(ds,"Projet");
            bs = new BindingSource(ds, "Projet");
            combo_projects.DisplayMember = "Nom_prj";
            combo_projects.ValueMember = "Num_prj";
            combo_projects.DataSource = bs;
            comT = new SqlCommand("select * from tache",sc);
            da_taches = new SqlDataAdapter(comT);
            da_taches.Fill(ds, "Tache");
            DataColumn pk = ds.Tables["Projet"].Columns["Num_prj"];
            DataColumn fk = ds.Tables["Tache"].Columns["Num_prj"];
            DataRelation dr = new DataRelation("fk_tache_projet", pk, fk);
            ds.Relations.Add(dr);
            bs_taches = new BindingSource(bs, "fk_tache_projet");
            lst_taches.DisplayMember = "Nom_tache";
            lst_taches.ValueMember = "Num_tach";
            lst_taches.DataSource = bs_taches;
            string ss = "select nom,p.num_prj,SUM(Nombre_heure) as nb,(SUM(Nombre_heure)*100)/dbo.fpp(p.Num_prj) as total from Employe e inner join Travaille t on e.Matricule=t.Matricule inner join Tache ta on ta.Num_tach=t.Num_tach inner join Projet p on p.Num_prj=ta.Num_prj group by nom,p.num_prj";
            com_Emp = new SqlCommand(ss, sc);
            da_Emp = new SqlDataAdapter(com_Emp);
            da_Emp.Fill(ds, "emp");

            DataColumn pkE = ds.Tables["projet"].Columns["num_prj"];
            DataColumn fkE = ds.Tables["emp"].Columns["num_prj"];
            DataRelation drE = new DataRelation("fk_emp_projet", pkE, fkE);
            ds.Relations.Add(drE);

            bs_Emp = new BindingSource(bs, "fk_emp_projet");
            dgv_emps.DataSource = bs_Emp;
            dgv_emps.Columns[1].Visible = false;
        }
    }
}
