using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core
{
    interface IParserSettings
    {
        string BaseUrl { get; set; }
        string Prefix { get; set; }

        int Startpoint { get; set; }
        int Endpoint { get; set; }

    }
}
