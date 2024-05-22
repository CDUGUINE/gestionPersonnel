﻿using gestionPersonnel.dal;
using gestionPersonnel.model;
using System.Collections.Generic;

namespace gestionPersonnel.controller
{
    /// <summary>
    /// Contrôleur de FrmGestionPersonnel
    /// </summary>
    class FrmAbsencesController
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
        /// Récupère les acces aux données
        /// </summary>
        public FrmAbsencesController()
        {
            absencesAccess = new AbsencesAccess();
            motifAccess = new MotifAccess();
        }

        /// <summary>
        /// Récupère et retourne les infos des absences
        /// </summary>
        /// <returns>liste des personnels</returns>
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
        public void UpdateAbsence(Absence absence)
        {
            absencesAccess.UpdateAbsence(absence);
        }
    }
}