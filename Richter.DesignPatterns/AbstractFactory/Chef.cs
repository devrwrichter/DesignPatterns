namespace Richter.DesignPattern.AbstractFactory
{
    public class Chef
    {
        private Dictionary<LunchType, IFactoryLunch> _factories = new Dictionary<LunchType, IFactoryLunch>() {
            { LunchType.Hamburguer, new HamburguerFactory() },
            { LunchType.Omelet, new OmeletFactory() }
        };

        public IList<ILunch> GetLunchs(params LunchType[] types)
        {
            var lunches = new List<ILunch>();
            foreach (var t in types)
            {
                lunches.Add(_factories[t].Prepare());
            }

            return lunches;
        }
    }
}
