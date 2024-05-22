using System;

namespace gestionPersonnel.model
{
    /// <summary>
    /// Classe métier liée à la table Absence
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
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
        /// nom du personnel
        /// </summary>
        public DateTime DateDebut { get; set; }
        /// <summary>
        /// prénom du personnel
        /// </summary>
        public DateTime DateFin { get; set; }
        /// <summary>
        /// numéro de téléphone du personnel
        /// </summary>
        public Motif Motif { get; set; }
    }
}
