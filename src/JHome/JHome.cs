using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JHome
{
    public class JHome : JObject
    {
        public JHome(JApi api, params JResourceProperty[] resources) : base(Content(resources, api).ToArray())
        {

        }

        public JHome(params JResourceProperty[] resources) : base(Content(resources, default(JApi)).ToArray())
        {

        }

        private static IEnumerable<object> Content(JResourceProperty[] resources, JApi api)
        {
            if (resources == null || !resources.Any())
            {
                throw new ArgumentNullException(nameof(resources));
            }
            yield return new JProperty(nameof(resources), resources);
            if (api != null)
            {
                yield return new JProperty(nameof(api), api);
            }
        }
    }
}
