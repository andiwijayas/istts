namespace Patterns.Decorator
{
    public interface ILegoCharacter
    {
        string GetHead();
        string GetBody();
    }
    
    public class NormalLegoCharacter : ILegoCharacter
    {
        public string GetHead() => "This is the small Head";
        public string GetBody() => "This is the small Body";
    }

    public class SuperheroDecorator : ILegoCharacter
    {
        private readonly ILegoCharacter _legoCharacter;

        public SuperheroDecorator(ILegoCharacter legoCharacter)
        {
            _legoCharacter = legoCharacter;
        }
        public string GetHead() => $"{_legoCharacter.GetHead()} with mask";
        public string GetBody() => $"{_legoCharacter.GetBody()} with cape";
    }
}