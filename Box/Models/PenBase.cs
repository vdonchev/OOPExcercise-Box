namespace Box.Models
{
    using Interfaces;

    public abstract class PenBase : IWritable
    {
        protected PenBase(string color)
        {
            this.Color = color;
        }

        public string Color { get; }
    }
}