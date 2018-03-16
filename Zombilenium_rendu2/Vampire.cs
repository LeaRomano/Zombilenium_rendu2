using System;
namespace Zombilenium_rendu2
{
    public class Vampire : Monstre
    {
        private int force;
        public Vampire(int matricule, string nom, string prenom, TypeSexe sexe, string fonction ,int cagnotte, Attraction affectation, int force) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.force = force;
        }
    }
}
