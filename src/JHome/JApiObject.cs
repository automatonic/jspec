using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JHome
{
    public class JApiObject : JObject
    {
        public JApiObject(string title) : base(Content(title, null).ToArray())
        {
        }

        public JApiObject(string title, params JLinkProperty[] links) : base(Content(title, links).ToArray())
        {
        }

        public JApiObject(params JLinkProperty[] links) : base(Content(default(string), links).ToArray())
        {
        }

        private static IEnumerable<object> Content(string title, JLinkProperty[] links)
        {
            if (title != null)
            {
                yield return new JProperty(nameof(title), title);
            }
            if (links != null && links.Any())
            {
                yield return new JProperty(nameof(links), links);
            }
        }
    }
}
