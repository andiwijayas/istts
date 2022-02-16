using System.IO;

namespace SOLID.DI.Before 
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
            Email = email;
        }

        private void Save()
        {
            File.WriteAllText(
                "saved.txt", 
                $"FirstName: {FirstName}; LastName:{LastName}; Email:{Email}");
        }
    
    }
}