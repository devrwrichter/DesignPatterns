namespace Richter.DesignPattern.Memento
{
    [Serializable]
    public record Memento
    {
        public IList<Product> Products { get; init ; }
    }
}
