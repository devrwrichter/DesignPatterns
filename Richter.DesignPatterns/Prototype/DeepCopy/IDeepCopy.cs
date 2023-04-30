namespace Richter.DesignPattern.Prototype.DeepCopy
{
    public interface IDeepCopy<T> where T : new()
    {
        void CopyTo(T target);
        public T DeepCopy()
        {
            T t = new T();
            CopyTo(t);
            return t;
        }
    }
}
