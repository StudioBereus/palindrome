using System;

namespace palin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool palindrome = true;
            Console.WriteLine("Veuillez entrer le mot ou la phrase");
            string reponse = Console.ReadLine();
            reponse = reponse.Split('.')[0];
            for (int i = 0; i < reponse.Length; i++)
            {
                if (reponse[i] != reponse[(reponse.Length-1) - i])
                {
                    palindrome = false ;
                }

            }
            if (palindrome ==true)
            {
                Console.WriteLine("Ce mot ou cette phrase est un palindrome");
            }
            else
            {
                Console.WriteLine("Ce mot ou cette phrase n'est pas un palindrome");
            }
        }
    }
}
