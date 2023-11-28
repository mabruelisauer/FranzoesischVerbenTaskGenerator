using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranzösischVerbenAufgabenGenerator
{
    public class Task
    {
        public void GenerateTask()
        {
            int verb = GenerateVerb();
            int person = GeneratePerson();

            string stringVerb = GetStringVerb(verb);
            string stringPerson = GetStringPerson(person);

            Console.WriteLine($"Konjugiere das Verb {stringVerb} mit der Person {stringPerson}");
            string input = Console.ReadLine();
            if ( LoesungKorrekt(input, verb, person) ) 
            {
                Console.WriteLine("Richtig!");
            }
            else 
            { 
                string lösung = conjugationArrays[verb - 1][person - 1];
                Console.WriteLine($"Falsch! Die richtige Loesung waere {lösung}."); 
            }
        }

        public int GenerateVerb()
        {
            Random r = new Random();

            return r.Next(1, 11);
        }

        public int GeneratePerson()
        {
            Random r = new Random();

            return r.Next(1, 7);
        }

        public string GetStringVerb(int verb)
        {
            if (verb == 1) { return "aller"; }
            else if (verb == 2) { return "faire"; }
            else if (verb == 3) { return "etre"; }
            else if (verb == 4) { return "vouloir"; }
            else if (verb == 5) { return "pouvoir"; }
            else if (verb == 6) { return "devoir"; }
            else if (verb == 7) { return "avoir"; }
            else if (verb == 8) { return "savoir"; }
            else if (verb == 9) { return "prendre"; }
            else if (verb == 10) { return "mettre"; }
            else throw new ArgumentException();
        }

        public string GetStringPerson(int person)
        {
            if (person == 1) { return "je"; }
            else if (person == 2) { return "tu"; }
            else if (person == 3) { return "il/on/elle"; }
            else if (person == 4) { return "nous"; }
            else if (person == 5) { return "vous"; }
            else if (person == 6) { return "ils/elles"; }
            else throw new ArgumentException();
        }

        string[][] conjugationArrays = {
            new string[] {"vais", "vas", "va", "allons", "allez", "vont"},
            new string[] {"fais", "fais", "fait", "faisons", "faites", "font"},
            new string[] {"suis", "es", "est", "sommes", "êtes", "sont"},
            new string[] {"veux", "veux", "veut", "voulons", "voulez", "veulent"},
            new string[] {"peux", "peux", "peut", "pouvons", "pouvez", "peuvent"},
            new string[] {"dois", "dois", "doit", "devons", "devez", "doivent"},
            new string[] {"ai", "as", "a", "avons", "avez", "ont"},
            new string[] {"sais", "sais", "sait", "savons", "savez", "savent"},
            new string[] {"prends", "prends", "prend", "prenons", "prenez", "prennent"},
            new string[] {"mets", "mets", "met", "mettons", "mettez", "mettent"}
        };

        public bool LoesungKorrekt(string input, int verb, int person)
        {
            string Loesung = conjugationArrays[verb-1][person-1];
            if (input == Loesung)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
