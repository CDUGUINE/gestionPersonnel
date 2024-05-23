using gestionPersonnel.controller;
using gestionPersonnel.model;
using System;
using System.Windows.Forms;

namespace gestionPersonnel.view
{
    /// <summary>
    /// fenêtre permettant de se connecter à l'application
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FrmAuthentificationController controller;

        /// <summary>
        /// initialisation de la fenêtre
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations : 
        /// Création du contrôleur
        /// </summary>
        private void Init()
        {
            controller = new FrmAuthentificationController();
            txtNom.Focus();
        }

        /// <summary>
        /// Demande au contrôleur de controler la connexion
        /// </summary>
        /// <param name="sender">objet en paramètre</param>
        /// <param name="e">paramètre système</param>
        private void BtnValider_Click(object sender, EventArgs e)
        {
            String nom = txtNom.Text;
            String pwd = txtPwd.Text;
            if (String.IsNullOrEmpty(nom) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Admin admin = new Admin(nom, pwd);
                if (controller.ControleAuthentification(admin))
                {
                    this.Visible = false;
                    FrmGestionPersonnel frm = new FrmGestionPersonnel();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte", "Alerte");
                }
            }
        }
    }
}
