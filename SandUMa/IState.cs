namespace SandUMa
{
    public interface IState
    {
        void SelectBread( string aType );
        void SelectCondiment( string aType );
        void Pay( double aAmount );
        IBread Serve();
        void Cancel();
    }
}
