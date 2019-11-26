using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_17_Pankkitili
{
    class Program
    {
        //Aliohjelmat double- ja int-lukujen syöttämiselle
        private static double DoubleCheck()
        {
            bool result;
            double number;
            string syote;
            syote = Console.ReadLine();
            result = Double.TryParse(syote, out number);
            return number;
        }
        private static int IntCheck()
        {
            bool result;
            int number;
            string syote;
            syote = Console.ReadLine();
            result = int.TryParse(syote, out number);
            return number;
        }
        //Aliohjelma tarkastaa kortin numeroa ja palauttaa false jos ei ole oikein
        private static bool InsertCardAndVerify(int card)
        {
            Console.WriteLine("Insert card.");
            if (IntCheck() == card)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect card number");
                return false;
            }
        }
        //aliohjelma tarkastaa PIN-koodia kolmesti, ja jos ei ole oikein niin palautetaan "false".
        private static bool InsertPinAndValidate(string card, double PIN)
        {
            bool exit = false;
            int i = 0;
            Console.WriteLine(card);
            Console.WriteLine(PIN);

            do
            {
                if (IntCheck() == PIN)
                {
                    exit = true;
                    return true;
                }
                else
                {
                    Console.WriteLine("Incorrect PIN");
                }
                i++;
            }
            while (exit == false && i <= 3);
            return false;
        }
        //Tarkastetaan onko tilillä rahaa
        private static bool RequestAmountAndVerifyFunds(double requestAmount, double funds)
        {
            if (requestAmount <= funds)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient funds, transaction unsuccessful");
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int card = 666999, PIN = 6969;
            double accountFunds = 500, requestAmount;
            bool exit = false;
//Yksinkertainen looppi jolla joko pääsee nostamaan rahaa tai sitten pääsee alkuun.
            do
            {
                if (InsertCardAndVerify(card))
                {
                    if (InsertPinAndValidate("Pin for card number " + card, PIN))
                    {
                        Console.WriteLine("Insert amount to withdraw. Current balance: {0}", accountFunds);
                        requestAmount = DoubleCheck();
                        if (RequestAmountAndVerifyFunds(requestAmount, accountFunds))
                        {
                            accountFunds = accountFunds - requestAmount;
                            Console.WriteLine("Withdraw successful! Account balance: {0}€", accountFunds);
                        }
                    }
                }
            }
            while (exit == false);
            

        }
    }
}
