using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Sets.Operations
{
    /// <summary>Represents the intersection of two number set expressions.</summary>
    public class Intersection : SetOperation
    {
        public SetExpression Left;
        public SetExpression Right;

        public Intersection(SetExpression left, SetExpression right)
        {
            Left = left;
            Right = right;
        }
    }
}
