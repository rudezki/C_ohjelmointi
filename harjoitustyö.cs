using System;
using System.IO;
using System.Collections.Generic;

namespace hakkartyö
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                
                bool isoKirjain = true, lauseenLoppu = true;
                List<string> outputText = new List<string>();
                string inputText = File.ReadAllText("inputfile.txt");


                for (int i = 0; i < inputText.Length; i++)
                {
                    char key = inputText[i];
                    if (i == 1)
                    {
                        outputText.Add(char.ToUpper(inputText[i - 1]).ToString());
                        isoKirjain = false;
                    }
                    //Jos edellisin merkki on virkkeen päättävä tai uusi kappale, vaihdetaan lauseenLoppu positiiviseksi, että tiedetään seuraavan kirjaimen olevan suuri
                    if (i > 0 && (inputText[i-1] == '.' || inputText[i - 1] == '?' || inputText[i - 1] == ':' || inputText[i - 1] == '!' || inputText[i - 1] == '\n'))
                    {
                        lauseenLoppu = true;
                    }
                    //Jos sana alkaa isolla ja seuraava kirjain on pieni, oletetaan sen olevan erisnimi, ja yritetään aloittaa se isolla.
                    if (i > 1 && (inputText[i-2] == ' ' || inputText[i-2] == '"')  && !char.IsPunctuation(inputText[i-1]) && !(inputText[i - 1] == ' ') && char.IsUpper(inputText[i - 1]) && char.IsLower(inputText[i]))
                    {
                        isoKirjain = true;
                        //Jos taas ei ole sanan alku kyseessä (edellisin kirjain ei ole välilyönti) niin oletetaan, ettei tule isoa kirjainta.
                    }
                    else if (i > 1 && !(inputText[i-2] == ' ') && char.IsUpper(inputText[i-1]) && char.IsLower(inputText[i]))
                    {
                        isoKirjain = false;
                    }
                    //Jos lause on alkanut, tai kyseessä on erisnimi, niin keskimmäinen previousKey lisätään isolla listaan, ja laitetaan isoKirjain ja lauseenLoppu pois päältä, ettei seuraava kirjain ole isolla.
                    if ((isoKirjain || lauseenLoppu) && i > 1)
                    {
                        outputText.Add(char.ToUpper(inputText[i - 1]).ToString());
                        isoKirjain = false;
                        lauseenLoppu = false;
                    }
                    //Jos ei ole kumpikaan, niin lisätään pienellä kirjain.
                    else if (i > 1 && !isoKirjain && !lauseenLoppu)
                    {
                        outputText.Add(char.ToLower(inputText[i - 1]).ToString());
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
