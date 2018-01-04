using System.Diagnostics;

namespace SandUMa
{
    public class Payment : State
    {
        public Payment( SandwichMachine aMachine ) : base( aMachine ) { }

        public override void Pay( double aAmount )
        {
            Debug.Assert( Machine.Bread != null );
            Machine.Amount += aAmount;
            var amount = Machine.Bread.ComputePrice();
            if ( Machine.Amount >= amount )
            {
                Machine.Amount -= amount;
                Machine.Current = Machine.Preparation;
            }
        }
    }
}
