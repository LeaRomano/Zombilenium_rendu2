using System;
using System.Collections.Generic;

namespace Zombilenium_rendu2
{
    public class RollerCoaster : Attraction
    {
        int ageMinimum;
        TypeCategorie categorie;
        float tailleMinimum;
        public RollerCoaster(bool besoinSpecifique, TimeSpan DureeMaintenance, List<Monstre> equipe, int identifiant, bool maintenance, string natureMaintenance, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin, int ageMinimum, TypeCategorie categorie, float tailleMimimum) : base(besoinSpecifique, DureeMaintenance, equipe, identifiant, maintenance, natureMaintenance, nbMinMonstre, nom, ouvert, typeDeBesoin)
        {
            this.ageMinimum = ageMinimum;
            this.categorie = categorie;
            this.tailleMinimum = tailleMimimum;
        }
    }
}
