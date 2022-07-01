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
            var result=rg.IsMatch(name);
            if (result)
                Console.WriteLine("First Name = " + name);
            else
                Console.WriteLine("Invalid Input");
        }
    }
}
