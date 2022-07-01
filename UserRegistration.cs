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
        public void mobile(String number)
        {
            String mobilenum = @"^91([ ])?[6-9]{1}[0-9]{9}$";
            Regex rg = new Regex(mobilenum);
            var result = rg.IsMatch(number);
            if (result)
                Console.WriteLine("Your number is " + number);
            else
                Console.WriteLine("Wrong number input");
        }
        public void pass(string password)                           //password - minimum 8 characters
                                                                    //         -
        {
            String PASSWORD = @"^[A-Za-z0-9]{8,}$";
            Regex rg = new Regex(PASSWORD);
            var result = rg.IsMatch(password);
            if (result)
                Console.WriteLine("Your password is " + password);
            else
                Console.WriteLine("Wrong number input");
        }
    }
}
