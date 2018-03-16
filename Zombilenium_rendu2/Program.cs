using System;
using System.Collections.Generic;
using System.IO;

namespace Zombilenium_rendu2
{
    class MainClass
    {
        static Administration LectureFichier(string nomfichier)
        {
            StreamReader monStreamReader = new StreamReader(nomfichier);
            List<Attraction> attractions = new List<Attraction>();
            List<Personnel> personnels = new List<Personnel>();

            string ligne = monStreamReader.ReadLine();

            while (ligne != null)
            {
                string[] temp = ligne.Split(';');

                for (int i = 0; i < temp.Length;i++)
                {
                    Console.Write(temp[i] + " - ");
                }
                if (temp[0] == "Sorcier")
                {
                    int matrice = Convert.ToInt32(temp[1]);
                    TypeSexe sexe = TypeSexe.autre;
                    if (temp[4] == "femelle")
                    {
                         sexe = TypeSexe.femelle;
                    }
                    if (temp[4] == "male")
                    {
                         sexe = TypeSexe.male;
                    }
                    string[] pouvoir = temp[6].Split('-');
                    List<string> listePouvoir = new List<string>();

                    for (int i = 0; i < pouvoir.Length; i++)
                    {
                        listePouvoir.Add(pouvoir[i]);
                    }
                    Grade gradeDuSorcier = Grade.Novice;

                    if (temp[7] == "Giga")
                    {
                        gradeDuSorcier = Grade.Giga;
                    }
                    if (temp[7] == "Mega")
                    {
                        gradeDuSorcier = Grade.Mega;
                    }
                    if(temp[7] == "strata")
                    {
                        gradeDuSorcier = Grade.Strata;
                    }

                    Sorcier sorciers = new Sorcier(matrice, temp[2], temp[3], sexe, temp[5], listePouvoir, gradeDuSorcier);
                    personnels.Add(sorciers); //d
                }

              
                ligne = monStreamReader.ReadLine();
                Console.WriteLine("");
            }
         
            monStreamReader.Close();
            return new Administration(attractions, personnels);
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Administration administration = LectureFichier("Listing.csv");
            foreach(Personnel p in administration.ToutLePersonnel)
            {
                Console.WriteLine(p);
            }



        }
        static int ComparerZombie(Monstre m1, Monstre m2) //en fonction de leur cagnotte
        {
            if (m1 is Zombie && m2 is Zombie)
            {
                return (m1 as Zombie).Cagnotte.CompareTo((m2 as Zombie).Cagnotte);
            }
            else return +1;

        }

        static int ComparerDemon(Monstre m1, Monstre m2) //en fonction de force
        {
            if (m1 is Demon && m2 is Demon)
            {
                return (m1 as Demon).Force.CompareTo((m2 as Demon).Force);
            }
            else return +1;

        }

        static int ComparerVampire(Monstre m1, Monstre m2) //en fonction indice luminosité
        {
            if (m1 is Vampire && m2 is Vampire)
            {
                return (m1 as Vampire).IndiceLuminosite.CompareTo((m2 as Vampire).IndiceLuminosite);
            }
            else return +1;

        }

        static int ComparerFantome(Monstre m1, Monstre m2) //en fonction de cagnotte
        {
            if (m1 is Fantome && m2 is Fantome)
            {
                return (m1 as Fantome).Cagnotte.CompareTo((m2 as Fantome).Cagnotte);
            }
            else return +1;

        }

        static int ComparerLoupGarou(Monstre m1, Monstre m2) //en fonction de indice cruauté
        {
            if (m1 is LoupGarou && m2 is LoupGarou)
            {
                return (m1 as LoupGarou).IndiceCruaute.CompareTo((m2 as LoupGarou).IndiceCruaute);
            }
            else return +1;

        }

        static int ComparerSorcier(Monstre m1, Monstre m2) //en fonction de grade
        {
            if (m1 is Sorcier && m2 is Sorcier)
            {
                return (m1 as Sorcier).Tatouage.CompareTo((m2 as Sorcier).Tatouage);
            }
            else return +1;
            //coucou
        }








    }
}
