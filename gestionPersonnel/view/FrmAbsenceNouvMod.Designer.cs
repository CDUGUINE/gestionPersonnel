
namespace gestionPersonnel.view
{
    partial class frmAbsenceNouvMod
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
            this.grpDateDebut = new System.Windows.Forms.GroupBox();
            this.mclDebut = new System.Windows.Forms.MonthCalendar();
            this.mclFin = new System.Windows.Forms.MonthCalendar();
            this.grpDateFin = new System.Windows.Forms.GroupBox();
            this.grpMotif = new System.Windows.Forms.GroupBox();
            this.cmbMotif = new System.Windows.Forms.ComboBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.grpDateDebut.SuspendLayout();
            this.grpDateFin.SuspendLayout();
            this.grpMotif.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDateDebut
            // 
            this.grpDateDebut.Controls.Add(this.mclDebut);
            this.grpDateDebut.Location = new System.Drawing.Point(13, 13);
            this.grpDateDebut.Name = "grpDateDebut";
            this.grpDateDebut.Size = new System.Drawing.Size(245, 191);
            this.grpDateDebut.TabIndex = 0;
            this.grpDateDebut.TabStop = false;
            this.grpDateDebut.Text = "début";
            // 
            // mclDebut
            // 
            this.mclDebut.Location = new System.Drawing.Point(7, 20);
            this.mclDebut.Name = "mclDebut";
            this.mclDebut.TabIndex = 0;
            // 
            // mclFin
            // 
            this.mclFin.Location = new System.Drawing.Point(7, 20);
            this.mclFin.Name = "mclFin";
            this.mclFin.TabIndex = 0;
            // 
            // grpDateFin
            // 
            this.grpDateFin.Controls.Add(this.mclFin);
            this.grpDateFin.Location = new System.Drawing.Point(264, 13);
            this.grpDateFin.Name = "grpDateFin";
            this.grpDateFin.Size = new System.Drawing.Size(245, 191);
            this.grpDateFin.TabIndex = 1;
            this.grpDateFin.TabStop = false;
            this.grpDateFin.Text = "fin";
            // 
            // grpMotif
            // 
            this.grpMotif.Controls.Add(this.cmbMotif);
            this.grpMotif.Location = new System.Drawing.Point(13, 211);
            this.grpMotif.Name = "grpMotif";
            this.grpMotif.Size = new System.Drawing.Size(200, 54);
            this.grpMotif.TabIndex = 2;
            this.grpMotif.TabStop = false;
            this.grpMotif.Text = "motif";
            // 
            // cmbMotif
            // 
            this.cmbMotif.FormattingEnabled = true;
            this.cmbMotif.Location = new System.Drawing.Point(7, 20);
            this.cmbMotif.Name = "cmbMotif";
            this.cmbMotif.Size = new System.Drawing.Size(187, 21);
            this.cmbMotif.TabIndex = 0;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(354, 228);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 3;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(435, 228);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // frmAbsenceNouvMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 276);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.grpMotif);
            this.Controls.Add(this.grpDateFin);
            this.Controls.Add(this.grpDateDebut);
            this.Name = "frmAbsenceNouvMod";
            this.Text = "Absence de ";
            this.grpDateDebut.ResumeLayout(false);
            this.grpDateFin.ResumeLayout(false);
            this.grpMotif.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDateDebut;
        private System.Windows.Forms.MonthCalendar mclDebut;
        private System.Windows.Forms.MonthCalendar mclFin;
        private System.Windows.Forms.GroupBox grpDateFin;
        private System.Windows.Forms.GroupBox grpMotif;
        private System.Windows.Forms.ComboBox cmbMotif;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
    }
}