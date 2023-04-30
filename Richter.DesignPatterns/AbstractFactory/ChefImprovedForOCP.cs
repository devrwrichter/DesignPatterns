namespace Richter.DesignPattern.AbstractFactory
{
    public class ChefImprovedForOCP
    {
        private const string CommonNamespace = "Richter.DesignPatternFactory.AbstractFactory";
        private List<(LunchTypeImproveForOcp Type, IFactoryLunch Factory)> _factories = new List<(LunchTypeImproveForOcp, IFactoryLunch)>();

        public ChefImprovedForOCP()
        {
            InitializeFactories();
        }

        public IList<ILunch> GetLunchs(params LunchTypeImproveForOcp[] types)
        {
            var lunches = new List<ILunch>();
            foreach (var t in types)
            {
                lunches.Add(_factories.FirstOrDefault(x => x.Type.Equals(t)).Factory.Prepare());
            }

            return lunches;
        }

        private void InitializeFactories()
        {
            foreach (var t in typeof(ChefImprovedForOCP).Assembly.GetTypes())
            {
                if (typeof(IFactoryLunch).IsAssignableFrom(t) && !t.IsInterface)
                {
                    var name = t.Name.Replace(CommonNamespace, string.Empty);
                    var enumType = Utils.GetEnumByFactoryName(name);
                    _factories.Add((enumType, (IFactoryLunch)Activator.CreateInstance(t)));
                }
            }
        }
    }
}
