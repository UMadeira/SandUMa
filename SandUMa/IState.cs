namespace SandUMa
{
    public interface IState
    {
        void SelectBread( string aType );
        void SelectCondiment( string aType );
        void Confirm();
        void Pay( double aAmount );
        ISandwich Serve();
        void Cancel();
    }
}
