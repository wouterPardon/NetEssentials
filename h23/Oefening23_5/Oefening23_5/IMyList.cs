using System.ComponentModel;

namespace Oefening23_5
{
    public interface IMyList<T>
    {
        void Add(T value);
        void Remove(object value);
        bool Contains(object value);
        int IndexOf(object value);
    }
}