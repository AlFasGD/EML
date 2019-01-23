using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.Expressions;
using EML.Expressions.Constants;
using EML.Expressions.Operations;
using EML.Expressions.Operations.Basic;

namespace EML.NumericTypes.Vectors
{
    /// <summary>Represents a two-dimensional vector.</summary>
    public struct Vector2D
    {
        /// <summary>The X value of the vector.</summary>
        public RealNumericExpression X;
        /// <summary>The Y value of the vector.</summary>
        public RealNumericExpression Y;
        /// <summary>The length of the vector.</summary>
        public RealNumericExpression Length => X * X + Y * Y;

        /// <summary>Creates a new instance of <seealso cref="Vector2D"/>.</summary>
        /// <param name="x">The X value of the vector.</param>
        /// <param name="y">The Y value of the vector.</param>
        public Vector2D(RealNumericExpression x, RealNumericExpression y)
        {
            X = x;
            Y = y;
        }
        /// <summary>Creates a new instance of <seealso cref="Vector2D"/>.</summary>
        /// <param name="startingX">The X value of the starting point in the plane.</param>
        /// <param name="startingY">The Y value of the starting point in the plane.</param>
        /// <param name="endingX">The X value of the ending point in the plane.</param>
        /// <param name="endingY">The Y value of the ending point in the plane.</param>
        public Vector2D(RealNumericExpression startingX, RealNumericExpression startingY, RealNumericExpression endingX, RealNumericExpression endingY)
        {
            X = endingX - startingX;
            Y = endingY - startingY;
        }
        /// <summary>Creates a new instance of <seealso cref="Vector2D"/>.</summary>
        /// <param name="v">The value tuple containing the coordinations of the vector.</param>
        public Vector2D((RealNumericExpression, RealNumericExpression) v)
        {
            X = v.Item1;
            Y = v.Item2;
        }
        /// <summary>Creates a new instance of <seealso cref="Vector2D"/>.</summary>
        /// <param name="start">The value tuple containing the starting coordinations of the vector.</param>
        /// <param name="end">The value tuple containing the ending coordinations of the vector.</param>
        public Vector2D((RealNumericExpression, RealNumericExpression) start, (RealNumericExpression, RealNumericExpression) end)
        {
            X = end.Item1 - start.Item1;
            Y = end.Item2 - start.Item2;
        }

        public static Vector2D operator +(Vector2D left, Vector2D right) => new Vector2D(left.X + right.X, left.Y + right.Y);
        public static Vector2D operator -(Vector2D left, Vector2D right) => new Vector2D(left.X - right.X, left.Y - right.Y);

        /// <summary>Returns the inner product of the vector.</summary>
        /// <param name="v">The vector to get the inner product of.</param>
        public static RealNumericExpression InnerProduct(Vector2D v)
        {
            return new RealConstant("iv", new Multiplication(v.X, v.Y));
        }

        /// <summary>Converts the vector to its string representation.</summary>
        public override string ToString() => "(" + X.ToString() + ", " + Y.ToString() + ")";
    }
}