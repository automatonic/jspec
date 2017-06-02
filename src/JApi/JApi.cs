using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace JApi
{
    /// <summary>
    /// http://jsonapi.org/format/#document-jsonapi-object
    /// </summary>
    public class JApi : JObject
    {
        internal JApi(params object[] content)
            : base(content)
        {
        }

        /// <summary>
        /// Constructs the content of the JObject representation of this type
        /// </summary>
        /// <param name="version">an optional version string</param>
        /// <param name="meta">an optional meta object</param>
        /// <returns></returns>
        public static JApi For(string version = null, JObject meta = null)
        {
            var api = new JApi();
            if (!string.IsNullOrWhiteSpace(version))
            {
                api.Add(nameof(version), version);
            }
            if (meta != null)
            {
                api.Add(nameof(meta), meta);
            }
            return api;
        }
    }
}