using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public interface IBaseCollection
    {
        void Add(Object obj);
        void Remove(Object obj);
    }

    public static class BaseCollectionExtention
    {
        public static void AddRange(this IBaseCollection collection, IEnumerable<object> objects)
        {
            foreach (var item in objects)
            {
                collection.Add(item);
            }
        }
    }

    public class BaseList : IBaseCollection
    {
        private object[] items;
        private int count = 0;
        public BaseList(int initialCapacity)
        {
            items = new object[initialCapacity];
        }

        public void Add(object obj)
        {
            items[count] = obj;
        }

        public void Remove(object obj)
        {
            items[count] = null;
            count--;
        }
    }
}
