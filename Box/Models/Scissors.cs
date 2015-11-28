namespace Box.Models
{
    using System;
    using Interfaces;

    public class Scissors : IScissors, IItem
    {
        private Material type;

        public Scissors(string type)
        {
            this.Type = type;
        }

        public string Type
        {
            get
            {
                return this.type.ToString();
            }

            private set
            {
                Material scissorsType;
                if (!Enum.TryParse(value, out scissorsType))
                {
                    throw new ArgumentException($"Scissors materiаl cannot be {value}");
                }
                
                this.type = scissorsType;
            }
        }

        public string Cut()
        {
            return "I'll cut you bitch! :P";
        }

        public override string ToString()
        {
            return "I'm scissors, and i will cut you in a half.";
        }
    }
}