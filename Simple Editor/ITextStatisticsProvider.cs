using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Editor
{
    internal interface ITextStatisticsProvider
    {
        Dictionary<string, string> Calc();
    }
}
