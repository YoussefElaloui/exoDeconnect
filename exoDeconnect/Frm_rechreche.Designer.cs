
namespace exoDeconnect
{
    partial class Frm_rechreche
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
            this.txt_total = new System.Windows.Forms.TextBox();
            this.dgv_emps = new System.Windows.Forms.DataGridView();
            this.lst_taches = new System.Windows.Forms.ListBox();
            this.combo_projects = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emps)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(783, 553);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(128, 26);
            this.txt_total.TabIndex = 7;
            // 
            // dgv_emps
            // 
            this.dgv_emps.AllowUserToAddRows = false;
            this.dgv_emps.AllowUserToDeleteRows = false;
            this.dgv_emps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emps.Location = new System.Drawing.Point(302, 57);
            this.dgv_emps.Name = "dgv_emps";
            this.dgv_emps.ReadOnly = true;
            this.dgv_emps.Size = new System.Drawing.Size(590, 483);
            this.dgv_emps.TabIndex = 6;
            // 
            // lst_taches
            // 
            this.lst_taches.FormattingEnabled = true;
            this.lst_taches.ItemHeight = 20;
            this.lst_taches.Location = new System.Drawing.Point(14, 57);
            this.lst_taches.Name = "lst_taches";
            this.lst_taches.Size = new System.Drawing.Size(263, 484);
            this.lst_taches.TabIndex = 5;
            // 
            // combo_projects
            // 
            this.combo_projects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_projects.FormattingEnabled = true;
            this.combo_projects.Location = new System.Drawing.Point(12, 15);
            this.combo_projects.Name = "combo_projects";
            this.combo_projects.Size = new System.Drawing.Size(266, 28);
            this.combo_projects.TabIndex = 4;
            // 
            // Frm_rechreche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 595);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.dgv_emps);
            this.Controls.Add(this.lst_taches);
            this.Controls.Add(this.combo_projects);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_rechreche";
            this.Text = "Frm_rechreche";
            this.Load += new System.EventHandler(this.Frm_rechreche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.DataGridView dgv_emps;
        private System.Windows.Forms.ListBox lst_taches;
        private System.Windows.Forms.ComboBox combo_projects;
    }
}