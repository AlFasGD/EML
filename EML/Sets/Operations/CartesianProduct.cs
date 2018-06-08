using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Sets.Operations
{
    /// <summary>Represents the Cartesian product of two number set expressions.</summary>
    public class CartesianProduct : SetOperation
    {
        public SetExpression Left;
        public SetExpression Right;

        public CartesianProduct(SetExpression left, SetExpression right)
        {
            Left = left;
            Right = right;
        }
    }
}
