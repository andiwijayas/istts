using System;
using System.Text.RegularExpressions;

namespace SOLID.SRP.After
{
    public class Speakers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Email Email { get; set; }
        
        public Speakers(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = new Email(email);
        }
    
    }


    public class Email
    {
        public string EmailAddress { get; set; }
        
        
        public Email(string email)
        {
            if (!ValidateEmail(email))
                throw new Exception("Invalid Email");
            EmailAddress = email;
        }

        private bool ValidateEmail(string email)
        {
            var re = new Regex(
                @"^([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$",
                RegexOptions.IgnoreCase);
            return re.IsMatch(email);

        }
    }
}