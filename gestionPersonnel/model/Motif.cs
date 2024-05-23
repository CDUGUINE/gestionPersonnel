namespace gestionPersonnel.model
{
    /// <summary>
    /// classe métier liée à la table absence
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// nombre entier permettant d'identifier le motif (clé primaire de la table motif)
        /// </summary>
        public int Idmotif { get; }
        /// <summary>
        /// libellé du motif
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idmotif">clé de la table motif</param>
        /// <param name="nom">libellé du motif</param>
        public Motif(int idmotif, string nom)
        {
            this.Idmotif = idmotif;
            this.Nom = nom;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du motif</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
