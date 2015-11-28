namespace Box.Models
{
    using Interfaces;

    public class Pencil : PenBase, IItem
    {
        public Pencil(string color) 
            : base(color)
        {
        }

        public override string ToString()
        {
            return $"I'm a pencil and my color is {this.Color}";
        }
    }
}