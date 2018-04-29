using System;

namespace Oefening23_5
{
    public class MyList<T> : IMyList<T>
    {
        public T[] arr = new T[100];
        public MyList()
        {
        }


        public void Add(T value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (typeof(T) == typeof(string))
                {
                    if (Convert.ToString(arr[i]) == "")
                    {
                        arr[i] = value;
                    }
                   
                }
            }
        }

        public void Remove(object value)
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new System.NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new System.NotImplementedException();
        }

    }
}