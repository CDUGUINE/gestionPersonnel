using System;

namespace gestionPersonnel.model
{
    /// <summary>
    /// Classe métier liée à la table absence
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel">clé de la table personnel</param>
        /// <param name="dateDebut">date de début de l'absence</param>
        /// <param name="dateFin">date de fin de l'absence</param>
        /// <param name="motif">motif de l'absence</param>
        public Absence(int idpersonnel, DateTime dateDebut, DateTime dateFin, Motif motif)
        {
            this.Idpersonnel = idpersonnel;
            this.DateDebut = dateDebut;
            this.DateFin = dateFin;
            this.Motif = motif;
        }

        /// <summary>
        /// nombre entier autoincrémenté permettant d'identifier chaque personnel (clé primaire de la table personnel)
        /// </summary>
        public int Idpersonnel { get; }
        /// <summary>
        /// date de début
        /// </summary>
        public DateTime DateDebut { get; set; }
        /// <summary>
        /// date de fin
        /// </summary>
        public DateTime DateFin { get; set; }
        /// <summary>
        /// motif de l'absence
        /// </summary>
        public Motif Motif { get; set; }
    }
}
