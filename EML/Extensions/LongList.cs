using EML.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Extensions
{
    public class LongList<T> : IEnumerable<T>
    {
        private List<List<T>> list;

        private long count = -1;
        public long Count
        {
            get
            {
                if (count == -1)
                {
                    count = 0;
                    for (int i = 0; i < list.Count; i++)
                        count += list[i].Count;
                }
                return count;
            }
        }

        private LongListEnumerator<T> enumerator;
        
        #region Constructors
        public LongList()
        {
            list = new List<List<T>>();
            enumerator = new LongListEnumerator<T>(this);
        }
        public LongList(T item)
        {
            list = new List<List<T>> { new List<T> { item } };
            enumerator = new LongListEnumerator<T>(this);
        }
        public LongList(long emptyElements)
        {
            if (emptyElements >= 0)
            {
                list = new List<List<T>>();
                int outers = (int)(emptyElements >> 32);
                for (int i = 0; i < outers; i++)
                {
                    list.Add(new List<T>());
                    for (int j = 0; j < int.MaxValue; j++)
                        list[i].Add(default);
                }
                int innerElements = (int)((emptyElements << 32) >> 32);
                if (innerElements > 0)
                {
                    list.Add(new List<T>());
                    for (int i = 0; i < innerElements; i++)
                        list[outers + 1].Add(default);
                }
                enumerator = new LongListEnumerator<T>(this);
            }
            else
                throw new ArgumentException("The count of empty elements cannot be a negative number.");
        }
        public LongList(List<T> l)
        {
            list = new List<List<T>> { l };
            enumerator = new LongListEnumerator<T>(this);
        }
        public LongList(T[] ar)
        {
            list = new List<List<T>> { ar.ToList() };
            enumerator = new LongListEnumerator<T>(this);
        }
        #endregion

        #region Operations
        // TODO: Implement remove, insert functions
        /// <summary>Adds a new item to the list.</summary>
        /// <param name="item">The item to add to the list.</param>
        public void Add(T item)
        {
            // Ensure the list has less than the maximum possible number of elements before adding the new element to that, otherwise create a new list
            if (((Count << 32) >> 32) < int.MaxValue)
                list[list.Count - 1].Add(item);
            else
                list.Add(new List<T> { item });
            enumerator.MoveToLast();
            count++;
        }
        /// <summary>Adds a new item to the list.</summary>
        /// <param name="item">The item to add to the list.</param>
        public void AddRange(T[] items)
        {
            long a = 0;
            while (a < items.Length)
            {
                for (int i = list[list.Count - 1].Count; i < int.MaxValue && a < items.Length; i++, a++)
                    list[list.Count - 1].Add(items[a]);
                if (a > 0)
                    list.Add(new List<T>());
            }
            enumerator.MoveToLast();
            count += items.Length;
        }
        /// <summary>Removes a number of the last elements in the list.</summary>
        public void RemoveLast(long count)
        {
            if (count < 0)
                throw new ArgumentException("The count of elements to be removed cannot be a negative number.");
            if (count > Count)
                throw new ArgumentException("The count of elements to be removed cannot be greater than the count of the contained elements in the list.");
            while (count > 0)
            {
                int max = list[list.Count - 1].Count;
                int c = (int)General.Min(count, max);
                if (c == max)
                    list.RemoveAt(list.Count - 1);
                else
                    list[list.Count - 1].RemoveRange(max - c, c);
                count -= c;
            }
            this.count -= count;
        }
        /// <summary>Clears the entire list.</summary>
        public void Clear()
        {
            list = new List<List<T>>();
            count = 0;
        }
        /// <summary>Clones this list and returns a cloned copy of it.</summary>
        public LongList<T> Clone()
        {
            LongList<T> result = new LongList<T>();
            for (int i = 0; i < list.Count; i++)
                result.Add(this[i]);
            return result;
        }
        /// <summary>Returns the last item of the list.</summary>
        public T LastItem() => this[Count - 1];
        /// <summary>Creates an array from the list.</summary>
        public T[] ToArray()
        {
            T[] result = new T[Count];
            for (long i = 0; i < Count; i++)
                result[i] = this[i];
            return result;
        }
        #endregion

        #region Generators
        /// <summary>Generates a range of numbers.</summary>
        /// <param name="start">The first element to include.</param>
        /// <param name="end">The last element to include.</param>
        public static LongList<long> Range(long start, long end)
        {
            if (start <= end)
            {
                LongList<long> result = new LongList<long>();
                for (long i = start; i <= end; i++)
                    result.Add(i);
                return result;
            }
            else
                throw new ArgumentException("The ending element cannot be less than the starting element.");
        }

        #endregion

        public IEnumerator<T> GetEnumerator() => new LongListEnumerator<T>(this);
        IEnumerator IEnumerable.GetEnumerator() => new LongListEnumerator<T>(this);

        #region Accessors
        public T this[long index]
        {
            get => this[GetIndexFor(index)];
            set => this[GetIndexFor(index)] = value;
        }
        public T this[int indexA, int indexB]
        {
            get => list[indexA][indexB];
            set => list[indexA][indexB] = value;
        }
        public T this[(int a, int b) index]
        {
            get => this[index.a, index.b];
            set => this[index.a, index.b] = value;
        }
        #endregion

        (int a, int b) GetIndexFor(long index) => ((int)(index >> 32), (int)((index << 32) >> 32));
    }
    
    public class LongListEnumerator<T> : IEnumerator<T>
    {
        public LongList<T> List;

        long position = -1;
        long Position
        {
            get => position;
            set
            {
                positionOuter = (int)(value >> 32);
                positionInner = (int)((value << 32) >> 32);
                position = value;
            }
        }
        int positionOuter = 0;
        int positionInner = -1;
        
        public LongListEnumerator(LongList<T> list)
        {
            List = list;
        }

        public bool MoveNext()
        {
            if (positionInner < int.MaxValue)
                positionInner++;
            else
            {
                positionInner = 0;
                positionOuter++;
            }
            position++;
            return position < List.Count;
        }

        public void MoveToLast()
        {
            position = List.Count - 1;
        }

        public void Reset() => position = -1;

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public T Current
        {
            get
            {
                try
                {
                    return List[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}