namespace Box.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using Interfaces;

    public class Box : IBox
    {
        private readonly IList<IItem> items = new List<IItem>();

        public IEnumerable Items
        {
            get
            {
                return this.items;
            }
        }

        public void AddItems(params IItem[] newItems)
        {
            foreach (var item in newItems)
            {
                this.items.Add(item);
            }
        }

        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }
    }
}