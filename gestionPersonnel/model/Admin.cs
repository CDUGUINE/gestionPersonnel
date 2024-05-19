using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionPersonnel.model
{    /// <summary>
     /// Classe métier interne pour mémoriser les informations d'authentification
     /// </summary>
    public class Admin
    {
        public string Nom { get; }
        public string Pwd { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="pwd"></param>
        public Admin(string nom, string pwd)
        {
            this.Nom = nom;
            this.Pwd = pwd;
        }
    }
}
