namespace SandUMa
{
    public class Ham : IBreadCondiment
    {
        public Ham( IBread aBread )
        {
            Componente = aBread;
        }

        public IBread Componente { get; }
        public string Description => Componente.Description + ", with Ham";
        public double ComputePrice() => Componente.ComputePrice() + 0.7;
    }
}
