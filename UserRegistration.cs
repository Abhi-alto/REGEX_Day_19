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
            var result=rg.IsMatch(number);
            if (result)
                Console.WriteLine("Your number is " + number);
            else
                Console.WriteLine("Wrong number input");
        }
    }
}
