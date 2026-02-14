using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicAtmMachine
{
    class Program
    {
        //CREATE ACCOUNT AND ENTER DETAILS...
        public static void CreateAccountInput(List<Customer> AllCustomers)
        {
            Console.WriteLine("Enter you account no. to create your account :");
            string accNo =CheckValidation.CheckAccountNo_create(AllCustomers);
            Console.WriteLine("Generate a pin :");
            string pin = CheckValidation.checkPin();
            Console.WriteLine("Enter name :");
            string name=Console.ReadLine();
            Console.WriteLine("Enter mobile number :");
            string phone = CheckValidation.checkPhone();
            Console.WriteLine("Account created successfully...");
            AllCustomers.Add(new Customer(0,accNo,pin,phone,name));
        }

        //---------Main Method----------
        static void Main(string[] args)
        {
           List<Customer> AllCustomers = new List<Customer>();
           Customer LoggedIn = null;
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("Choose what do you want to do :");
                Console.WriteLine(" | 1. CREATE ACCOUNT | 2.LOGIN | 3.EXIT");
                int Choose = Convert.ToInt32(Console.ReadLine());
                switch (Choose)
                {
                    case 1:

                        CreateAccountInput(AllCustomers);

                        break;
                    case 2:
                        bool check = true;
                        while (check)
                        {
                            Console.WriteLine("\n***Enter your specific account number and PIN to login***");
                            Console.WriteLine("Enter Account no. :");
                            string account_no = CheckValidation.CheckAccountNo();
                            Console.WriteLine("Enter Login PIN :");
                            string pin = CheckValidation.checkPin();
                            LoggedIn = Authentication.Login(AllCustomers, account_no, pin);
                            while (true)
                                if (LoggedIn == null)
                                {
                                    Console.WriteLine("Do you want to try login Again ? 1. yes 2. No ");
                                    int Temp_choose = Convert.ToInt32(Console.ReadLine());
                                    if (Temp_choose == 2)
                                    {
                                        check = false;
                                        break;
                                    }
                                    else if (Temp_choose == 1)
                                    {
                                        Console.WriteLine("Choose");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("choosed wrong");
                                    }
                                }
                                else
                                {
                                    check = false;
                                    break;
                                }
                        }

                        while (LoggedIn != null)
                        {
                            Console.WriteLine("1.WITHDRAW  2.DEPOSIT  3.BALANCE-CHECK  4.LOGOUT[Exit]");
                            int ChooseAgain = Convert.ToInt32(Console.ReadLine());
                            switch (ChooseAgain)
                            {
                                case 1:
                                    Console.Write("Enter Amount to withdraw...  :");
                                    int amount = Convert.ToInt32(Console.ReadLine());
                                    LoggedIn.Withdraw(amount);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter how much amount you want to deposit?");
                                    amount = Convert.ToInt32(Console.ReadLine());
                                    LoggedIn.Deposit(amount);
                                    break;
                                case 3:
                                    LoggedIn.BalanceCheck();
                                    break;
                                case 4:
                                    LoggedIn = null;
                                    Console.WriteLine("Logout successfully...");
                                    break;
                            }
                            while (true)
                            {
                                Console.WriteLine("do you want any other services ?? 1.Yes 2.No");
                                ChooseAgain = Convert.ToInt32(Console.ReadLine());
                                if (ChooseAgain == 1)
                                {
                                    Console.WriteLine("Choose");
                                    break;
                                }
                                else if (ChooseAgain == 2)
                                {
                                    LoggedIn = null;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("You choose wrong !! choose again");
                                }
                            }

                        }
                        break;
                    case 3:
                        Console.WriteLine("Thank you!! Wish you a good day...");
                        exit = false;
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
