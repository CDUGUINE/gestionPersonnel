namespace gestionPersonnel.model
{
    /// <summary>
    /// Classe métier liée à la table personnel
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel">clé de la table personnel</param>
        /// <param name="nom">nom</param>
        /// <param name="prenom">prénom</param>
        /// <param name="tel">numéro de téléphone</param>
        /// <param name="mail">adresse mail</param>
        /// <param name="service">service auquel le personnel est affecté</param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, Service service)
        {
            this.Idpersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Service = service;
        }

        /// <summary>
        /// nombre entier autoincrémenté permettant d'identifier chaque personnel (clé primaire de la table personnel)
        /// </summary>
        public int Idpersonnel { get; }
        /// <summary>
        /// nom du personnel
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// prénom du personnel
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// numéro de téléphone du personnel
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// adresse mail du personnel
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// service auquel le personnel est affecté
        /// </summary>
        public Service Service { get; set; }
    }
}
