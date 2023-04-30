namespace Richter.DesignPattern.Memento
{
    public interface IShoppingCard
    {
        IList<Product> Products { get; }
        Memento Add(Product product);
        Memento? Redo();
        Memento? Remove(Product product);
        Memento? Restore(Memento m);
        Memento? Undo();
    }
}