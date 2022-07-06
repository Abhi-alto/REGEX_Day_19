using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegeX
{
    internal class UserRegistration
    {
        public void Name(String name)
        {
            String nameRule = @"^[A-Z]{1}[A-Za-z]{3,10}";
            Regex rg = new Regex(nameRule);
            var result = rg.IsMatch(name);
            if (result)
                Console.WriteLine("First Name = " + name);
            else
                Console.WriteLine("Invalid Input");
        }
        public void LastName(String lastname)
        {
            String lastnameRule = @"^[A-Z]{1}[A-Za-z]{3,15}";
            Regex rg = new Regex(lastnameRule);
            var result = rg.IsMatch(lastname);
            if (result)
                Console.WriteLine("Last Name = " + lastname);
            else
                Console.WriteLine("Invalid Input");
        }
        public void mobile(String number)                                   //for phn number
        {
            String mobilenum = @"^91([ ])?[6-9]{1}[0-9]{9}$";
            Regex rg = new Regex(mobilenum);
            var result = rg.IsMatch(number);
            if (result)
                Console.WriteLine("Your number is " + number);
            else
                Console.WriteLine("Wrong number input");
        }
        public void pass(string password)
        {
            String PASSWORD = @"^(?=.*[A-Z])(?=.*[$])(?=.*[0-9])[A-Za-z0-9$#@_]{8,}$";      //Positive look - (?=.*[A-Z])  .*-means we dont care about the precision where we are finding the character    
            Regex rg = new Regex(PASSWORD);
            var resu = rg.Match(password);
            Console.WriteLine(resu);
            var result = rg.IsMatch(password);
            if (result)
                Console.WriteLine("Your password is " + password);
            else
                Console.WriteLine("Wrong password input");
        }
        public void email(String Email)                         //for emailID
        {
            String emailID = @"^[A-Za-z0-9]{3,}([\.\-\+][A-Za-z0-9]{3,})?[@][a-zA-Z0-9]{1,}[.][a-zA-Z]{2,}([.][a-zA-Z]{2,})?$"; ;
            Regex rg = new Regex(emailID);
            var result = rg.IsMatch(Email);
            if (result)
                Console.WriteLine("Your email is " + Email);
            else
                Console.WriteLine("Wrong email input");
        }

    }
}
