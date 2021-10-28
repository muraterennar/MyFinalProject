using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    // TEMEl Voidler için startup
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
