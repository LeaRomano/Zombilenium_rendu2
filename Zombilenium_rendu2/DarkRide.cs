using System;
using System.Collections.Generic;

namespace Zombilenium_rendu2
{
    public class DarkRide : Attraction
    {
        TimeSpan duree;
        bool vehicule;
        public  DarkRide(bool besoinSpecifique, TimeSpan DureeMaintenance, List<Monstre> equipe, int identifiant, bool maintenance, string natureMaintenance, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin, TimeSpan duree, bool vehicule) : base(besoinSpecifique, DureeMaintenance, equipe, identifiant, maintenance, natureMaintenance, nbMinMonstre, nom, ouvert, typeDeBesoin)
        {
            this.duree = duree;
            this.vehicule = vehicule;
        }
    }
}
