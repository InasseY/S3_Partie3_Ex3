using System;

namespace Partie3_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int result, number;
            string reponseString ;
            

            Console.WriteLine("Pouvez vous renseigner le premier montant ?");
            result = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("voulez vous y ajouter un chiffre oui/non");
            reponseString = Console.ReadLine();

            //tant que on répond oui on fait la boucle suivante 
            while ( reponseString == "oui")
            {  
            Console.WriteLine($"quel est le chiffre à ajouter ?");
            number = Convert.ToInt32(Console.ReadLine());

            result = result + number ;
            Console.WriteLine($" voulez vous encore ajouter un chiffre oui/non");
            reponseString = Console.ReadLine();


        }
                
                {
                    Console.WriteLine($"Merci pour votre parcticipation, le résultat est de {result}");
                }

                
            }
        }
    }


 