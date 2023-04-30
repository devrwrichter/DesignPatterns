using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace Richter.DesignPattern.Memento
{
    public class ShoppingCard : IShoppingCard
    {
        public IList<Product> Products { get; private set; }
        private IList<Memento> Changes { get; set; }

        private int _current;

        public ShoppingCard()
        {
            Products = new List<Product>();
            Changes = new List<Memento>();
        }

        public Memento Add(Product product)
        {
            this.Products.Add(product);

            var m = new Memento { Products = Products.DeepClone<IList<Product>>() };

            Changes.Add(m);

            ++_current;
            return m;
        }

        public Memento? Restore(Memento m)
        {
            Changes.Add(m);
            ++_current;
            this.Products = m.Products;
            return m;
        }

        public Memento? Undo()
        {
            if (_current > 0)
            {
                var m = Changes[--_current];
                Products = m.Products;
                return m;
            }

            return null;
        }

        public Memento? Redo()
        {
            if (_current + 1 < Changes.Count)
            {
                var m = Changes[++_current];
                Products = m.Products;
                return m;
            }

            return null;
        }

        public Memento? Remove(Product product)
        {
            this.Products.Remove(product);

            var m = new Memento { Products = Products.DeepClone<IList<Product>>() };
            Changes.Add(m);

            --_current;
            return m;
        }
    }
}
