using System;

namespace GestionBanque
{
    public class BankAccount
    {
        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds Solde";
        public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";

        private readonly string client;
        private double solde;
        public BankAccount() { }
        public BankAccount(string customerName, double solde)
        {
            client = customerName;
            this.solde = solde;
        }
        public string CustomerName
        {
            get { return client; }
        }
        public double Solde
        {
            get { return solde; }
        }
        public void Debit(double amount)
        {
            /*
            if (amount > solde)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
                //throw new FieldAccessException("amount");
            }*/
            if (amount > solde)
            {
                throw new System.ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            }
            if (amount < 0)
            {
                throw new System.ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
            }
            solde -= amount; // Code incorrecte exprès
        }
        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
               
            }
            solde += amount;
        }
        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Mohamed Amine Mezghich", 1000);
            ba.Credit(500);
            ba.Debit(800);
            Console.WriteLine("Current balance is ${0}", ba.Solde);
        }
    }
}
