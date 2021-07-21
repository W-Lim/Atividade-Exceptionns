using System;
using System.Globalization;
using System.Collections.Generic;
using AtvExceptions.Entities;
using AtvExceptions.Entities.Exceptions;

namespace AtvExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<Account> list = new List<Account>();

                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double wLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Account(number, name, balance, wLimit));

                foreach (Account acc in list)
                {
                    acc.Withdraw(amount);
                }

                foreach (Account acc in list)
                {
                    Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
            catch(DomainExeptions e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }

            

        }
    }
}
