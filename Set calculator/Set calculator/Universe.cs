//using System.Collections;

//namespace Set_calculator
//{
//    internal class Universe<T> : ICollection<Set<T>> where T : IComparable
//    {
//        public Dictionary<string, Set<T>> Sets { get; set; } = new();
//        public T MinValue { get; private set; }
//        public T MaxValue { get; private set; }
//        public int Count { get; private set; }

//        public bool IsReadOnly { get; } = false;

//        public Universe(T minValue, T maxValue)
//        {
//            if (minValue.CompareTo(maxValue) > 1) throw new NotImplementedException();
//            MinValue = minValue;
//            MaxValue = maxValue;
//        }

//        private void Add(Set<T> item)
//        {
//            if (Sets.ContainsKey(item.Name)) throw new NotImplementedException();
//            Sets[item.Name] = item;
//        }

//        public void Clear()
//        {
//            throw new NotImplementedException();
//        }

//        public bool Contains(Set<T> item)
//        {
//            throw new NotImplementedException();
//        }

//        public void CopyTo(Set<T>[] array, int arrayIndex)
//        {
//            throw new NotImplementedException();
//        }

//        public bool Remove(Set<T> item)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerator<Set<T>> GetEnumerator()
//        {
//            throw new NotImplementedException();
//        }

//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            throw new NotImplementedException();
//        }

//        public class Set<T> : ICollection<T>
//        {
//            public T MinValue { get; private set; }
//            public T MaxValue { get; private set; }
//            public string Name { get; private set; }
//            public HashSet<T> Elements { get; private set; }

//            public int Count { get; private set; }

//            public bool IsReadOnly { get; } = false;

//            public Set(string name, T minValue, T maxValue)
//            {
//                Name = name;
//                MinValue = minValue;
//                MaxValue = maxValue;
//            }

//            public void Add(T item)
//            {
//                throw new NotImplementedException();
//            }

//            public void Clear()
//            {
//                throw new NotImplementedException();
//            }

//            public bool Contains(T item)
//            {
//                throw new NotImplementedException();
//            }

//            public void CopyTo(T[] array, int arrayIndex)
//            {
//                throw new NotImplementedException();
//            }

//            public bool Remove(T item)
//            {
//                throw new NotImplementedException();
//            }

//            public IEnumerator<T> GetEnumerator()
//            {
//                throw new NotImplementedException();
//            }

//            IEnumerator IEnumerable.GetEnumerator()
//            {
//                throw new NotImplementedException();
//            }
//        }
//    }
//}
