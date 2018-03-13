using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    /// <summary>Represents a mathematical operation.</summary>
    public class Operation
    {
        OperationType OperationType { get; set; }
        int Parameter { get; set; }
        
        public Operation(OperationType operationType, int parameter)
        {
            OperationType = operationType;
            Parameter = parameter;
        }
    }
}