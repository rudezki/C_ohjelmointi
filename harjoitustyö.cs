﻿using System;
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
                bool lauseenLoppu = true;
                List<string> outputText = new List<string>();
                string inputText = File.ReadAllText("inputfile.txt");
                //Tässä käytettäisiin RegExiä, jos haluttaisiin, ettei välilyöntiä oteta huomioon ollenkaan.
                //string withoutSpaces = normalizeSpace.Replace(inputText, " ");
                

                foreach (char key in inputText)
                {

                    if (char.IsPunctuation(key))
                    {
                        outputText.Add(key.ToString());
                        lauseenLoppu = true;
                    } else if (!(key == ' ') && lauseenLoppu)
                    {
                        outputText.Add(char.ToUpper(key).ToString());
                        lauseenLoppu = false;
                    } else if (char.IsUpper(previousKey) && char.IsUpper(key))
                    {
                        outputText.Add(char.ToLower(key).ToString());
                        previousKey = key;
                    } else
                    {
                        outputText.Add(key.ToString());
                        previousKey = key;
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
