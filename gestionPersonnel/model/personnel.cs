namespace gestionPersonnel.model
{
    /// <summary>
    /// Classe métier liée à la table Developpeur
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="service"></param>
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
