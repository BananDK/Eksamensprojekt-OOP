using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace EksamensProjektOOP
{
    public delegate void UserBalanceNotification(User user, decimal balance);
    public class User : IComparable
    {
        private int id;
        private string firstName;
        private string lastName;
        private string userName;
        private string email;
        private decimal balance;
        public UserBalanceNotification UserBalanceNotification;

        public User(int Id, string FirstName, string LastName, string UserName, string Email, decimal Balance)
        {
            id = Id;
            firstName = FirstName;
            lastName = LastName;
            userName = UserName;
            email = Email;
            balance = Balance;
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (value >= 1)
                    id = value;
                throw new ArgumentOutOfRangeException("Number must be 1 or higher");
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException();
                    }
                    else
                    {
                        firstName = value;
                    }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException();
                    }
                    else
                    {
                        lastName = value;
                    }
            }
        }

        //Regex til at validere username indeholder tal, små bogstaver og/eller _
        public string UserName
        {
            get { return userName; }
            set
            {
                Regex r = new Regex("[a-z0-9_]");
                if (r.IsMatch(userName))
                {
                    userName = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                String email = "LarsIsRetard-@.com";
                if (email.Contains('@'))
                {

                    string[] splitMail = email.Split('@');
                    Console.WriteLine(email);

                    if (splitMail.Length == 2)
                    {
                        string local = splitMail[0];
                        string domain = splitMail[1];
                        Console.WriteLine(local);
                        Console.WriteLine(domain);
                        Regex rLocal = new Regex("[a-zA-Z0-9._-]");
                        if (rLocal.IsMatch(local))
                        {
                            //domæne navn må ikke starte med _ eller .
                            //domæne skal indeholde et .
                            Regex rDomain = new Regex("^[a-zA-Z0-9]+ [a-zA-Z0-9.-] [.] [a-z]+$");
                            if (rDomain.IsMatch(domain))
                            {
                                email = value;
                                Console.WriteLine("sucess");
                            }
                            else
                            {
                                throw new ArgumentException();
                            }

                        }
                        else
                        {
                            throw new ArgumentException();
                        }
                    }
                }
            }
        }

        public decimal Balance
        {
            get
            {
                LowBalanceNotification();
                return balance;
            }
            set
            {
                balance = value;
                LowBalanceNotification();
            }
        }

        private void LowBalanceNotification()
        {
            if (balance < 50)
                UserBalanceNotification.Invoke(this, Balance);
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}, {email}";
        }

        public int CompareTo(object obj)
        {
            return id.CompareTo(obj);
        }
    }
}