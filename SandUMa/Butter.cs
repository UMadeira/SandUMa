namespace SandUMa
{
    public class Butter : ICondiment
    {
        public Butter( ISandwich aSandwich )
        {
            Sandwich = aSandwich;
        }

        public ISandwich Sandwich { get; }
        public string Description => Sandwich.Description + ", with Butter";
        public double GetPrice() => Sandwich.GetPrice() + 0.2;
    }
}
