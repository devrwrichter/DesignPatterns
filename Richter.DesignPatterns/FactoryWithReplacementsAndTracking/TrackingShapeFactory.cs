using System.Linq;

namespace Richter.DesignPattern.FactoryWithReplacementsAndTracking
{
    public class TrackingShapeFactory
    {
        private List<WeakReference<IShape>> _shapes = new();
        public string Info => string.Join(", ", _shapes.Select(x => GetDescription(x)));

        private static string GetDescription(WeakReference<IShape> obj)
        {
            IShape shape;
            if (obj.TryGetTarget(out shape))
            {
                return shape.GetType().Name;
            }
            else
                return "Undefined";
        }

        public IShape Build(Shapes shape, Colors color, int radius)
        {
            IShape shape2 = new NullShape();
            switch (shape)
            {
                case Shapes.Star:
                    shape2 = new Star { Color = color, Radius = radius };
                    break;
                case Shapes.Circle:
                    shape2 = new Circle { Color = color, Radius = radius };
                    break;
                default:
                    throw new ArgumentException();
            }

            _shapes.Add(new WeakReference<IShape>(shape2));
            return shape2;
        }

    }
}
