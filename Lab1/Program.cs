using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Klasser

            double total;
            int pay;
            double subtotal;
            double roundingOffAmount;
            int moneyback;
            int counter;



            // Kassa - Summa, kontant

            while (true)
            {
                try
                {
                    Console.Write("Ange totalsumma: ");
                    total = double.Parse(Console.ReadLine());
                    break;
                }

                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL! Erhållet belopp felaktigt.");
                    Console.ResetColor(); 
                }
            }



            if (total < 1)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTotalsumman är för liten. Köpet kunde inte genomföras.");
                Console.ResetColor();
                return;
            }


                
            else
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Ange erhållet belopp: ");
                        pay = int.Parse(Console.ReadLine());
                        break;
                    }

                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nFEL! Erhållet belopp felaktigt.");
                        Console.ResetColor();
                    }
                }


                if (pay < total)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nErhållet belopp är för litet. Köpet kunde inte genomföras.");
                    Console.ResetColor();
                    return; 
                }
               


                else
                {

                    // Kvitto - Summa, kontant, tillbaka

                    subtotal = Math.Round(total);
                    roundingOffAmount = subtotal - total;
                    moneyback = (int)(pay - subtotal);



                    Console.WriteLine("\nKVITTO");
                    Console.WriteLine("------------------");
                    Console.WriteLine(String.Format("Totaltbelopp      : {0,15:c}", total));
                    Console.WriteLine(String.Format("öresavrunding     : {0,15:c}", roundingOffAmount));
                    Console.WriteLine(String.Format("Att betala        : {0,15:c}", subtotal));
                    Console.WriteLine(String.Format("Kontant           : {0,15:c0}", pay));
                    Console.WriteLine(String.Format("Pengar tillbaka   : {0,15:c0}", moneyback));
                    Console.WriteLine("------------------");


                    if (subtotal == pay)
                    {
                        Console.WriteLine("Tack för köpet, välkommen åter!");
                        return; 
                    }


                    // Sedelräknare

                    if (moneyback >= 500)
                    {
                        counter = moneyback / 500;
                        moneyback = moneyback % 500;
                        Console.WriteLine("500-lappar    :{0} ", counter);
                    }

                    if (moneyback >= 100)
                    {
                        counter = moneyback / 100;
                        moneyback = moneyback % 100;
                        Console.WriteLine("100-lappar    :{0} ", counter);
                    }

                    if (moneyback >= 20)
                    {
                        counter = moneyback / 20;
                        moneyback = moneyback % 20;
                        Console.WriteLine("20-lappar     :{0} ", counter);
                    }

                    if (moneyback >= 5)
                    {
                        counter = moneyback / 5;
                        moneyback = moneyback % 5;
                        Console.WriteLine("5-kronor      :{0} ", counter);
                    }

                    if (moneyback >= 1)
                    {
                        counter = moneyback / 1;
                        moneyback = moneyback % 1;
                        Console.WriteLine("1-kronor      :{0} ", counter);
                    }


                }

                }
                
            }
            

        }
    }

