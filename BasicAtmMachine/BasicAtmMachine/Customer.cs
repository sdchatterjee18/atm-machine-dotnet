using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAtmMachine
{
    class Customer
    {
        private string Acc_no;
        private string PIN;
        private int Balance;
        private string Phone;
        private string Name;

            public Customer(int Balance, string Acc_no, string PIN, string Phone, string name)
            {
                this.Acc_no = Acc_no;
                this.PIN = PIN;
                this.Balance = Balance;
                this.Phone = Phone;
                this.Name = name;
            }

            //verify Pin
            public bool VerifyPin(string pin)
            {
                if (PIN == pin)
                {
                    Console.WriteLine("Hello!! {0}",Name);
                    return true;
                }
                return false;
            }
            //verify Account No.
            public bool VerifyAccount(string account)
            {
                return account == Acc_no;
            }
            //verify existing account No.
            public bool CheckExistingAccount(string acc)
            {
                if (acc == Acc_no)
                {
                    return true;
                }
                return false;
            }
            //-----WITHDRAW METHOD-----
            public void Withdraw(int amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Enter right amount...");
                }
                else if (amount > Balance)
                {
                    Console.WriteLine("Insufficient amount...");
                }
                else
                {
                    Balance = Balance - amount;
                    Console.WriteLine("WITHDRAW SUCCESSFULL....");
                }

            }


            //-----DEPOSIT METHOD-----
            public void Deposit(int amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("You enter invalid amount...");
                }
                else
                {
                    Balance = Balance + amount;
                    Console.WriteLine("Deposit successfull...");
                }
            }

            //-----BALANCE CHECK METHOD-----
            public void BalanceCheck()
            {
                Console.WriteLine("Available Balance is :{0}", Balance);
            }

        }
    }
