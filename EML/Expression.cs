﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    public class Expression
    {
        LargeDecimal[] Literals { get; set; }
        Operation[] Operations { get; set; }
    }
}
