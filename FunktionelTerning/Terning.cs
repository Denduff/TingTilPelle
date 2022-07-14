using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunktionelTerning
{
    //klasse
    public class Terning
    {
        //Constructor. Hvis man ønsker at noget skal gøres hver gang man opretter et nyt objekt af Terning kan man komme det herind.
        //F.eks. parametre(Information man ønsker at give med) eller lign.
        public Terning()
        {

        }

        //Nedenstående er en offentlig tilgængelig metode/funktion, som kan kaldes på objekter af terning i andre filer/klasser/metoder.
        //antalKast er det tal, som man giver med(parameter), når man kalder metoden på objektet. Dette tal repræsenterer antallet af kast vi ønsker udført.
        public List<int> KastTerning(int antalKast)
        {
            //indbygget random generator
            Random random = new Random();
            //en liste af tal
            List<int> listeMedResultaterAfKast = new List<int>();

            //Et for-loop har 3 parametre.
            //det første er en variable man ønsker at ændre på for hvert gennemløb.
            //Dette kaldes en counter, som man bruger til at holde styr på, hvor mange gennemløb i loopet man har udført.

            //det næste er "stopklodsen" dvs. når dette ikke længere er sandt så stopper man.

            //Det 3. er iteratoren/step-mekanismen. ++ betyder at man øger variablen "i" (counteren) med 1 for hvert gennemløb indtil at variablen "i" ikke længere er mindre end "antalKast"
            for (int i = 0; i < antalKast; i++)
            {
                //generer et tal mellem 1 og 6 
                int terningkast = random.Next(1, 6);

                //tilføj det derefter til listen med resultater af alle kastene
                listeMedResultaterAfKast.Add(terningkast);
            }

            //returner listen med alle kast værdierne således, at man kan gemme dem efter man har kaldt metoden.
            return listeMedResultaterAfKast;
        }
    }
}
