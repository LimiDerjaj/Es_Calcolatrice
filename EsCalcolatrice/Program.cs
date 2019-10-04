using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNameSpace;

namespace EsCalcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int result;
            float result1;
            bool success;
            int z;
            string a;

            Console.WriteLine("Benvenuto in MyCalculator");

            do {
                do
                {
                    Console.WriteLine("\r\nScegli l' operazione da eseguire per iniziare:\r\n\r\n1 = +\r\n2 = -\r\n3 = *\r\n4 = /\r\n");
                    string operazione = Console.ReadLine();
                    success = Int32.TryParse(operazione, out z);
                    if (!success || z < 1 || z > 4)
                    {
                        Console.WriteLine("\r\nIl valore inserito non è corretto, inserire un valore tra 1 e 4");
                    }
                } while (!success || z < 1 || z > 4);

                if (z == 1)
                {
                    do
                    {
                        Console.WriteLine("---------------------------\r\nADDIZIONE");
                        Console.WriteLine("---------------------------\r\n\r\nInserisci il primo numero e premi INVIO");
                        string numero1 = Console.ReadLine();
                        success = Int32.TryParse(numero1, out x);
                        if (success == false)
                        {
                            Console.WriteLine("\r\nIl valore inserito non è corretto");
                        }
                    } while (success == false);

                    do
                    {
                        Console.WriteLine("\r\nInserisci il secondo numero e premi INVIO");
                        string numero2 = Console.ReadLine();
                        success = Int32.TryParse(numero2, out y);
                        if (success == false)
                        {
                            Console.WriteLine("\r\nIl valore inserito non è corretto");
                        }
                    } while (success == false);

                    result = Class1.Sum(x, y);

                    Console.WriteLine("\r\nLa somma di " + x + " + " + y + " è: " + result + "\r\n\r\n---------------------------");

                    //Console.ReadLine();
                }


                if (z == 2)
                {
                    do
                    {
                        Console.WriteLine("---------------------------\r\nSOTTRAZIONE");
                        Console.WriteLine("---------------------------\r\n\r\nInserisci il primo numero e premi INVIO");
                        string numero1 = Console.ReadLine();
                        success = Int32.TryParse(numero1, out x);
                        if (success == false)
                        {
                            Console.WriteLine("\r\nIl valore inserito non è corretto");
                        }
                    } while (success == false);

                    do
                    {
                        Console.WriteLine("\r\nInserisci il secondo numero e premi INVIO");
                        string numero2 = Console.ReadLine();
                        success = Int32.TryParse(numero2, out y);
                        if (success == false)
                        {
                            Console.WriteLine("\r\nIl valore inserito non è corretto");
                        }
                    } while (success == false);

                    result = Class1.Diff(x, y);

                    Console.WriteLine("\r\nLa differenza di " + x + " - " + y + " è: " + result + "\r\n\r\n---------------------------");
                    //Console.ReadLine();

                }

                if (z == 3)
                {
                    do
                    {
                        Console.WriteLine("---------------------------\r\nMOLTIPLICAZIONE");
                        Console.WriteLine("---------------------------\r\n\r\nInserisci il primo numero e premi INVIO");
                        string numero1 = Console.ReadLine();
                        success = Int32.TryParse(numero1, out x);
                        if (success == false)
                        {
                            Console.WriteLine("\r\nIl valore inserito non è corretto");
                        }
                    } while (success == false);

                    do
                    {
                        Console.WriteLine("\r\nInserisci il secondo numero e premi INVIO");
                        string numero2 = Console.ReadLine();
                        success = Int32.TryParse(numero2, out y);
                        if (success == false)
                        {
                            Console.WriteLine("\r\nIl valore inserito non è corretto");
                        }
                    } while (success == false);

                    result = Class1.Prod(x, y);

                    Console.WriteLine("\r\nIl prodotto di " + x + " * " + y + " è: " + result + "\r\n\r\n---------------------------");
                    //Console.ReadLine();
                }

                if (z == 4)
                {
                    do
                    {
                        Console.WriteLine("---------------------------\r\nDIVISIONE");
                        Console.WriteLine("---------------------------\r\n\r\nInserisci il primo numero e premi INVIO");
                        string numero1 = Console.ReadLine();
                        success = Int32.TryParse(numero1, out x);
                        if (!success)
                        {
                            Console.WriteLine("\r\nIl valore inserito non è corretto");
                        }
                    } while (success == false);

                    do
                    {
                        Console.WriteLine("\r\nInserisci il secondo numero e premi INVIO");
                        string numero2 = Console.ReadLine();
                        success = Int32.TryParse(numero2, out y);
                        if (!success)
                        {
                            Console.WriteLine("\r\nIl valore inserito non è corretto, inserire un numero intero");
                        }
                        else
                            if (y==0)
                            {
                            Console.WriteLine("\r\nImpossibile eseguire una divisione per 0");
                            }
                    } while (!success || y==0);

                    result1 = Class1.Div(x, y);

                    Console.WriteLine("\r\nLa divisione tra " + x + " / " + y + " è: " + result1+ "\r\n\r\n---------------------------");
                    //Console.ReadLine();
                }

            Console.WriteLine("\r\nPremere qualsiasi tasto per continuare, n per uscire, ");
            a=Console.ReadLine();
            } while ( a != "n");            
         } 
    }
}
