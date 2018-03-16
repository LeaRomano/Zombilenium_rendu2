using System;
namespace Zombilenium_rendu2
{
    public class Monstre : Personnel
    {
        int cagnotte;
        Attraction affectation;
        public Monstre(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation) : base(matricule, nom, prenom, sexe, fonction)
        {
            this.cagnotte = cagnotte;
            this.affectation = affectation;
        }
    }
}
