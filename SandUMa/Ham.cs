namespace SandUMa
{
    public class Ham : ICondiment
    {
        public Ham( ISandwich aSandwich )
        {
            Sandwich = aSandwich;
        }

        public ISandwich Sandwich { get; }
        public string Description => Sandwich.Description + ", with Ham";
        public double GetPrice() => Sandwich.GetPrice() + 0.7;
    }
}
