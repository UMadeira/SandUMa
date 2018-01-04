using System.Diagnostics;

namespace SandUMa
{
    public class Payment : State
    {
        public Payment( SandwichMachine aMachine ) : base( aMachine ) { }

        public override void Pay( double aAmount )
        {
            Debug.Assert( Machine.Sandwich != null );
            Machine.Amount += aAmount;
            var amount = Machine.Sandwich.GetPrice();
            if ( Machine.Amount >= amount )
            {
                Machine.Amount -= amount;
                Machine.Current = Machine.Preparation;
            }
        }
    }
}
