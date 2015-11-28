namespace Box.Models
{
    using Interfaces;

    public class Pen : PenBase, IPen, IItem
    {
        public Pen(string color) 
            : base(color)
        {
        }

        public bool State { get; set; }

        public void ChangeState()
        {
            this.State = !this.State;
        }

        public override string ToString()
        {
            return $"I'm a pen, my color is {this.Color}, and my current state is {(this.State ? "Swtiched-On" : "Swtiched-Off")}";
        }
    }
}