using System;
using SaqueContaBancariaComExcecao.Entities;
using System.Globalization;

namespace SaqueContaBancariaComExcecao
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int nr_account = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string nm_holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double nr_iniBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                double nr_WithdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(nr_account, nm_holder, nr_iniBalance, nr_WithdrawLimit);

                Console.Write("Enter amount for deposit: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Deposit(amount);

                Console.Write("Enter amount for withdraw: ");
                amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Withdraw(amount);                

                Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }            
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }            
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
