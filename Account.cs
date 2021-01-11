using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinalExam
{
    public abstract class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Balance { get; set; }
        public double InterestDate { get; set; }

        public void Deposit()
        { 
            
        }

        public void Withdraw()
        {

        }

        public abstract void CalculateInterest(double interest);               
    }

    public class CurrentAccount : Account
    {
        public double InterestRate { get; set; }
        public CurrentAccount(string fname, string lname, double balance, double interestdate,double interestrate)
        {
            FirstName = fname;
            LastName = lname;
            Balance = balance;
            InterestDate = interestdate;
            InterestRate = interestrate;
            interestrate = 0.06;
        }

        public override void CalculateInterest(double interest)
        {
            interest = InterestRate * Balance;
        }


    }

    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount(string fname, string lname, double balance, double interestdate, double interestrate)
        {
            FirstName = fname;
            LastName = lname;
            Balance = balance;
            InterestDate = interestdate;
            InterestRate = interestrate;
            interestrate = 0.03;
        }

        public override void CalculateInterest(double interest)
        {   
            interest = InterestRate * Balance;
        }


    }
}
