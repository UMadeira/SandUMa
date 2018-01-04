using System;

namespace SandUMa
{
    class Program
    {
        static void Main( string[] args )
        {
            SandwichMachine.Instance.SelectBread( "PotatoBread" );
            SandwichMachine.Instance.SelectCondiment( "Butter" );
            SandwichMachine.Instance.SelectCondiment( "Cheese" );
            SandwichMachine.Instance.SelectCondiment( "Ham" );
            SandwichMachine.Instance.SelectCondiment( "Lettuce" );
            SandwichMachine.Instance.SelectCondiment( "" );
            SandwichMachine.Instance.Pay( 2.0 );
            SandwichMachine.Instance.Pay( 2.0 );
            SandwichMachine.Instance.Pay( 2.0 );
            SandwichMachine.Instance.Pay( 2.0 );
            IBread bread = SandwichMachine.Instance.Serve();

            if ( bread == null )
            {
                Console.WriteLine( "Cannot serve the sandwitch" );
            }
            else
            {
                Console.WriteLine( bread.Description + " = " + bread.ComputePrice() );
            }
            Console.ReadKey();
        }
    }
}
