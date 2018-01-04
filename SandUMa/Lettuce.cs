namespace SandUMa
{
    public class Lettuce : IBreadCondiment
    {
        public Lettuce( IBread aBread )
        {
            Componente = aBread;
        }

        public IBread Componente { get; }
        public string Description => Componente.Description + ", with Lettuce";
        public double ComputePrice() => Componente.ComputePrice() + 0.5;
    }
}
