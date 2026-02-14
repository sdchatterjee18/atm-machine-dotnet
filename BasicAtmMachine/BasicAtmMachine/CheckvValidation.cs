using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAtmMachine
{
    static class CheckValidation
    {
        //-----ACCOUNT-NUMBER CHECKING METHOD----- 
        const int AccountNoLength = 10;
        const int PinLength = 5;
        const int phoneLength = 10;
        public static string CheckAccountNo()
        {
            while (true)
            {
                string acc_no = Console.ReadLine();
                if (acc_no.Length == AccountNoLength && acc_no.All(char.IsDigit))
                {
                    return acc_no;
                }
                else
                {
                    Console.WriteLine("You enter invalid account no!! must be 10 digits...");
                }
            }
        }
        //-----ACCOUNT-NUMBER CHECKING METHOD-For_Create----- 
        public static string CheckAccountNo_create(List<Customer> AllCustomers)
        {
            while (true)
            {
                string create_accNo = CheckAccountNo();
                bool exists = false;
                foreach(Customer c in AllCustomers)
                {
                    if (c.CheckExistingAccount(create_accNo))
                    {
                        exists = true;
                        Console.WriteLine("Account No. already exists.. create another!!");
                        break;
                    }
                }
                if (!exists)
                {
                    return create_accNo;
                }
                
            }
        }

        //------PIN CHECKING METHOD------
        public static string checkPin()
        {
            while (true)
            {
                string pin = Console.ReadLine();
                if (pin.Length == PinLength && pin.All(char.IsDigit))
                {
                    return pin;
                }
                Console.WriteLine("You enter invalid Pin !! must be 5 digits...");
            }

        }
        public static string checkPhone()
        {
            while (true)
            {
                string phone = Console.ReadLine();
                if (phone.Length == phoneLength && phone.All(char.IsDigit))
                {
                    return phone;
                }
                Console.WriteLine("You enter invalid Phone number !! must be 10 digits...");
            }

        }
    }
}
