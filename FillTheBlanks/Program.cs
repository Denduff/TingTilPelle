
namespace FillTheBlanks
{

    public class Program
    {


        //Her starter projektet / koden. Koden starter altid i Main
        static void Main()
        {
            WordGame wordlist = new WordGame();


            wordlist.ShowSentence();
            wordlist.SaveToFile(@"Sentence.txt", WordGame.Mode.Append);
            wordlist.FillEmpties();
            wordlist.ShowSentence();
            wordlist.SaveToFile(@"Sentence.txt", WordGame.Mode.Append);


            wordlist.NewSentence();
            wordlist.ShowSentence();
            wordlist.SaveToFile(@"Sentence.txt", WordGame.Mode.Append);
            wordlist.FillEmpties();
            wordlist.ShowSentence();
            wordlist.SaveToFile(@"Sentence.txt", WordGame.Mode.Append);


            //check fil


            Console.ReadLine();

            //tryk enter
            wordlist.SaveToFile(@"Sentence.txt", WordGame.Mode.Overwrite);

           
        }



    }
}