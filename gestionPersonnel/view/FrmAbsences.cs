using gestionPersonnel.controller;
using gestionPersonnel.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gestionPersonnel.view
{
    /// <summary>
    /// fenêtre permettant de visualiser toutes les absences d'un personnel
    /// </summary>
    public partial class FrmAbsences : Form
    {
        /// <summary>
        /// variable publique pour transmettre idperso au formulaire d'absences 
        /// </summary>
        public int idperso;
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifAbsence = false;
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        private BindingSource bdgMotifs = new BindingSource();


        private FrmAbsencesController controller;

        /// <summary>
        /// stockage de la date de début avant modification
        /// </summary>
        public DateTime dateDebInit;

        /// <summary>
        /// initialisation de la fenêtre
        /// </summary>
        public FrmAbsences()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage de la liste des absences
        /// </summary>
        private void Init()
        {
            controller = new FrmAbsencesController();
            RemplirListeAbsences();
            RemplirListeMotifs();

        }

        /// <summary>
        /// Affiche les absences
        /// </summary>
        private void RemplirListeAbsences()
        {
            List<Absence> lesAbsences = controller.GetLesAbsences(idperso);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAbsences.ClearSelection();
        }

        /// <summary>
        /// Affiche les motifs
        /// </summary>
        private void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cboMotif.DataSource = bdgMotifs;
            cboMotif.SelectedItem = null;
        }

        private void FrmAbsences_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            ViderSaisie();
            EnCoursDeModifAbsence(false);
            calAbsence.Focus();
        }

        /// <summary>
        /// vide les zones de saisies et désactive le groupe grbEdition
        /// </summary>
        private void ViderSaisie()
        {
            calAbsence.SelectionStart = DateTime.Today;
            calAbsence.SelectionEnd = DateTime.Today;
            cboMotif.SelectedItem = null;
            grbEdition.Enabled = false;
        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'une absence
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursDeModifAbsence(Boolean modif)
        {
            enCoursDeModifAbsence = modif;
            grbEdition.Enabled = true;
            if (modif)
            {
                grbEdition.Text = "modifier une absence";
            }
            else
            {
                grbEdition.Text = "ajouter une absence";
            }
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            DateTime datedebut = calAbsence.SelectionStart;
            DateTime datefin = calAbsence.SelectionEnd;
            Motif motif = new Motif(cboMotif.SelectedIndex + 1, cboMotif.Text);
            if (cboMotif.SelectedIndex == -1)
            {
                MessageBox.Show("Le motif doit être renseigné.", "Information");
            }
            else
            {
                if (enCoursDeModifAbsence)
                {
                    Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                    absence.DateDebut = datedebut;
                    absence.DateFin = datefin;
                    absence.Motif = motif;
                    controller.UpdateAbsence(absence, dateDebInit);
                }
                else
                {
                    Absence absence = new Absence(idperso, datedebut, datefin, motif);
                    controller.AddAbsence(absence);
                }

                RemplirListeAbsences();
                ViderSaisie();
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            ViderSaisie();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                EnCoursDeModifAbsence(true);
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                calAbsence.SelectionStart = absence.DateDebut;
                dateDebInit = absence.DateDebut;
                calAbsence.SelectionEnd = absence.DateFin;
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.Motif.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer cette absence ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsences();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
    }
}
