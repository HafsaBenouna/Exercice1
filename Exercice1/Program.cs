using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    internal class Program
    {
            static void Main(string[] args)
            {
                int nbr;
                Console.WriteLine("entrez un nombre entier");
                nbr = int.Parse(Console.ReadLine());
                Estpremier(nbr);


            }

            public static void Estpremier(int N)
            {
                int d = 1; //drapeau
                int sqrt_int = (int)Math.Sqrt(N);

                for (int i = 2; i <= sqrt_int; i++)
                {
                    if (N % i == 0)
                    {
                        d = 0;
                        break;
                    }

                }

                if (d == 0)
                    Console.WriteLine("le nombre n'est pas premier");
                else
                    Console.WriteLine("le nombre est premier");



            }

        }
    }

