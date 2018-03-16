using System;
using System.Collections.Generic;

namespace Zombilenium_rendu2
{
    public class Spectacles : Attraction
    {
        List<DateTime> horaire;
        int nombrePlace;
        string nomSalle;

        public Spectacles(bool besoinSpecifique, TimeSpan DureeMaintenance, List<Monstre> equipe, int identifiant, bool maintenance, string natureMaintenance, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin, List<DateTime> horaire, int nombrePlace, string nomSalle) : base(besoinSpecifique, DureeMaintenance, equipe, identifiant, maintenance, natureMaintenance,nbMinMonstre,nom,ouvert,typeDeBesoin)
        {
            this.horaire = horaire;
            this.nombrePlace = nombrePlace;
            this.nomSalle = nomSalle;
        }
    }
}
