using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Sets.Operations
{
    /// <summary>Represents the symmetric difference of two number set expressions.</summary>
    public class SymmetricDifference : SetOperation
    {
        public SetExpression Left;
        public SetExpression Right;

        public SymmetricDifference(SetExpression left, SetExpression right)
        {
            Left = left;
            Right = right;
        }
    }
}
