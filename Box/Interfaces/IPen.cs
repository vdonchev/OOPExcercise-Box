namespace Box.Interfaces
{
    public interface IPen
    {
        bool State { get; set; }

        void ChangeState();
    }
}