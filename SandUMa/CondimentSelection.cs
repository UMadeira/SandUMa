using System.Diagnostics;

namespace SandUMa
{
    public class CondimentSelection : State
    {
        public CondimentSelection( SandwichMachine aMachine ) : base( aMachine ) { }

        public override void SelectCondiment( string aType )
        {
            Debug.Assert( Machine.Sandwich != null );

            Machine.Sandwich = Machine.Factory.CreateCondiment( aType, Machine.Sandwich );
            if ( Machine.Sandwich == null ) Machine.Current = Machine.OutOfService;
        }

        public override void Confirm()
        {
            Machine.Current = Machine.Payment;
        }
    }
}
