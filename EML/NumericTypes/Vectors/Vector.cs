using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.Expressions;

namespace EML.NumericTypes.Vectors
{
    /// <summary>Represents a multi-dimensional vector.</summary>
    public struct Vector
    {
        /// <summary>The values of the vector.</summary>
        public RealNumericExpression[] Values;
        /// <summary>Gets the number of dimensions of the vector.</summary>
        public int Dimensions => Values.Length;

        /// <summary>Creates a new instance of <seealso cref="Vector"/>.</summary>
        /// <param name="v">The values of the vector.</param>
        public Vector(params RealNumericExpression[] v)
        {
            Values = v;
        }
        /// <summary>Creates a new instance of <seealso cref="Vector"/>.</summary>
        /// <param name="start">The coordinates of the starting point.</param>
        /// <param name="end">The coordinates of the ending point.</param>
        public Vector(RealNumericExpression[] start, RealNumericExpression[] end)
        {
            if (start.Length == end.Length)
            {
                RealNumericExpression[] v = new RealNumericExpression[start.Length];
                for (int i = 0; i < v.Length; i++)
                    v[i] = end[i] - start[i];
                Values = v;
            }
            throw new ArgumentException();
        }
        
        public static Vector operator +(Vector left, Vector right)
        {
            if (left.Dimensions == right.Dimensions)
            {
                Vector v = new Vector(new RealNumericExpression[left.Dimensions]);
                for (int i = 0; i < v.Dimensions; i++)
                    v[i] = left[i] + right[i];
                return v;
            }
            throw new ArgumentException();
        }
        public static Vector operator -(Vector left, Vector right)
        {
            if (left.Dimensions == right.Dimensions)
            {
                Vector v = new Vector(new RealNumericExpression[left.Dimensions]);
                for (int i = 0; i < v.Dimensions; i++)
                    v[i] = left[i] - right[i];
                return v;
            }
            throw new ArgumentException();
        }

        /// <summary>Gets the value of the vector at the specified dimension.</summary>
        /// <param name="i">The dimension to get the value of the vector.</param>
        public RealNumericExpression this[int i]
        {
            get => Values[i];
            set => Values[i] = value;
        }

        /// <summary>Converts the vector to its string representation.</summary>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder("(");
            for (int i = 0; i < Values.Length; i++)
                result.Append(Values[i].ToString() + ", ");
            result = result.Remove(result.Length - 2, 2);
            result.Append(")");
            return result.ToString();
        }
    }
}
