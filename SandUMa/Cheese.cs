namespace SandUMa
{
    public class Cheese : ICondiment
    {
        public Cheese( ISandwich aSandwich )
        {
            Sandwich = aSandwich;
        }

        public ISandwich Sandwich { get; }
        public string Description => Sandwich.Description + ", with Cheese";
        public double GetPrice() => Sandwich.GetPrice() + 0.8;
    }
}
