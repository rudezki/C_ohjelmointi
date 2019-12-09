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
                    //Jos edellistä kirjainta ei ole, niin annetaan previousKey:lle arvo.
                    if (!onEdellinen)
                    {
                        previousKey = key;
                        onEdellinen = true;
                    }
                    //Jos edellinen arvo on, mutta ei edellisen edellistä, niin annetaan previousKey:lle ja previousPrevious:lle arvot
                    else if (!onEdellinenEdellinen && onEdellinen)
                    {
                        previousKey = key;
                        previousPrevious = previousKey;
                        onEdellinenEdellinen = true;
                    }
                    //Jos arvot ovat olemassa, ei tehdä mitään, koska ei tarvita
                    else
                    {

                    }
                    //Jos edellisin merkki on virkkeen päättävä tai uusi kappale, vaihdetaan lauseenLoppu positiiviseksi, että tiedetään seuraavan kirjaimen olevan suuri
                    if (previousPrevious == '.' || previousPrevious == '?' || previousPrevious == ':' || previousPrevious == '!' || previousPrevious == '\n')
                    {
                        lauseenLoppu = true;
                    }
                    //Jos sana alkaa isolla ja seuraava kirjain on pieni, oletetaan sen olevan erisnimi, ja yritetään aloittaa se isolla.
                    if (onEdellinen && !char.IsPunctuation(previousKey) && !(previousKey == ' ') && char.IsUpper(previousKey) && char.IsLower(key))
                    {
                        isoKirjain = true;
                    //Jos taas ei ole sanan alku kyseessä (edellisin kirjain ei ole välilyönti) niin oletetaan, ettei tule isoa kirjainta.
                    } else if (onEdellinen && !(previousPrevious == ' ') && char.IsUpper(previousKey) && char.IsLower(key))
                    {
                        isoKirjain = false;
                    }
                    //Jos lause on alkanut, tai kyseessä on erisnimi, niin keskimmäinen previousKey lisätään isolla listaan, ja laitetaan isoKirjain ja lauseenLoppu pois päältä, ettei seuraava kirjain ole isolla.
                    if ((isoKirjain || lauseenLoppu) && onEdellinen)
                    {
                        outputText.Add(char.ToUpper(previousKey).ToString());
                        previousKey = key;
                        previousPrevious = previousKey;
                        isoKirjain = false;
                        lauseenLoppu = false;
                    }
                    //Jos ei ole kumpikaan, niin lisätään pienellä kirjain.
                     else if (onEdellinen && !isoKirjain && !lauseenLoppu)
                    {
                        outputText.Add(char.ToLower(previousKey).ToString());
                        previousKey = key;
                        previousPrevious = previousKey;
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

                //Jos halutaan tietää mitä ollaan kirjoitettu, niin käytetään tätä koodinpätkää 
                foreach (string line in allLines)
                {
                    Console.WriteLine(line);
                }
                Console.ReadKey();

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
