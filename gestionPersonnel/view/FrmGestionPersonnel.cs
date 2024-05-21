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
        private PersonnelAccess personnelAccess = new PersonnelAccess();


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
            //EnCoursModifPersonnel(false);
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
            grpEdition.Enabled = true;
            /*frmEditionPersonnel frm = new frmEditionPersonnel();
            //this.Close();
            frm.Text = "Nouveau personnel";
            frm.ShowDialog();*/
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
                List<Personnel> lesPersonnels = controller.GetLesPersonnels();
                int idPersonnel = lesPersonnels.Count + 1;
                Personnel personnel = new Personnel(idPersonnel, nom, prenom, tel, mail, service);
                personnelAccess.AddPersonnel(personnel);
                RemplirListePersonnels();
                ViderSaisie();
            }
        }

        /// <summary>
        /// vide les zones de saisies et désactive le groupe grpEdition
        /// </summary>
        private void ViderSaisie()
        {
            txtNom.Text = String.Empty;
            txtPrenom.Text = String.Empty;
            txtTel.Text = String.Empty;
            txtMail.Text = String.Empty;
            cboService.SelectedItem = null;
            grpEdition.Enabled = false;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ViderSaisie();
        }
    }
}
