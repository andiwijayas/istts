using System;
using System.Text.RegularExpressions;

namespace SOLID.SRP.Before 
{
    public class Speakers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        
        public Speakers(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            if (ValidateEmail(email))
                throw new Exception("Invalid Email");
            Email = email;
        }

        private bool ValidateEmail(string email)
        {
            var re = new Regex(
                @"^([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$", RegexOptions.IgnoreCase);
            return re.IsMatch(email);
        }
    
    }
}
