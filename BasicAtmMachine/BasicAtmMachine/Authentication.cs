using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAtmMachine
{
    class Authentication
    {
        //-----LOGIN METHOD-----
        public static Customer Login(List<Customer> customers, string account_no, string pin)
        {

            foreach (Customer c in customers)
            {
                if (c.VerifyAccount(account_no))
                {
                    if (c.VerifyPin(pin))
                    {
                        Console.WriteLine("LOGIN SUCCESSFUL...");
                        return c;
                    }
                    else
                    {
                        Console.WriteLine("WRONG PASSWORD....\nTry again\n");
                        return null;
                    }
                }

            }
            Console.WriteLine("Account does not exist...\nTry Again\n");
            return null;
        }
    }
}
