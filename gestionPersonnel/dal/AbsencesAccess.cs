﻿using gestionPersonnel.model;
using System;
using System.Collections.Generic;

namespace gestionPersonnel.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les absences
    /// </summary>
    public class AbsencesAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AbsencesAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les absences
        /// </summary>
        /// <param name="idperso">identifiant du personnel</param>
        /// <returns>liste des absences</returns>
        public List<Absence> GetLesAbsences(int idperso)
        {
            List<Absence> lesAbsences = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "select p.idpersonnel as idpersonnel, a.datedebut as datedebut, a.datefin as datefin, a.idmotif as idmotif, m.libelle as motif ";
                req += "from personnel p join absence a on (p.idpersonnel = a.idpersonnel) ";
                req += "join motif m on (a.idmotif = m.idmotif) ";
                req += "where p.idpersonnel = " + idperso;
                req += " order by datedebut desc;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Motif motif = new Motif((int)record[3], (string)record[4]);

                            Absence absence = new Absence((int)record[0], (DateTime)record[1], (DateTime)record[2], motif);
                            lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }
        
        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "delete from absence where idpersonnel = @idpersonnel and datedebut = @datedebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", absence.Idpersonnel },
                    { "@datedebut", absence.DateDebut }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "insert into absence(idpersonnel, datedebut, datefin, idmotif) ";
                req += "values (@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", absence.Idpersonnel },
                    { "@datedebut", absence.DateDebut },
                    { "@datefin", absence.DateFin },
                    { "@idmotif", absence.Motif.Idmotif }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        /// <param name="date">date de début</param>
        public void UpdateAbsence(Absence absence, DateTime date)
        {
            if (access.Manager != null)
            {
                string req = "update absence set datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif ";
                req += "where idpersonnel = @idpersonnel and datedebut = @datedebinit;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idPersonnel", absence.Idpersonnel },
                    { "@datedebinit", date },
                    { "@datedebut", absence.DateDebut },
                    { "@datefin", absence.DateFin },
                    { "@idmotif", absence.Motif.Idmotif }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
