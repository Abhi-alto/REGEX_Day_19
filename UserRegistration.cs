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
        public void Email(string email)
        {
            string emailRule = @"^[a-z]{1}[A-Za-z0-9][_-.]?[A-Za-z0-9]*[^.]+@[A-Za-z0-9]+.[a-z]{2,4}(.[a-z]{2,4})";
            Regex rg = new Regex(emailRule);
            var Result=rg.IsMatch(email);
            if (Result)
                Console.WriteLine("Email = " + email);
            else
                Console.WriteLine("Invalid Input");
        }
    }
}
