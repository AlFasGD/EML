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

        /// <summary>The total count of all the elements in the <seealso cref="LongList{T}"/>.</summary>
        public long Count { get; private set; } = -1;

        private LongListEnumerator<T> enumerator;

        #region Constructors
        /// <summary>Creates a new instance of the <seealso cref="LongList{T}"/> class.</summary>
        public LongList()
        {
            list = new List<List<T>> { new List<T>() };
            enumerator = new LongListEnumerator<T>(this);
            Count = 0;
        }
        /// <summary>Creates a new instance of the <seealso cref="LongList{T}"/> class that contains an item.</summary>
        /// <param name="item">The item to add to the <seealso cref="LongList{T}"/>.</param>
        public LongList(T item)
        {
            list = new List<List<T>> { new List<T> { item } };
            enumerator = new LongListEnumerator<T>(this);
            Count = 1;
        }
        /// <summary>Creates a new instance of the <seealso cref="LongList{T}"/> class that contains a specified amount of empty elements.</summary>
        /// <param name="emptyElements">The amount of empty elements to add to the <seealso cref="LongList{T}"/>.</param>
        public LongList(long emptyElements)
        {
            if (emptyElements >= 0)
            {
                list = new List<List<T>> { new List<T>() };
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
                Count = emptyElements;
            }
            else
                throw new ArgumentException("The count of empty elements cannot be a negative number.");
        }
        /// <summary>Creates a new instance of the <seealso cref="LongList{T}"/> class that contains elements from a <seealso cref="List{T}"/>.</summary>
        /// <param name="l">The <seealso cref="List{T}"/> whose elements to add to the <seealso cref="LongList{T}"/>.</param>
        public LongList(List<T> l)
        {
            list = new List<List<T>> { l };
            enumerator = new LongListEnumerator<T>(this);
            Count = l.Count;
        }
        /// <summary>Creates a new instance of the <seealso cref="LongList{T}"/> class that contains elements from an array.</summary>
        /// <param name="ar">The array whose elements to add to the <seealso cref="LongList{T}"/>.</param>
        public LongList(T[] ar)
        {
            list = new List<List<T>> { ar.ToList() };
            enumerator = new LongListEnumerator<T>(this);
            Count = ar.Length;
        }
        #endregion

        #region Operations
        /// <summary>Adds a new item to the list.</summary>
        /// <param name="item">The item to add to the list.</param>
        public void Add(T item)
        {
            if (((Count << 32) >> 32) < int.MaxValue)
                list[list.Count - 1].Add(item);
            else
                list.Add(new List<T> { item });
            enumerator.MoveToLast();
            Count++;
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
                if (a < items.Length)
                    list.Add(new List<T>());
            }
            enumerator.MoveToLast();
            Count += items.Length;
        }
        /// <summary>Removes a number of the last elements in the list.</summary>
        public void RemoveLast(long count)
        {
            if (count < 0)
                throw new ArgumentException("The count of elements to be removed cannot be a negative number.");
            if (count > Count)
                throw new ArgumentException("The count of elements to be removed cannot be greater than the count of the contained elements in the list.");
            Count -= count;
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
            enumerator.MoveToLast();
        }
        /// <summary>Clears the entire list.</summary>
        public void Clear()
        {
            list = new List<List<T>>();
            Count = 0;
            enumerator.Reset();
        }
        /// <summary>Clones this list and returns a cloned copy of it.</summary>
        public LongList<T> Clone()
        {
            LongList<T> result = new LongList<T>();
            for (long i = 0; i < Count; i++)
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
        /// <summary>The <seealso cref="LongList{T}"/> to enumerate.</summary>
        public LongList<T> List;

        private long position = -1;
        /// <summary>The position of the <seealso cref="LongListEnumerator{T}"/>.</summary>
        public long Position
        {
            get => position;
            set
            {
                positionOuter = (int)(value >> 32);
                positionInner = (int)((value << 32) >> 32);
                position = value;
            }
        }
        private int positionOuter = 0;
        private int positionInner = -1;

        /// <summary>Creates a new instance of the <seealso cref="LongListEnumerator{T}"/> class referring to a <seealso cref="LongList{T}"/> that will be enumerated.</summary>
        /// <param name="list">The <seealso cref="LongList{T}"/> to enumerate.</param>
        public LongListEnumerator(LongList<T> list)
        {
            List = list;
        }

        /// <summary>Moves the current position of the <seealso cref="LongListEnumerator{T}"/> to the next position. Returns <see langword="true"/> if the position is a valid index, otherwise <see langword="false"/>.</summary>
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

        /// <summary>Moves the current position of the <seealso cref="LongListEnumerator{T}"/> to the last position.</summary>
        public void MoveToLast()
        {
            Position = List.Count - 1;
        }

        /// <summary>Resets the current position of the <seealso cref="LongListEnumerator{T}"/> to the default position.</summary>
        public void Reset()
        {
            position = -1;
            positionInner = -1;
            positionOuter = 0;
        }

        object IEnumerator.Current => Current;

        /// <summary>Disposes this <seealso cref="LongListEnumerator{T}"/>.</summary>
        public void Dispose() { }

        /// <summary>The current element that is being iterated in the <seealso cref="LongList{T}"/>.</summary>
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