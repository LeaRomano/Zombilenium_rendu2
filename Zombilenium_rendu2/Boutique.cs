using System;
using System.Collections.Generic;

namespace Zombilenium_rendu2
{
    public class Boutique : Attraction
    {
        TypeBoutique type;
        public Boutique(bool besoinSpecifique, TimeSpan DureeMaintenance, List<Monstre> equipe, int identifiant, bool maintenance, string natureMaintenance, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin, TypeBoutique type) : base(besoinSpecifique, DureeMaintenance, equipe, identifiant, maintenance, natureMaintenance, nbMinMonstre, nom, ouvert, typeDeBesoin)
        {
            this.type = type;
        }
    }
}
