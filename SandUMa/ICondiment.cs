namespace SandUMa
{
    public interface ICondiment : ISandwich
    {
        ISandwich Sandwich { get; }
    }
}
