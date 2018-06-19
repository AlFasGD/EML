using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Extensions
{
    public static class GenericExtensions
    {
        public static int Find<T>(this T[] ar, T element)
        {
            for (int i = 0; i < ar.Length; i++)
                if (ar[i].Equals(element))
                    return i;
            return -1;
        }

        public static List<T> Clone<T>(this List<T> list)
        {
            List<T> result = new List<T>();
            for (int i = 0; i < list.Count; i++)
                result.Add(list[i]);
            return result;
        }
    }
}