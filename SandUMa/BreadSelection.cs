using System.Diagnostics;

namespace SandUMa
{
    public class BreadSelection : State
    {
        public BreadSelection( SandwichMachine aMachine ) : base( aMachine ) { }

        public override void SelectBread( string aType )
        {
            Debug.Assert( Machine.Sandwich == null );

            Machine.Sandwich = Machine.Factory.CreateBread( aType );
            Machine.Current  = Machine.Sandwich == null 
                             ? Machine.OutOfService 
                             : Machine.CondimentSelection;
        }
    }
}
