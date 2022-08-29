using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandupIndicators.DB.Enums
{
    public enum StatusEnum
    {
        GeneralFailue = -1,
        OK = 0,
        AlreadyExists = 1,
        SyntaxError = 2,
        SaveFailure = 3


    }
}
