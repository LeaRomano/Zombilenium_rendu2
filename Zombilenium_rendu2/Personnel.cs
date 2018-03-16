using System;
namespace Zombilenium_rendu2
{
    public abstract class Personnel
    {
        private string fonction;
        private  int matricule;
        private  string nom;
        private  string prenom;
        private  TypeSexe sexe;

        public Personnel(int matricule, string nom, string prenom, TypeSexe sexe, string fonction)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.fonction = fonction;
        }
    }
}
