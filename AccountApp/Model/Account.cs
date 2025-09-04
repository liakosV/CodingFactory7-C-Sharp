using AccountApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Model
{
    internal class Account
    {
        public int Id { get; set; }
        public string? Iban { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Ssn { get; set; }
        public decimal Balance { get; set; }

        public Account()
        {
            
        }

        public Account(int id, string? iban, string? firstname, string? lastname, string? ssn, decimal balance)
        {
            Id = id;
            Iban = iban;
            Firstname = firstname;
            Lastname = lastname;
            Ssn = ssn;
            Balance = balance;
        }

        public override string? ToString()
        {
            return $"{{ {Id}\t{Firstname}\t{Lastname}\t{Ssn}\t{Balance} }}";
        }

        /// <summary>
        /// Deposits an ammount of money into the <see cref="Account" />.
        /// </summary>
        /// <param name="amount"></param>
        public void Deposit(decimal amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new NegativeAmountException("Error. Amount must not be negative or zero.");
                }
                Balance += amount;

            } catch (NegativeAmountException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void Withdraw(decimal amount, string? ssn)
        {

            try
            {
            if (string.IsNullOrEmpty(ssn)) throw new InvalidSsnExcpetion(ssn!);
            if (ssn != Ssn) throw new InvalidSsnExcpetion(ssn);
            if (amount <= 0) throw new NegativeAmountException("Error. Amount must not be negative or zero.");
            if (amount > Balance) throw new InsufficientBalanceException("Error. Insufficient balance.");

            Balance -= amount;
            } 
            catch (NegativeAmountException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            catch (InvalidSsnExcpetion e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            catch (InsufficientBalanceException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public decimal GetBalance(decimal amount)
        {
            return Balance;
        }
    }
}
