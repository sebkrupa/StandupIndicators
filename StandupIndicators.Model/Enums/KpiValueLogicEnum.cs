using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandupIndicators.Model.Enums
{
    public enum KpiValueLogicEnum
    {
        None = -1,
        Equals = 0,
        IsGreaterThan = 1,
        IsLessThan = 2,
        IsGreaterOrEqualThan = 3,
        IsLessOrEqualThan = 4,
        NotEquals = 5
    }
}
