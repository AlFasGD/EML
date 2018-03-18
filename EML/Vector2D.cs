using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    /// <summary>Represents a two-dimensional vector.</summary>
    public struct Vector2D
    {
        /// <summary>The X value of the vector.</summary>
        public RealNumberExpression X;
        /// <summary>The Y value of the vector.</summary>
        public RealNumberExpression Y;

        /// <summary>Creates a new instance of <seealso cref="Vector2D"/>.</summary>
        /// <param name="x">The X value of the vector.</param>
        /// <param name="y">The Y value of the vector.</param>
        public Vector2D(RealNumberExpression x, RealNumberExpression y)
        {
            X = x;
            Y = y;
        }
        /// <summary>Creates a new instance of <seealso cref="Vector2D"/>.</summary>
        /// <param name="startingX">The X value of the starting point in the plane.</param>
        /// <param name="startingY">The Y value of the starting point in the plane.</param>
        /// <param name="endingX">The X value of the ending point in the plane.</param>
        /// <param name="endingY">The Y value of the ending point in the plane.</param>
        public Vector2D(RealNumberExpression startingX, RealNumberExpression startingY, RealNumberExpression endingX, RealNumberExpression endingY)
        {
            X = endingX - startingX;
            Y = endingY - startingY;
        }

        public static Vector2D operator +(Vector2D left, Vector2D right) => new Vector2D(left.X + right.X, left.Y + right.Y);
        public static Vector2D operator -(Vector2D left, Vector2D right) => new Vector2D(left.X - right.X, left.Y - right.Y);

        public static RealNumberExpression InnerProduct(Vector2D v)
        {
            return new RealNumberExpression("iv", new LargeDecimal[0], new OperationType[0]);
        }
    }
}