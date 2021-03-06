﻿using System;

namespace Vsite.CSharp
{
    class UvjetnoPridruživanje
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši neki cijeli broj:");
            string unos = Console.ReadLine();

            try
            {
                int broj = int.Parse(unos);

                //Napisati uvjetno pridruživanje koje će ovisno o dijeljivosti broja varijabli odgovor dodijeliti vrijednost "paran" ili "neparan"
                string odgovor = (broj % 2 == 0) ? "paran" : "neparan";

                Console.WriteLine("Broj {0} je {1}", broj, odgovor);

            }
            catch (Exception)
            {
                Console.WriteLine("Neispravan unos");
            }
            Console.ReadKey();
        }
    }
}
