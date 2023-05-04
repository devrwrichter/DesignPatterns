using System.Reflection;

namespace Richter.DesignPattern.AbstractFactory
{
    internal class Utils
    {
        private static string GetEnumFactoryName(LunchTypeImproveForOcp value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            FactoryNameAttribute[] attributes = fi.GetCustomAttributes(typeof(FactoryNameAttribute), false) as FactoryNameAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }

        internal static LunchTypeImproveForOcp GetEnumByFactoryName(string name)
        {
            var values = Enum.GetValues(typeof(LunchTypeImproveForOcp));
            foreach (var value in values)
            {
                if (GetEnumFactoryName((LunchTypeImproveForOcp)value).Equals(name))
                {
                    return (LunchTypeImproveForOcp)value;
                }
            }

            return LunchTypeImproveForOcp.Unknown;

        }
    }
}
