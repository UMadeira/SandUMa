namespace SandUMa
{
    public class Cheese : IBreadCondiment
    {
        public Cheese( IBread aBread )
        {
            Componente = aBread;
        }

        public IBread Componente { get; }
        public string Description => Componente.Description + ", with Cheese";
        public double ComputePrice() => Componente.ComputePrice() + 0.8;
    }
}
