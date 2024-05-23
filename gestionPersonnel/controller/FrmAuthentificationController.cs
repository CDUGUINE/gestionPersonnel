using gestionPersonnel.dal;
using gestionPersonnel.model;
using System;

namespace gestionPersonnel.controller
{
    /// <summary>
    /// Contrôleur de FrmAuthentification
    /// </summary>
    public class FrmAuthentificationController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Developpeur
        /// </summary>
        private readonly PersonnelAccess personnelAccess;

        /// <summary>
        /// Récupère l'accès aux données
        /// </summary>
        public FrmAuthentificationController()
        {
            personnelAccess = new PersonnelAccess();
        }

        /// <summary>
        /// Vérifie l'authentification
        /// </summary>
        /// <param name="admin">objet contenant les informations de connexion</param>
        /// <returns> vrai si les informations de connexion sont correctes</returns>
        public Boolean ControleAuthentification(Admin admin)
        {
            return personnelAccess.ControleAuthentification(admin);
        }
    }
}
