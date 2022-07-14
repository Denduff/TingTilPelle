
//Opgave 1 a
//

namespace OOPTerning;
public class Program
{


    //Her starter projektet / koden. Koden starter altid i Main
    static void Main()
    {
        //Oprettelse af en ny variable af typen Terning. Typen Terning er en "Klasse" og udarbejdes i filen Terning.cs.
        //Kig i Terning.cs for at forstå klassen. (Inden du læser videre)
        Terning teringObjekt = new Terning();

        //Funtionen KastTerning, som er oprettet i filen Terning.cs kan kun anvendes på variabler af typen Terning (hvilket terningObjekt er)
        //KastTerning returnerer resultaterne af det antal kast, vi har bedt om.
        List<int> results = teringObjekt.KastTerning(10);

        //Gør noget for hver resultalt i listen af resultater. Dette kaldes en foreach statement og bruges ofte til at gå igennem lister af informationer.
        foreach (var kast in results)
        {
            //for hver kast udskriv værdien af kastet.
            Console.WriteLine(kast);
        }


    }
}