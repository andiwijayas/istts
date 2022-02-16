using System.IO;

namespace SOLID.DI.After 
{
    public interface IRepository
    {
        public void Write(string str);
    }

    public class FileRepository : IRepository
    {
        private const string FileName = "saved2.txt";

        public void Write(string str)
        {
            File.WriteAllText(FileName, str);
        }
    }

    public interface ISpeakersService
    {
        void SaveSpeaker(Speakers speaker);
    }
    
    public class SpeakersService: ISpeakersService
    {
        private readonly IRepository _repository;

        public SpeakersService(IRepository repository)
        {
            _repository = repository;
        }
        
        public void SaveSpeaker(Speakers speaker)
        {
            _repository.Write($"FirstName: {speaker.FirstName}; LastName:{speaker.LastName}; Email:{speaker.Email}");
        }
    }
    
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
        
    }
}