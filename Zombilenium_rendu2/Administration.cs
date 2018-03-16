using System;
using System.Collections.Generic;

namespace Zombilenium_rendu2
{
    public class Administration
    {
        List<Attraction> attractions;
        List<Personnel> toutLePersonnel;

        public Administration(List<Attraction> attractions,List<Personnel> toutLePersonnel)
        {
            this.attractions = attractions;
            this.toutLePersonnel = toutLePersonnel;
        }

        public List<Personnel> ToutLePersonnel { get => toutLePersonnel; }
    }
}
