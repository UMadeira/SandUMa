namespace SandUMa
{
    public class SandwichMachine
    {
        #region Singleton SandwichMachine

        static SandwichMachine()
        {
        }

        private SandwichMachine()
        {
            BreadSelection = new BreadSelection( this );
            CondimentSelection = new CondimentSelection( this );
            Payment = new Payment( this );
            Preparation = new Preparation( this );
            OutOfService = new OutOfService( this );

            Current = BreadSelection;
        }

        public static SandwichMachine Instance = new SandwichMachine();
        #endregion

        public SandwichFactory Factory { get; } = new SandwichFactory();

        public IBread Bread { get; set; }
        public double Amount { get; set; }

        // States

        public IState OutOfService { get; }
        public IState BreadSelection { get; } 
        public IState CondimentSelection { get; } 
        public IState Payment { get; } 
        public IState Preparation { get; }

        public IState Current { get; set; }
        
        // Event Handlers

        public void   SelectBread( string aType ) => Current.SelectBread( aType );
        public void   SelectCondiment( string aType ) => Current.SelectCondiment( aType );
        public void   Pay( double aAmount ) => Current.Pay( aAmount );
        public IBread Serve() => Current.Serve();
        public void   Cancel() => Current.Cancel();
    }
}
