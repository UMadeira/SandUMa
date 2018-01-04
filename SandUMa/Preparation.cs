namespace SandUMa
{
    public class Preparation : State
    {
        public Preparation( SandwichMachine aMachine ) : base( aMachine ) { }

        public override IBread Serve()
        {
            IBread bread = Machine.Bread;

            Machine.Bread   = null;
            Machine.Amount  = 0.0;
            Machine.Current = Machine.BreadSelection;

            return bread;
        }
    }
}
