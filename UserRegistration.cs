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
    }
}
