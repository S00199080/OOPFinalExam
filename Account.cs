using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinalExam
{
    //https://github.com/S00199080/OOPFinalExam Link to GitHub Repository
    public abstract class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Balance { get; set; }
        public double InterestDate { get; set; }

        //deposit Method
        public void Deposit()
        { 
            
        }

        //withdraw Method
        public void Withdraw()
        {

        }

        //abstract method to calculate interest
        public abstract void CalculateInterest(double interest);               
    }
        //new class CurrentAccount inherits properties from Account class
    public class CurrentAccount : Account
    {
        //interest rate = 3%
        public double InterestRate = 0.03;
        public double AccountNumber { get; set; }
        public CurrentAccount(double accnum, string lname, string fname)
        {
            FirstName = fname;
            LastName = lname;
            AccountNumber = accnum;         
        }

        public override void CalculateInterest(double interest)
        {            
            interest = InterestRate * Balance;
        }

        //Tostring to format the returned string
        public override string ToString()
        {
            
            return string.Format($"{AccountNumber}-{LastName} {FirstName}");
            
        }

    }

    //new class SavingsAccount inherits properties from Account class
    public class SavingsAccount : Account
    {
        public double InterestRate = 0.06;
        public double AccountNumber { get; set; }
        public SavingsAccount(double accnum, string lname, string fname)
        {
            FirstName = fname;
            LastName = lname;
            AccountNumber = accnum;
        }

        public override void CalculateInterest(double interest)
        {   
            interest = InterestRate * Balance;
        }

        public override string ToString()
        {          
            return string.Format($"{AccountNumber}-{LastName} {FirstName}");           
        }

    }
}
