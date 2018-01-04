namespace SandUMa
{
    public class Butter : IBreadCondiment
    {
        public Butter( IBread aBread )
        {
            Componente = aBread;
        }

        public IBread Componente { get; }
        public string Description => Componente.Description + ", with Butter";
        public double ComputePrice() =>Componente.ComputePrice() + 0.2;
    }
}
