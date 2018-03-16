using System;
namespace Zombilenium_rendu2
{
    public class Zombie : Monstre
    {
        int degreDecomposition;
        CouleurZ teint;
        
        public Zombie(int matricule, string nom, string prenom, TypeSexe sexe, string fonction,int cagnotte, Attraction affectation, int degreDecomposition, CouleurZ teint) : base(matricule, nom, prenom, sexe, fonction,cagnotte, affectation)
        {
            this.degreDecomposition = degreDecomposition;
            this.teint = teint;
        }
    }
}
