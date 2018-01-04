using System;

namespace SandUMa
{
    class Program
    {
        static void Main( string[] args )
        {
            SandwichMachine.Instance.SelectBread( nameof(WholeGrainBread) );
            SandwichMachine.Instance.SelectCondiment( "Butter" );
            SandwichMachine.Instance.SelectCondiment( "Cheese" );
            SandwichMachine.Instance.SelectCondiment( "Ham" );
            SandwichMachine.Instance.SelectCondiment( "Lettuce" );
            SandwichMachine.Instance.Confirm();
            SandwichMachine.Instance.Pay( 2.0 );
            SandwichMachine.Instance.Pay( 2.0 );
            ISandwich sandwich = SandwichMachine.Instance.Serve();

            if ( sandwich == null )
            {
                Console.WriteLine( "Cannot serve the sandwitch" );
            }
            else
            {
                Console.WriteLine( sandwich.Description + " = " + sandwich.GetPrice() );
            }
            Console.ReadKey();
        }
    }
}
