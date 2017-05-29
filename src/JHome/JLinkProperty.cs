using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace JHome
{
    /// <summary>
    /// whose member names are link relation types[RFC5988], and values are URLs[RFC3986]
    /// </summary>
    public class JLinkProperty : JProperty
    {
        public JLinkProperty(string relationType, string url) : base(
            name: relationType,
            content: url)
        {
        }


    }
}
