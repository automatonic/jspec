using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JHome
{
    public class JApi : JObject
    {
        public JApi(string title) : base(Content(title, null).ToArray())
        {
        }

        public JApi(string title, params JLink[] links) : base(Content(title, links).ToArray())
        {
        }

        public JApi(params JLink[] links) : base(Content(default(string), links).ToArray())
        {
        }

        private static IEnumerable<object> Content(string title, JLink[] links)
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
