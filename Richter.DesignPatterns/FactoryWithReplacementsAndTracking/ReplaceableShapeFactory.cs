namespace Richter.DesignPattern.FactoryWithReplacementsAndTracking
{
    public class ReplaceableShapeFactory
    {
        private List<WeakReference<Ref<IShape>>> _shapes = new();
        public string Info => string.Join(", ", _shapes.Select(x => GetDescription(x)));

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

            Ref<IShape> refShape = new Ref<IShape>(shape2);

            _shapes.Add(new WeakReference<Ref<IShape>>(refShape));

            return shape2;
        }

        public void ReplaceShapeColor<T>(Colors newColor)where T : IShape
        {
            foreach(var shape in _shapes)
            {
                var candidate = GetObject(shape);
                if(candidate is T)
                {
                    candidate.Color = newColor;
                }
            }
        }

        private static IShape GetObject(WeakReference<Ref<IShape>> shape)
        {
            Ref<IShape> sh;
            if (shape.TryGetTarget(out sh))
            {
                return sh.Value;
            }
            else
                return null;
        }

        private static string GetDescription(WeakReference<Ref<IShape>> obj)
        {
            var sh = GetObject(obj);
            if (sh != null)
            {
                return $"Shape type: {sh.GetType().Name}, Color: {sh.Color}";
            }
            else
                return "Undefined";
        }
    }
}
