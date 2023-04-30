﻿using System.Runtime.Serialization.Formatters.Binary;

namespace Richter.DesignPattern.Memento
{
    public static class CloneHelper
    {
        public static T DeepClone<T>(this T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
    }
}
