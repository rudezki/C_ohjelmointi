using System;
using System.IO;
using System.Collections.Generic;
//using System.Text.RegularExpressions;

namespace Harjoitustyö
{
    class Program
    {
        //Regexiä voidaan hyödyntää, että voidaan saada ohjelman olemaan huomioimatta välilyöntejä.
        //private static readonly Regex normalizeSpace =
        //new Regex(@"\s+", RegexOptions.Compiled);
        static void Main(string[] args)
        {
            try
            {
                char previousKey = 'g';
                
                bool lauseenLoppu = true, isoKirjain = true;
                List<string> outputText = new List<string>();
                string inputText = File.ReadAllText("inputfile.txt");
                //Tässä käytettäisiin RegExiä, jos haluttaisiin, ettei välilyöntiä oteta huomioon ollenkaan.
                //string withoutSpaces = normalizeSpace.Replace(inputText, " ");
                

                foreach (char key in inputText)
                {
                    //Kaksi peräkkäistä if-lauseketta, että tiedetään, miten seuraavan kirjaimen tulee käyttäytyä, nykyisen perusteella.
                    if (key == '.' || key == '?' || key == ':' || key == '!' || key == '\n')
                    {
                        isoKirjain = false;
                        lauseenLoppu = true;
                        previousKey = key;
                    }
                    else if (lauseenLoppu && (!(key == ' ')))
                    {
                        isoKirjain = true;
                        previousKey = key;
                    } else
                    {
                        isoKirjain = false;
                        previousKey = key;
                    }
                    if (isoKirjain)
                    {
                        outputText.Add(char.ToUpper(previousKey).ToString());
                        lauseenLoppu = false;
                    }
                    else if (!isoKirjain && char.IsLower(key) && char.IsUpper(previousKey))
                    {
                        outputText.Add(char.ToLower(previousKey).ToString());
                    }
                    else if (!isoKirjain && char.IsUpper(key) && char.IsUpper(previousKey))
                    {
                        outputText.Add(char.ToLower(previousKey).ToString());
                    }
                    else
                    {
                        outputText.Add(previousKey.ToString());
                    }

                }

                using (StreamWriter outputFile = File.AppendText("outputfile.txt"))
                {
                    foreach (string line in outputText)
                    {
                        outputFile.Write(line.ToString());
                    }
                }
                string[] allLines = File.ReadAllLines("outputfile.txt");
                foreach (string line in allLines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
