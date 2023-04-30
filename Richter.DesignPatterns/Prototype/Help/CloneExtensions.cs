using Richter.DesignPattern.Prototype.DeepCopy;
using System.Runtime.Serialization.Formatters.Binary;

namespace Richter.DesignPattern.Prototype.Help
{
    public static class CloneExtensions
    {
        public static T DeepCopy<T>(this IDeepCopy<T> obj) where T : new()
        {
            return obj.DeepCopy();
        }

        public static T DeepCopyWithSerialization<T>(this T self)
        {
            if (!typeof(T).IsSerializable)
                throw new ArgumentException("Type must be serializable", nameof(self));
            if (ReferenceEquals(self, null)) return default;
            var stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter(); formatter.Serialize(stream, self);
            stream.Seek(0, SeekOrigin.Begin);
            return (T)formatter.Deserialize(stream);
        }
    }
}
