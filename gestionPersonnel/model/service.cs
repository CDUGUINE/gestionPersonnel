namespace gestionPersonnel.model
{
    /// <summary>
    /// Classe métier lié à la table service
    /// </summary>
    public class Service
    {
        /// <summary>
        /// nombre entier permettant d'identifier le service (clé primaire de la table service)
        /// </summary>
        public int Idservice { get; }
        /// <summary>
        /// nom du service
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idservice">clé de la table service</param>
        /// <param name="nom">nom du service</param>
        public Service(int idservice, string nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du service</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
