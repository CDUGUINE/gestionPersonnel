namespace gestionPersonnel.model
{    /// <summary>
     /// Classe métier interne pour mémoriser les informations d'authentification
     /// </summary>
    public class Admin
    {
        /// <summary>
        /// nom de l'administrateur
        /// </summary>
        public string Nom { get; }
        /// <summary>
        /// mot de passe de l'administrateur
        /// </summary>
        public string Pwd { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="nom">nom de l'utilisateur</param>
        /// <param name="pwd">mot de passe</param>
        public Admin(string nom, string pwd)
        {
            this.Nom = nom;
            this.Pwd = pwd;
        }
    }
}
