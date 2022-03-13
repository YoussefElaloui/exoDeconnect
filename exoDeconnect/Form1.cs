using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exoDeconnect
{
    public partial class Frm_menu : Form
    {
        public Frm_menu()
        {
            InitializeComponent();
        }
        void fillPanel(Form f)
        {
            if (pnl_main.Controls.Count > 0)
            {
                Form ff = (Form)pnl_main.Controls[0];
                ff.Close();
            }
            pnl_main.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            pnl_main.Controls.Add(f);
            f.Show();
        }

        private void btn_miseAjour_Click(object sender, EventArgs e)
        {
            Frm_miseAjour f = new Frm_miseAjour();
            fillPanel(f);
        }

        private void Frm_menu_Load(object sender, EventArgs e)
        {
            btn_miseAjour.PerformClick();
        }

        private void Frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            fillPanel(new Form());
        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {
            Frm_rechreche f = new Frm_rechreche();
            fillPanel(f);
        }
    }
}
