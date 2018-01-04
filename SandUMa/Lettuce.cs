namespace SandUMa
{
    public class Lettuce : ICondiment
    {
        public Lettuce( ISandwich aSandwich )
        {
            Sandwich = aSandwich;
        }

        public ISandwich Sandwich { get; }
        public string Description => Sandwich.Description + ", with Lettuce";
        public double GetPrice() => Sandwich.GetPrice() + 0.5;
    }
}
