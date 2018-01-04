namespace SandUMa
{
    public class SandwichFactory
    {
        public IBread CreateWhiteBread()
        {
            return new WhiteBread();
        }
        public IBread CreateWholeGrainBread()
        {
            return new WholeGrainBread();
        }
        public IBread CreatePotatoBreadad()
        {
            return new PotatoBread();
        }

        public IBread CreateBread( string aType )
        {
            switch ( aType )
            {
                case      "WhiteBread": return CreateWhiteBread();
                case "WholeGrainBread": return CreateWholeGrainBread();
                case     "PotatoBread": return CreatePotatoBreadad();
            }
            return null;
        }

        public IBreadCondiment CreateButter( IBread aBread )
        {
            return new Butter( aBread );
        }
        public IBreadCondiment CreateCheese( IBread aBread )
        {
            return new Cheese( aBread );
        }
        public IBreadCondiment CreateHam( IBread aBread )
        {
            return new Ham( aBread );
        }
        public IBreadCondiment CreateLettuce( IBread aBread )
        {
            return new Lettuce( aBread );
        }

        public IBreadCondiment CreateCondiment( string aType, IBread aBread )
        {
            switch ( aType )
            {
                case  "Butter": return CreateButter( aBread );
                case  "Cheese": return CreateCheese( aBread );
                case     "Ham": return CreateHam( aBread );
                case "Lettuce": return CreateLettuce( aBread );
            }
            return null;
        }
    }
}
