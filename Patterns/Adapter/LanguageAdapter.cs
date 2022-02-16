namespace Adapter
{
    public class EnglishMan 
    {
        public string Ask(string question)
        {
            return question == "How are you?" 
                    ? SayFine() 
                    : SaySorry();
        }

        public string SayFine() => "Fine. Thank you";

        public string SaySorry() => "Sorry. I don't understand";
    }

    public class IndonesianMan
    {
        public string Ask(string question)
        {
            return question == "Apa kabar?" 
                        ? SayFine() 
                        : SaySorry();
        }
        
        public string SayFine() => "Baik.";

        public string SaySorry() => "Maaf saya tidak mengerti";
    }

    public interface ILanguageAdapter
    {
        string Ask(string question);
    }

    public class EnglishToIndonesianAdapter : ILanguageAdapter
    {
        private readonly IndonesianMan _indonesianMan;

        public EnglishToIndonesianAdapter(IndonesianMan indonesianMan)
        {
            _indonesianMan = indonesianMan;
        }
        public string Ask(string question)
        {
            if (question == "How are you?")
            {
                return _indonesianMan.SayFine();
            }
            else
            {
                return _indonesianMan.SaySorry();
            }
        }
    }
}