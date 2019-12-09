using System;
using System.IO;
using System.Collections.Generic;

namespace harjoitustyö2
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                char previousKey = '.', previousPrevious = '.';

                bool isoKirjain = true, lauseenLoppu = true, onEdellinen = false, onEdellinenEdellinen = false;
                List<string> outputText = new List<string>();
                string inputText = File.ReadAllText("inputfile.txt");


                foreach (char key in inputText)
                {
                    //Kaksi peräkkäistä if-lauseketta, että tiedetään, miten seuraavan kirjaimen tulee käyttäytyä, nykyisen perusteella.
                    //Jos kirjain on jokin näistä välimerkeistä, on virke loppunut ja seuraavan kirjaimen pitäisi olla iso.
                    if (!onEdellinen)
                    {
                        previousKey = key;
                        previousPrevious = previousKey;
                        onEdellinen = true;
                    } else if (!onEdellinenEdellinen && onEdellinen)
                    {
                        previousKey = key;
                        previousPrevious = previousKey;
                        onEdellinenEdellinen = true;
                    } else
                    {

                    }
                    
                    if (previousPrevious == '.' || previousPrevious == '?' || previousPrevious == ':' || previousPrevious == '!' || previousPrevious == '\n')
                    {
                        lauseenLoppu = true;
                    }
                    if (onEdellinen && !char.IsPunctuation(previousKey) && !(previousKey == ' ') && char.IsUpper(previousKey) && char.IsLower(key))
                    {
                        isoKirjain = true;
                    } else if (onEdellinen && !(previousPrevious == ' ') && char.IsUpper(previousKey) && char.IsLower(key))
                    {
                        isoKirjain = false;
                    }
                    if (isoKirjain && onEdellinen)
                    {
                        outputText.Add(char.ToUpper(previousKey).ToString());
                        previousKey = key;
                        previousPrevious = previousKey;
                        isoKirjain = false;
                    }
                    else if (onEdellinen && lauseenLoppu)
                    {
                        outputText.Add(char.ToUpper(previousKey).ToString());
                        previousKey = key;
                        previousPrevious = previousKey;
                        lauseenLoppu = false;
                    } else if (onEdellinen && !isoKirjain)
                    {
                        outputText.Add(char.ToLower(previousKey).ToString());
                        previousKey = key;
                        previousPrevious = previousKey;
                        isoKirjain = false;
                    } 



                }
                //Kirjoitetaan listan sisältö tiedostoon.
                using (StreamWriter outputFile = File.AppendText("outputfile.txt"))
                {
                    outputFile.Write("\n");
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
                Console.ReadKey();
                //Jos halutaan tietää mitä ollaan kirjoitettu, niin käytetään tätä koodinpätkää 

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
