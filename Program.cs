using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name for validation");
            string Name1 = Console.ReadLine();
            bool name = Username(Name1);

            if (name == true)
            {
                Console.WriteLine("That is a valid name");
            }
            else
            {
                Console.WriteLine("That is an invalid name");
            }
            Console.ReadLine();

            Console.WriteLine("Enter an email for validation");
            string Email1 = Console.ReadLine();
            bool mail = Email(Email1);

            if (mail == true)
            {
                Console.WriteLine("That is a valid email");
            }
            else
            {
                Console.WriteLine("That is not a valid email");
            }
            Console.ReadLine();

            Console.WriteLine("Please enter a phone number for validation");
            string Phone1 = Console.ReadLine();
            bool phone = PhoneNumbers(Phone1);

            if (phone == true)

            {
                Console.WriteLine("That is a valid phone number");
            }
            else
            {
                Console.WriteLine("That is not a valid phone number");
            }
            Console.ReadLine();

            Console.WriteLine("Enter a date (dd/mm/yyyy) to be validated");
            string Date1 = Console.ReadLine();
            bool date = YearDates(Date1);

            if (date == true)
            {
                Console.WriteLine("That is a valid date");
            }
            else
            {
                Console.WriteLine("That is not a valid date");
            }
            Console.ReadLine();

        }


        public static bool Username(string name)

        {
            Regex r = new Regex("^[A-Z]{1}[a-z]{2,30}$");
            if (r.IsMatch(name))
            {
                return true;
            }
            else
                return false;

        }

        public static bool Email(string mail)

        {
            Regex r = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                     @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                     RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            if (r.IsMatch(mail))
            {
                return true;
            }
            else
                return false;

        }

        public static bool PhoneNumbers(string phone)
        {
            Regex r = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
            if (r.IsMatch(phone))
            {
                return true;
            }
            else
                return false;

        }

        public static bool YearDates(string date)
        {
            Regex r = new Regex((@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"));
            if (r.IsMatch(date))
            {
                return true;
            }
            else
                return false; 
        }


    }

}
