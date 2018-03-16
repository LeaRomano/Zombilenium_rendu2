using System;
namespace Zombilenium_rendu2
{
    public class Fantome : Monstre
    {
        public Fantome(int matricule, string nom, string prenom, TypeSexe sexe,int cagnotte, Attraction affectation,string fonction) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
        }
    }
}
