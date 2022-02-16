namespace Patterns.Builder
{
    public class LegoHead
    {
        public string Name { get; set; }
        public LegoHead(string name)
        {
            Name = name;
        }
    }

    public class LegoBody
    {
        public string Name { get; set; }
        public LegoBody(string name)
        {
            Name = name;
        }
    }

    public class LegoLeg
    {
        public string Name { get; set; }
        public LegoLeg(string name)
        {
            Name = name;
        }
    }

    public class LegoCharacter
    {
        public LegoHead Head { get; set; }
        public LegoBody Body { get; set; }
        public LegoLeg Leg { get; set; }
    }
    
    public interface ILegoBuilder
    {
        ILegoBuilder Reset();
        ILegoBuilder BuildHead();
        ILegoBuilder BuildBody();
        ILegoBuilder BuildLeg();
        LegoCharacter GetResult();
    }
    
    public class BatmanLegoBuilder: ILegoBuilder
    {
        private LegoCharacter _character;
        
        public ILegoBuilder Reset()
        {
            _character = new LegoCharacter();
            return this;
        }

        public ILegoBuilder BuildHead()
        {
            _character.Head = new LegoHead("Batman");
            return this;
        }

        public ILegoBuilder BuildBody()
        {
            _character.Body = new LegoBody("Batman");
            return this;
        }

        public ILegoBuilder BuildLeg()
        {
            _character.Leg = new LegoLeg("Batman");
            return this;
        }

        public LegoCharacter GetResult()
        {
            return _character;
        }
    }

    public class SupermanLegoBuilder: ILegoBuilder
    {
        private LegoCharacter _character;
        
        public ILegoBuilder Reset()
        {
            _character = new LegoCharacter();
            return this;
        }

        public ILegoBuilder BuildHead()
        {
            _character.Head = new LegoHead("Superman");
            return this;
        }

        public ILegoBuilder BuildBody()
        {
            _character.Body = new LegoBody("Superman");
            return this;
        }

        public ILegoBuilder BuildLeg()
        {
            _character.Leg = new LegoLeg("Superman");
            return this;
        }

        public LegoCharacter GetResult()
        {
            return _character;
        }
    }

    public class LegoCharacterDirector
    {
        private readonly ILegoBuilder _legoBuilder;

        public LegoCharacterDirector(ILegoBuilder legoBuilder)
        {
            _legoBuilder = legoBuilder;
        }
        
        public LegoCharacter MakeLegoCharacter() =>
            _legoBuilder
                .Reset()
                .BuildBody()
                .BuildHead()
                .BuildLeg()
                .GetResult();
    }
}