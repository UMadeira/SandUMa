namespace SandUMa
{
    public abstract class State : IState
    {
        protected State( SandwichMachine aMachine )
        {
            Machine = aMachine;
        }

        protected SandwichMachine Machine { get; set; }

        public virtual void Cancel()
        {
            Machine.Bread   = null;
            Machine.Amount  = 0.0;
            Machine.Current = Machine.BreadSelection;
        }

        public virtual void   SelectBread( string aType ) {}
        public virtual void   SelectCondiment( string aType ) { }
        public virtual void   Pay( double aAmount ) { }
        public virtual IBread Serve() { return null; }
    }
}
