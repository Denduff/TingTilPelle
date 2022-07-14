using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheBlanks
{
    public class WordGame
    {
        //_ = names
        //? = verbs
        //- = adjectives
        private enum WordType
        {
            Names,
            Verbs,
            Adjectives
        }

        List<string> Names = new List<string>();
        List<string> Verbs = new List<string>();
        List<string> Adjectives = new List<string>();
        List<string> Sentences = new();
        string CurrentSentence = "";
        public WordGame()
        {
            //populate lists default
            Sentences = new List<string>
            {
                "_ tager på søndagstur med resten af sin familie han håber på det bliver - så hyggeligt. Måske får han lov at ?. ",
                "Jeg ved ikke hvem _ er, men måske du kan gætte det ved at ? -",
                "Pelle har lavet et - program. Tror du _ kan finde ud af at ? det."
            };
            Verbs = new List<string>
            {
                "være",
                "have",
                "blive",
                "ville",
                "få",
                "komme",
                "gå",
                "gøre",
                "kunne",
                "skulle"

            };
            Names = new List<string>
            {
                "Emma",
                "Isabella",
                "Laura",
                "Ida",
                "Clara",
                "William",
                "Oliver",
                "Noah",
                "Emil",
                "Victor"
            };
            Adjectives = new List<string>
            {
                "billig",
                "betydelig",
                "grim",
                "ond",
                "speciel",
                "blød",
                "dum"
            };

            Random random = new Random();
            CurrentSentence = Sentences[random.Next(0, Sentences.Count - 1)];


        }
        public WordGame(List<string> sentences)
        {
            this.Sentences = sentences;
        }
        public WordGame(List<string> names, List<string> verbs, List<string> adjectives, List<string> sentences, string currentSentence)
        {
            Names = names;
            Verbs = verbs;
            Adjectives = adjectives;
            Sentences = sentences;
        }

        public void NewSentence()
        {
            Random random = new Random();
            CurrentSentence = Sentences[random.Next(0, Sentences.Count - 1)];
        }
        public void ShowSentence()
        {
            Console.WriteLine(CurrentSentence);
        }

        private string GetSentence()
        {
            return CurrentSentence;
        }

        public void FillEmpties()
        {
            while (CurrentSentence.Contains("-") != false || CurrentSentence.Contains("?") != false || CurrentSentence.Contains("_") != false)
            {
                if (CurrentSentence.Contains("_"))
                {
                    var word = GetWord(WordType.Names);               
                    CurrentSentence = CurrentSentence.ReplaceFirst("_", word);
                }
                if (CurrentSentence.Contains("?"))
                {
                    var word = GetWord(WordType.Verbs);
                    CurrentSentence = CurrentSentence.ReplaceFirst("?", word);
                }
                if (CurrentSentence.Contains("-"))
                {
                    var word = GetWord(WordType.Adjectives);
                    CurrentSentence = CurrentSentence.ReplaceFirst("-", word);
                }
            }
        }

        private string GetWord(WordType type)
        {
            Random random = new Random();
            switch (type)
            {
                case WordType.Names:
                    return Names[random.Next(0, Names.Count - 1)];
                case WordType.Verbs:
                    return Verbs[random.Next(0, Verbs.Count - 1)];
                case WordType.Adjectives:
                    return Adjectives[random.Next(0, Adjectives.Count - 1)];
                default: return "";

            }
        }

        public enum Mode
        {
            Append,
            Overwrite
        }

        public void SaveToFile(string filePath, Mode mode)
        {
            if (mode == Mode.Append)
            {
                using (StreamWriter file = new StreamWriter(filePath,true))
                {
                    file.WriteLine(CurrentSentence);
                }
            }
            if(mode == Mode.Overwrite)
            {
                using (StreamWriter file = new StreamWriter(filePath))
                {
                    file.WriteLine(CurrentSentence);
                }
            }
        }
    }
}
