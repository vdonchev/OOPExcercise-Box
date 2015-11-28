namespace Box.Interfaces
{
    public interface IScissors
    {
        string Type { get; }

        string Cut();
    }
}