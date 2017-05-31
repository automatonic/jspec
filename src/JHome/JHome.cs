using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JHome
{
    public class JHomeObject : JObject
    {
        public JHomeObject(JApiObject api, params JResourceProperty[] resources) : base(Content(resources, api).ToArray())
        {

        }

        public JHomeObject(params JResourceProperty[] resources) : base(Content(resources, default(JApiObject)).ToArray())
        {

        }

        private static IEnumerable<object> Content(JResourceProperty[] resources, JApiObject api)
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
