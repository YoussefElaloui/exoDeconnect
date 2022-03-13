
namespace exoDeconnect
{
    partial class Frm_miseAjour
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_service = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.lst_emps = new System.Windows.Forms.ListBox();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.pnl_save = new System.Windows.Forms.Panel();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pnl_miseajour = new System.Windows.Forms.Panel();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.pnl_details = new System.Windows.Forms.Panel();
            this.txt_grade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_salaire = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_adresse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_matricule = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_listEmps = new System.Windows.Forms.Panel();
            this.pnl_save.SuspendLayout();
            this.pnl_miseajour.SuspendLayout();
            this.pnl_details.SuspendLayout();
            this.pnl_listEmps.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service";
            // 
            // cmb_service
            // 
            this.cmb_service.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_service.FormattingEnabled = true;
            this.cmb_service.Location = new System.Drawing.Point(114, 9);
            this.cmb_service.Name = "cmb_service";
            this.cmb_service.Size = new System.Drawing.Size(240, 28);
            this.cmb_service.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recherche";
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(114, 49);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(182, 26);
            this.txt_find.TabIndex = 3;
            this.txt_find.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_find_KeyUp);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(301, 49);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(53, 26);
            this.btn_find.TabIndex = 4;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // lst_emps
            // 
            this.lst_emps.FormattingEnabled = true;
            this.lst_emps.ItemHeight = 20;
            this.lst_emps.Location = new System.Drawing.Point(19, 81);
            this.lst_emps.Name = "lst_emps";
            this.lst_emps.Size = new System.Drawing.Size(334, 424);
            this.lst_emps.TabIndex = 5;
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(19, 511);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(55, 33);
            this.btn_first.TabIndex = 6;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(241, 511);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(55, 33);
            this.btn_next.TabIndex = 7;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(298, 511);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(55, 33);
            this.btn_last.TabIndex = 8;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(80, 511);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(55, 33);
            this.btn_prev.TabIndex = 9;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // pnl_save
            // 
            this.pnl_save.Controls.Add(this.btn_annuler);
            this.pnl_save.Controls.Add(this.btn_valider);
            this.pnl_save.Location = new System.Drawing.Point(437, 446);
            this.pnl_save.Name = "pnl_save";
            this.pnl_save.Size = new System.Drawing.Size(281, 58);
            this.pnl_save.TabIndex = 37;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(141, 5);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(127, 41);
            this.btn_annuler.TabIndex = 32;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(8, 5);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(127, 41);
            this.btn_valider.TabIndex = 31;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(750, 540);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(127, 41);
            this.btn_exit.TabIndex = 35;
            this.btn_exit.Text = "Quitter";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pnl_miseajour
            // 
            this.pnl_miseajour.Controls.Add(this.btn_modifier);
            this.pnl_miseajour.Controls.Add(this.btn_supprimer);
            this.pnl_miseajour.Controls.Add(this.btn_ajouter);
            this.pnl_miseajour.Location = new System.Drawing.Point(445, 362);
            this.pnl_miseajour.Name = "pnl_miseajour";
            this.pnl_miseajour.Size = new System.Drawing.Size(413, 59);
            this.pnl_miseajour.TabIndex = 36;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(136, 9);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(127, 41);
            this.btn_modifier.TabIndex = 30;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(273, 9);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(127, 41);
            this.btn_supprimer.TabIndex = 29;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(3, 9);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(127, 41);
            this.btn_ajouter.TabIndex = 28;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // pnl_details
            // 
            this.pnl_details.Controls.Add(this.txt_grade);
            this.pnl_details.Controls.Add(this.label9);
            this.pnl_details.Controls.Add(this.txt_salaire);
            this.pnl_details.Controls.Add(this.label8);
            this.pnl_details.Controls.Add(this.txt_date);
            this.pnl_details.Controls.Add(this.label7);
            this.pnl_details.Controls.Add(this.txt_adresse);
            this.pnl_details.Controls.Add(this.label6);
            this.pnl_details.Controls.Add(this.txt_prenom);
            this.pnl_details.Controls.Add(this.label5);
            this.pnl_details.Controls.Add(this.txt_nom);
            this.pnl_details.Controls.Add(this.label4);
            this.pnl_details.Controls.Add(this.txt_matricule);
            this.pnl_details.Controls.Add(this.label3);
            this.pnl_details.Location = new System.Drawing.Point(395, 17);
            this.pnl_details.Name = "pnl_details";
            this.pnl_details.Size = new System.Drawing.Size(464, 326);
            this.pnl_details.TabIndex = 34;
            // 
            // txt_grade
            // 
            this.txt_grade.Location = new System.Drawing.Point(208, 288);
            this.txt_grade.Name = "txt_grade";
            this.txt_grade.Size = new System.Drawing.Size(242, 26);
            this.txt_grade.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Grade";
            // 
            // txt_salaire
            // 
            this.txt_salaire.Location = new System.Drawing.Point(208, 240);
            this.txt_salaire.Name = "txt_salaire";
            this.txt_salaire.Size = new System.Drawing.Size(242, 26);
            this.txt_salaire.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Salaire";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(208, 187);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(242, 26);
            this.txt_date.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Date de Naissance";
            // 
            // txt_adresse
            // 
            this.txt_adresse.Location = new System.Drawing.Point(208, 144);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.Size = new System.Drawing.Size(242, 26);
            this.txt_adresse.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Adresse";
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(208, 98);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(242, 26);
            this.txt_prenom.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Prenom";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(208, 56);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(242, 26);
            this.txt_nom.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nom";
            // 
            // txt_matricule
            // 
            this.txt_matricule.Location = new System.Drawing.Point(208, 11);
            this.txt_matricule.Name = "txt_matricule";
            this.txt_matricule.Size = new System.Drawing.Size(242, 26);
            this.txt_matricule.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Matricule";
            // 
            // pnl_listEmps
            // 
            this.pnl_listEmps.Controls.Add(this.btn_prev);
            this.pnl_listEmps.Controls.Add(this.btn_last);
            this.pnl_listEmps.Controls.Add(this.btn_next);
            this.pnl_listEmps.Controls.Add(this.btn_first);
            this.pnl_listEmps.Controls.Add(this.lst_emps);
            this.pnl_listEmps.Controls.Add(this.btn_find);
            this.pnl_listEmps.Controls.Add(this.txt_find);
            this.pnl_listEmps.Controls.Add(this.label2);
            this.pnl_listEmps.Controls.Add(this.cmb_service);
            this.pnl_listEmps.Controls.Add(this.label1);
            this.pnl_listEmps.Location = new System.Drawing.Point(3, 8);
            this.pnl_listEmps.Name = "pnl_listEmps";
            this.pnl_listEmps.Size = new System.Drawing.Size(370, 572);
            this.pnl_listEmps.TabIndex = 38;
            // 
            // Frm_miseAjour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 595);
            this.Controls.Add(this.pnl_listEmps);
            this.Controls.Add(this.pnl_save);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pnl_miseajour);
            this.Controls.Add(this.pnl_details);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_miseAjour";
            this.Text = "Frm_miseAjour";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_miseAjour_FormClosing);
            this.Load += new System.EventHandler(this.Frm_miseAjour_Load);
            this.pnl_save.ResumeLayout(false);
            this.pnl_miseajour.ResumeLayout(false);
            this.pnl_details.ResumeLayout(false);
            this.pnl_details.PerformLayout();
            this.pnl_listEmps.ResumeLayout(false);
            this.pnl_listEmps.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_service;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.ListBox lst_emps;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Panel pnl_save;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel pnl_miseajour;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Panel pnl_details;
        private System.Windows.Forms.TextBox txt_grade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_salaire;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_adresse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_matricule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_listEmps;
    }
}