using System.Diagnostics;

namespace SandUMa
{
    public class CondimentSelection : State
    {
        public CondimentSelection( SandwichMachine aMachine ) : base( aMachine ) { }

        public override void SelectCondiment( string aType )
        {
            Debug.Assert( Machine.Bread != null );

            if ( string.IsNullOrEmpty( aType ) )
            {
                Machine.Current = Machine.Payment;
            }
            else
            {
                Machine.Bread = Machine.Factory.CreateCondiment( aType, Machine.Bread );
                if ( Machine.Bread == null ) Machine.Current = Machine.OutOfService;
            }
        }
    }
}
