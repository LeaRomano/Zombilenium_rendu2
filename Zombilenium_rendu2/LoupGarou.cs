using System;
namespace Zombilenium_rendu2
{
    public class LoupGarou : Monstre
    {
        int indiceCruaute;

        public LoupGarou(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte,  Attraction affectation, int indiceCruaute) : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.indiceCruaute = indiceCruaute;
        }
    }
}
