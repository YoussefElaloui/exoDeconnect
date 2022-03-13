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
    public partial class Frm_miseAjour : Form
    {
        public Frm_miseAjour()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["exoDeconnect.Properties.Settings.cs"].ConnectionString);
        SqlCommand com,coma;
        SqlCommandBuilder scb;
        BindingSource bs,bs_Employe;
        SqlDataAdapter da,daV2;

        private void txt_find_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_find.PerformClick();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            bs_Employe.MoveNext();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            bs_Employe.MoveLast();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            bs_Employe.MovePrevious();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            bs_Employe.MoveFirst();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            bs_Employe.CancelEdit();
            activate(true);
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            bs_Employe.AddNew();
            activate(false);
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            bs_Employe.RemoveCurrent();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            bs_Employe.EndEdit();
            activate(true);
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            bs_Employe.Filter = "nom like '%" + txt_find.Text + "%'";
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            activate(false);
        }

        private void Frm_miseAjour_FormClosing(object sender, FormClosingEventArgs e)
        {
            daV2.Update(ds.Tables["Employe"]);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void activate(bool b)
        {
            pnl_listEmps.Enabled = b;
            pnl_save.Enabled = !b;
            pnl_details.Enabled = !b;
            pnl_miseajour.Enabled = b;
        }
        private void Frm_miseAjour_Load(object sender, EventArgs e)
        {
            com = new SqlCommand("select * from Service",sc);
            da = new SqlDataAdapter(com);
            da.Fill(ds, "Service");
            bs = new BindingSource(ds, "Service");
            cmb_service.DisplayMember = "Nom_serv";
            cmb_service.ValueMember = "Num_serv";
            cmb_service.DataSource = bs;
            coma = new SqlCommand("select * from Employe",sc);
            daV2 = new SqlDataAdapter(coma);
            scb = new SqlCommandBuilder(daV2);
            daV2.Fill(ds, "Employe");
            DataColumn pk = ds.Tables["Service"].Columns["Num_serv"];
            DataColumn fk = ds.Tables["Employe"].Columns["Num_serv"];
            DataRelation dr = new DataRelation("fk_service_employe", pk, fk);
            ds.Relations.Add(dr);
            bs_Employe = new BindingSource();
            bs_Employe.DataSource = bs;
            bs_Employe.DataMember = "fk_service_employe";


            lst_emps.DisplayMember = "nom";
            lst_emps.ValueMember = "Matricule";
            lst_emps.DataSource = bs_Employe;

            txt_matricule.DataBindings.Add("text", bs_Employe, "Matricule");
            txt_nom.DataBindings.Add("text", bs_Employe, "nom");
            txt_prenom.DataBindings.Add("text", bs_Employe, "prenom");
            txt_adresse.DataBindings.Add("text", bs_Employe, "adresse");
            txt_date.DataBindings.Add("text", bs_Employe, "DateNaissance");
            txt_salaire.DataBindings.Add("text", bs_Employe, "salaire");
            txt_grade.DataBindings.Add("text", bs_Employe, "grade");

            activate(true);
        }
    }
}
