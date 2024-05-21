using gestionPersonnel.controller;
using gestionPersonnel.dal;
using gestionPersonnel.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gestionPersonnel.view
{
    /// <summary>
    /// fenêtre permettant d'afficher tous les personnels
    /// </summary>
    public partial class frmGestionPersonnel : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;
        /// <summary>
        /// Objet pour gérer la liste des personnels
        /// </summary>
        private BindingSource bdgPersonnels = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        private BindingSource bdgServices = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmGestionPersonnelController controller;

        /// <summary>
        /// initialisation de la fenêtre
        /// </summary>
        public frmGestionPersonnel()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmGestionPersonnelController();
            RemplirListePersonnels();
            RemplirListeServices();
            grbEdition.Text = "personnel";
        }

        /// <summary>
        /// Affiche les personnels
        /// </summary>
        private void RemplirListePersonnels()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            dgvPersonnel.DataSource = bdgPersonnels;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPersonnel.ClearSelection();
        }

        /// <summary>
        /// Affiche les services
        /// </summary>
        private void RemplirListeServices()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgServices.DataSource = lesServices;
            cboService.DataSource = bdgServices;
            cboService.SelectedItem = null;
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            ViderSaisie();
            EnCoursDeModifPersonnel(false);
            txtNom.Focus();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            String nom = txtNom.Text;
            String prenom = txtPrenom.Text;
            String tel = txtTel.Text;
            String mail = txtMail.Text;
            Service service = new Service(cboService.SelectedIndex + 1, cboService.Text);
            if (String.IsNullOrEmpty(nom) || String.IsNullOrEmpty(prenom) || String.IsNullOrEmpty(tel) || String.IsNullOrEmpty(mail))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                if (enCoursDeModifPersonnel)
                {
                    Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                    personnel.Nom = nom;
                    personnel.Prenom = prenom;
                    personnel.Tel = tel;
                    personnel.Mail = mail;
                    personnel.Service = service;
                    controller.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(1, nom, prenom, tel, mail, service);
                    controller.AddPersonnel(personnel);
                }
                
                RemplirListePersonnels();
                ViderSaisie();
            }
        }

        /// <summary>
        /// vide les zones de saisies et désactive le groupe grbEdition
        /// </summary>
        private void ViderSaisie()
        {
            txtNom.Text = String.Empty;
            txtPrenom.Text = String.Empty;
            txtTel.Text = String.Empty;
            txtMail.Text = String.Empty;
            cboService.SelectedItem = null;
            grbEdition.Enabled = false;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ViderSaisie();
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        ///  Demande de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                EnCoursDeModifPersonnel(true);
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cboService.SelectedIndex = cboService.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'un personnel
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursDeModifPersonnel(Boolean modif)
        {
            enCoursDeModifPersonnel = modif;
            grbEdition.Enabled = true;
            if (modif)
            {
                grbEdition.Text = "modifier un personnel";
            }
            else
            {
                grbEdition.Text = "ajouter un personnel";
            }
        }
    }
}
