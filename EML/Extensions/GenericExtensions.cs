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
    }
}
