namespace Box.Interfaces
{
    using System.Collections;

    public interface IBox
    {
        IEnumerable Items { get; }

        void AddItems(params IItem[] newItems);

        void RemoveItem(IItem item);
    }
}