using System;
using System.Collections.Generic;

namespace Zombilenium_rendu2
{
    public abstract class Attraction
    {
        bool besoinSpecifique;
        TimeSpan DureeMaintenance;
        List<Monstre> equipe;
        int identifiant;
        bool maintenance;
        string natureMaintenance;
        int nbMinMonstre;
        string nom;
        bool ouvert;
        string typeDeBesoin;

        public Attraction(bool besoinSpecifique,TimeSpan DureeMaintenance,List<Monstre> equipe,int identifiant, bool maintenance, string natureMaintenance, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin)
        {
            this.besoinSpecifique = besoinSpecifique;
            this.DureeMaintenance = DureeMaintenance;
            this.equipe = equipe;
            this.identifiant = identifiant;
            this.maintenance = maintenance;
            this.natureMaintenance = natureMaintenance;
            this.nbMinMonstre = nbMinMonstre;
            this.nom = nom;
            this.ouvert = ouvert;
            this.typeDeBesoin = typeDeBesoin;
        }
    }
}
