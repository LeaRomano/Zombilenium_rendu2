using System;
using System.Collections.Generic;

namespace Zombilenium_rendu2
{
    public class Sorcier : Personnel
    {
        Grade tatouage;
        List<String> pouvoirs;


        public Sorcier(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, List<String> pouvoirs, Grade tatouage) : base(matricule, nom, prenom, sexe, fonction)
        {
            this.pouvoirs = pouvoirs;
            this.tatouage = tatouage;
        }

		public override string ToString()
		{
            return string.Format(base.ToString() + tatouage + pouvoirs);
		}
	}
}
