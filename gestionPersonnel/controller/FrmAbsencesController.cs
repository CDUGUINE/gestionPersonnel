using gestionPersonnel.dal;
using gestionPersonnel.model;
using System;
using System.Collections.Generic;

namespace gestionPersonnel.controller
{
    /// <summary>
    /// Contrôleur de FrmGestionPersonnel
    /// </summary>
    public class FrmAbsencesController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Developpeur
        /// </summary>
        private readonly AbsencesAccess absencesAccess;
        /// <summary>
        /// objet d'accès aux opérations possible sur Motif
        /// </summary>
        private readonly MotifAccess motifAccess;

        /// <summary>
        /// Récupère les accès aux données
        /// </summary>
        public FrmAbsencesController()
        {
            absencesAccess = new AbsencesAccess();
            motifAccess = new MotifAccess();
        }

        /// <summary>
        /// Récupère et retourne les infos des absences
        /// </summary>
        /// <param name="idperso">identifiant du personnel</param>
        /// <returns>liste des absences</returns>
        public List<Absence> GetLesAbsences(int idperso)
        {
            return absencesAccess.GetLesAbsences(idperso);
        }

        /// <summary>
        /// Récupère et retourne les infos des motifs
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            absencesAccess.AddAbsence(absence);
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        /// <param name="date">date de début</param>
        public void UpdateAbsence(Absence absence, DateTime date)
        {
            absencesAccess.UpdateAbsence(absence, date);
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            absencesAccess.DelAbsence(absence);
        }
    }
}
