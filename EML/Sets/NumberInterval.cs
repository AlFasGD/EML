using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.Expressions;
using EML.Sets.SpecialNumberSets;
using EML.Sets.Types;

namespace EML.Sets
{
    /// <summary>Represents a number interval.</summary>
    public class RealNumberInterval
    {
        public ISpecialNumberSet IntervalDomain { get; set; }
        public bool IsCompleteIntervalDomain { get; set; }
        public NumericExpression Left { get; set; }
        public NumericExpression Right { get; set; }
        public bool ClosedLeft { get; set; }
        public bool ClosedRight { get; set; }

        public RealNumberInterval(NumericExpression left, NumericExpression right, bool closedLeft, bool closedRight)
        {
            IntervalDomain = new Real();
            IsCompleteIntervalDomain = false;
            Left = left;
            Right = right;
            ClosedLeft = closedLeft;
            ClosedRight = closedRight;
        }
        public RealNumberInterval(NumericExpression left, NumericExpression right, bool closedLeft, bool closedRight, ISpecialNumberSet s)
        {
            IntervalDomain = s;
            IsCompleteIntervalDomain = false;
            Left = left;
            ClosedLeft = closedLeft;
            ClosedRight = closedRight;
            Right = right;
        }
        public RealNumberInterval(ISpecialNumberSet s)
        {
            IntervalDomain = s;
            IsCompleteIntervalDomain = true;
            Left = null;
            Right = null;
            ClosedLeft = false;
            ClosedRight = false;
        }
        
        public static bool IsSubset(RealNumberInterval target, RealNumberInterval container)
        {
            if (target.IntervalDomain == container.IntervalDomain)
                return container.IsCompleteIntervalDomain || container.Left <= target.Left && container.Right >= target.Right;
            else return false;
        }

        public static bool operator ==(RealNumberInterval left, RealNumberInterval right)
        {
            if (left.IntervalDomain == right.IntervalDomain)
            {
                if (left.IsCompleteIntervalDomain == right.IsCompleteIntervalDomain)
                    return true;
                else
                    return left.Left == right.Left && left.Right == right.Right && left.ClosedLeft == right.ClosedLeft && left.ClosedRight == right.ClosedRight;
            }
            return false;
        }
        public static bool operator !=(RealNumberInterval left, RealNumberInterval right)
        {
            if (left.IntervalDomain != right.IntervalDomain)
            {
                if (left.IsCompleteIntervalDomain != right.IsCompleteIntervalDomain)
                    return true;
                else
                    return left.Left != right.Left && left.Right != right.Right && left.ClosedLeft != right.ClosedLeft && left.ClosedRight != right.ClosedRight;
            }
            return false;
        }
    }
}