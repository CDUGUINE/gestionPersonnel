
namespace gestionPersonnel.view
{
    partial class frmGestionPersonnel
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
            this.lstPersonnel = new System.Windows.Forms.ListBox();
            this.grpPersonnel = new System.Windows.Forms.GroupBox();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.grpAbsences = new System.Windows.Forms.GroupBox();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.grpPersonnel.SuspendLayout();
            this.grpAbsences.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPersonnel
            // 
            this.lstPersonnel.FormattingEnabled = true;
            this.lstPersonnel.Location = new System.Drawing.Point(13, 12);
            this.lstPersonnel.Name = "lstPersonnel";
            this.lstPersonnel.ScrollAlwaysVisible = true;
            this.lstPersonnel.Size = new System.Drawing.Size(162, 173);
            this.lstPersonnel.TabIndex = 0;
            // 
            // grpPersonnel
            // 
            this.grpPersonnel.Controls.Add(this.btnModifier);
            this.grpPersonnel.Controls.Add(this.btnSupprimer);
            this.grpPersonnel.Controls.Add(this.btnNouveau);
            this.grpPersonnel.Location = new System.Drawing.Point(181, 12);
            this.grpPersonnel.Name = "grpPersonnel";
            this.grpPersonnel.Size = new System.Drawing.Size(92, 112);
            this.grpPersonnel.TabIndex = 1;
            this.grpPersonnel.TabStop = false;
            this.grpPersonnel.Text = "personnel";
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(7, 20);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(75, 23);
            this.btnNouveau.TabIndex = 0;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(7, 50);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(7, 80);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // grpAbsences
            // 
            this.grpAbsences.Controls.Add(this.btnAfficher);
            this.grpAbsences.Location = new System.Drawing.Point(181, 131);
            this.grpAbsences.Name = "grpAbsences";
            this.grpAbsences.Size = new System.Drawing.Size(92, 54);
            this.grpAbsences.TabIndex = 2;
            this.grpAbsences.TabStop = false;
            this.grpAbsences.Text = "absences";
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(7, 20);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(75, 23);
            this.btnAfficher.TabIndex = 0;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            // 
            // frmGestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 200);
            this.Controls.Add(this.grpAbsences);
            this.Controls.Add(this.grpPersonnel);
            this.Controls.Add(this.lstPersonnel);
            this.Name = "frmGestionPersonnel";
            this.Text = "Gestion du personnel";
            this.grpPersonnel.ResumeLayout(false);
            this.grpAbsences.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPersonnel;
        private System.Windows.Forms.GroupBox grpPersonnel;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.GroupBox grpAbsences;
        private System.Windows.Forms.Button btnAfficher;
    }
}