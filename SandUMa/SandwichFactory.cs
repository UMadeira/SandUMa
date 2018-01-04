namespace SandUMa
{
    public class SandwichFactory
    {
        public ISandwich CreateWhiteBread() => new WhiteBread();
        public ISandwich CreateWholeGrainBread() => new WholeGrainBread();
        public ISandwich CreatePotatoBread() => new PotatoBread();
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

        public ICondiment    CreateButter( ISandwich aSandwich ) => new Butter( aSandwich );
        public ICondiment    CreateCheese( ISandwich aSandwich ) => new Cheese( aSandwich );
        public ICondiment       CreateHam( ISandwich aSandwich ) => new Ham( aSandwich );
        public ICondiment   CreateLettuce( ISandwich aSandwich ) => new Lettuce( aSandwich );
        public ICondiment CreateCondiment( ISandwich aSandwich, string aType )
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
