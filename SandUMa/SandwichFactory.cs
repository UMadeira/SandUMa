namespace SandUMa
{
    public class SandwichFactory
    {
        public ISandwich CreateWhiteBread()
        {
            return new WhiteBread();
        }
        public ISandwich CreateWholeGrainBread()
        {
            return new WholeGrainBread();
        }
        public ISandwich CreatePotatoBread()
        {
            return new PotatoBread();
        }
        public ISandwich CreateBread( string aType )
        {
            switch ( aType )
            {
                case      "WhiteBread": return CreateWhiteBread();
                case "WholeGrainBread": return CreateWholeGrainBread();
                case     "PotatoBread": return CreatePotatoBread();
            }
            return null;
        }

        public ICondiment CreateButter( ISandwich aSandwich )
        {
            return new Butter( aSandwich );
        }
        public ICondiment CreateCheese( ISandwich aSandwich )
        {
            return new Cheese( aSandwich );
        }
        public ICondiment CreateHam( ISandwich aSandwich )
        {
            return new Ham( aSandwich );
        }
        public ICondiment CreateLettuce( ISandwich aSandwich )
        {
            return new Lettuce( aSandwich );
        }
        public ICondiment CreateCondiment( string aType, ISandwich aSandwich )
        {
            switch ( aType )
            {
                case  "Butter": return CreateButter( aSandwich );
                case  "Cheese": return CreateCheese( aSandwich );
                case     "Ham": return CreateHam( aSandwich );
                case "Lettuce": return CreateLettuce( aSandwich );
            }
            return null;
        }
    }
}
