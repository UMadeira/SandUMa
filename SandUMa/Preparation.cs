namespace SandUMa
{
    public class Preparation : State
    {
        public Preparation( SandwichMachine aMachine ) : base( aMachine ) { }

        public override ISandwich Serve()
        {
            ISandwich sandwich = Machine.Sandwich;

            Machine.Sandwich   = null;
            Machine.Amount  = 0.0;
            Machine.Current = Machine.BreadSelection;

            return sandwich;
        }
    }
}
