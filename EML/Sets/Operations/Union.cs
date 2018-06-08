using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Sets.Operations
{
    /// <summary>Represents the union of two number set expressions.</summary>
    public class Union : SetOperation
    {
        public SetExpression Left;
        public SetExpression Right;

        public Union(SetExpression left, SetExpression right)
        {
            Left = left;
            Right = right;
        }
    }
}
