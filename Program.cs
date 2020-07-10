using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace lab2._3_validating_input
{
    class Program
    {

        static void Main()
        {
            bool matched;

            //Validating user input phone number matches correct formatting:

           do
            {
                Console.WriteLine("Please enter a phone number: ");
                string phoneNumber = Console.ReadLine();

                Regex phoneValid = new Regex(@"\d{3}-\d{3}-\d{4}|\(\d{3}\)-\d{3}-\d{4}|\d{3}\.\d{3}\.\d{4}");  //criteria for user input to match ###-###-#### format or #/#/####

                matched = phoneValid.IsMatch(phoneNumber);  //compare user input to proper formatting and set matched to True if correct
                if (matched == true)
                {
                    Console.WriteLine($"your phone number is valid: {phoneNumber}");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("This is not a valid phone number input please try again");
                    Console.WriteLine("");
                } 
            } while (matched == false);

            //Validating user input date matches correct formatting:

            do
            {
                Console.WriteLine("Please enter a date: ");
                string date = Console.ReadLine();

                Regex dateValid = new Regex(@"^([0]?[0-9]|[12][0-9]|[3][01])/([0]?[1-9]|[1][0-2])/([0-9]{4})");  //proper date formatting should be ##/##/#### or #/#/####

                matched = dateValid.IsMatch(date);

                if (matched == true)
                {
                    Console.WriteLine($"You entered a valid date: {date}");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("This is not a valid date please try again");
                    Console.WriteLine("");
                }
            } while (matched == false);

            //Enter a name and validate that it meets certain criteria

            do
            {
                Console.WriteLine("Please enter a name: ");
                string name = Console.ReadLine();

                Regex nameValid = new Regex(@"^[A-Z]{1}[a-z]{0,29}"); //the name must start with a capital letter and can be followed by 0-29 additional lowercase letters

                matched = nameValid.IsMatch(name);

                if (matched == true)
                {
                    Console.WriteLine($"You have entered a valid name: {name}");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("you have entered an invalid name please try again");
                    Console.WriteLine("");
                }
            } while (matched == false);

            //Enter an email address and validate it meets proper email formatting criteria

            do
            {
                Console.WriteLine("Please enter an email address: ");
                string email = Console.ReadLine();

                Regex emailValid = new Regex(@"\w{5,30}\@\w{5,10}\.\w{2,3}"); //a valid email can be between 5-30 letters/numbers @ 5-10 letters/numbers . 2-3 letters/numbers

                matched = emailValid.IsMatch(email);

                if (matched == true)
                {
                    Console.WriteLine($"You entered a valid email: {email}");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("You entered an invalid email");
                    Console.WriteLine("");
                }
            } while (matched == false);

            Console.WriteLine("Would you like to play again? (y/n)");
            string replay = Console.ReadLine();
            replay.ToLower();

            if (replay == "y")
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.WriteLine("Thanks for playing!");              
            }

        }

    }
}
