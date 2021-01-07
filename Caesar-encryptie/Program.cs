using System;
namespace Caesar_encryptie
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alfabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            Console.Write("Geef encryptienummer tussen 1 en 25: ");
            int encryptieNummer = int.Parse(Console.ReadLine());
            Console.Write("Geef tekst in: ");
            string tekst = Console.ReadLine();
            Console.Write("Is dit encrypted? (ja/nee): ");
            string encrypted = Console.ReadLine();
            string uitkomst = "";
            if (encrypted == "nee")
            {
                uitkomst = Encrypt(encryptieNummer, tekst, alfabet);
            }
            else if (encrypted == "ja")
            {
                uitkomst = Decrypt(encryptieNummer, tekst,alfabet);
            }
            Console.WriteLine(uitkomst);
        }
        private static string Decrypt(int encryptieNummer, string tekst, char[] alfabet)
        {
            string uitkomst = "";
            for (int i = 0; i < tekst.Length; i++)
            {
                char letter = char.Parse(tekst.Substring(i, 1).ToUpper());
                for (int j = 0; j < alfabet.Length; j++)
                {
                    if (alfabet[j] == letter)
                    {
                        if (j - encryptieNummer+1 > 0)
                        {
                            uitkomst += alfabet[j - encryptieNummer];
                        }
                        else
                        {
                            uitkomst += alfabet[alfabet.Length-j-encryptieNummer];
                        }
                    }
                }
                if (letter == ' ')
                {
                    uitkomst += " ";
                }
            }
            return uitkomst;
        }

        private static string Encrypt(int encryptieNummer, string tekst, char[] alfabet)
        {
            string uitkomst = "";
            for (int i = 0; i < tekst.Length; i++)
            {
                char letter = char.Parse(tekst.Substring(i, 1).ToUpper());
                for (int j = 0; j < alfabet.Length; j++)
                {
                    if (alfabet[j]==letter)
                    {
                        if (j + encryptieNummer<=alfabet.Length-1)
                        {
                            uitkomst += alfabet[j + encryptieNummer];
                        }
                        else
                        {
                            uitkomst += alfabet[j + encryptieNummer-alfabet.Length];
                        }
                    }
                }
                if (letter == ' ')
                {
                    uitkomst += " ";
                }
            }
            return uitkomst;
        }
    }
}