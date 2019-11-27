using System;
using System.IO;
using System.Collections.Generic;

namespace Harjoitustyö
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                char previousKey = ' ';
                
                bool lauseenLoppu = true, isoKirjain = false;
                List<string> outputText = new List<string>();
                string inputText = File.ReadAllText("inputfile.txt");
                

                foreach (char key in inputText)
                {
                    //Kaksi peräkkäistä if-lauseketta, että tiedetään, miten seuraavan kirjaimen tulee käyttäytyä, nykyisen perusteella.
                    if (key == '.' || key == '?' || key == ':' || key == '!' || key == '\n')
                    {
                        lauseenLoppu = true;
                    }
                    else if (previousKey == ' ' && char.IsUpper(key))
                    {
                        isoKirjain = true;
                    }
                    
                    previousKey = key;

                    if (lauseenLoppu)
                    {
                        outputText.Add(char.ToUpper(previousKey).ToString());
                        lauseenLoppu = false;
                    }
                    else if (isoKirjain && char.IsUpper(previousKey) && char.IsLower(key))
                    {
                        outputText.Add(char.ToUpper(previousKey).ToString());
                        isoKirjain = false;
                    } 
                    else
                    {
                        outputText.Add(char.ToLower(previousKey).ToString());
                    }
                }
                //Kirjoitetaan listan sisältö tiedostoon.
                using (StreamWriter outputFile = File.AppendText("outputfile.txt"))
                {
                    foreach (string line in outputText)
                    {
                        outputFile.Write(line.ToString());
                    }
                }
                /*
                string[] allLines = File.ReadAllLines("outputfile.txt");
                foreach (string line in allLines)
                {
                    Console.WriteLine(line);
                }
                Jos halutaan tietää mitä ollaan kirjoitettu, niin käytetään tätä koodinpätkää */

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
