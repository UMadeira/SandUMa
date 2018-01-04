using System.Diagnostics;

namespace SandUMa
{
    public class BreadSelection : State
    {
        public BreadSelection( SandwichMachine aMachine ) : base( aMachine ) { }

        public override void SelectBread( string aType )
        {
            Debug.Assert( Machine.Bread == null );

            Machine.Bread   = Machine.Factory.CreateBread( aType );
            Machine.Current = Machine.Bread == null 
                            ? Machine.OutOfService 
                            : Machine.CondimentSelection;
        }
    }
}
