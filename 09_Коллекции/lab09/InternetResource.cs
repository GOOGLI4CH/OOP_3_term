using System;
using System.Collections;
using System.Collections.Generic;

namespace lab09
{
    public class InternetResource : IList
    {
        private List<object> pages = new List<object>();
        public struct ResourceInfo
        {
            public string Name { get; private set; }
            public string Domain { get; private set; }
            public string Description { get; private set; }
            public string MetaData { get; private set; }

            public ResourceInfo(string name, string domain, string description, string metaData)
            {
                Name = name;
                Domain = domain;
                Description = description;
                MetaData = metaData;
            }
        }
        public ResourceInfo Resource { get; set; }

        public InternetResource(string name, string domain, string description, string metaData) 
        {
            Resource = new ResourceInfo(name, domain, description, metaData);
        }

        public void AddPage(string page)
        {
            pages.Add(page);
        }

        public void RemovePage(string page)
        {
            pages.Remove(page);
        }

        public int Add(object value)
        {
            pages.Add(value);
            return pages.Count - 1;
        }

        public bool Contains(object value)
        {
            return pages.Contains(value);
        }

        public void Clear()
        {
            pages.Clear();
        }

        public int IndexOf(object value)
        {
            return pages.IndexOf(value);
        }

        public void Insert(int index, object value)
        {
            pages.Insert(index, value);
        }

        public void Remove(object value)
        {
            pages.Remove(value);
        }

        public void RemoveAt(int index)
        {
            pages.RemoveAt(index);
        }

        public void CopyTo(Array array, int index)
        {
            pages.CopyTo((object[])array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return pages.GetEnumerator();
        }

        public object this[int index]
        {
            get { return pages[index]; }
            set { pages[index] = value; }
        }

        public bool IsReadOnly => false;

        public bool IsFixedSize => false;

        public int Count => pages.Count;

        public object SyncRoot => null;

        public bool IsSynchronized => false;
    }
}
