using Newtonsoft.Json.Linq;

namespace JApi
{
    //http://jsonapi.org/format/#document-resource-identifier-objects
    public class JResource : JObject
    {
        public JResource (string type, object id) 
            : base(
                new JProperty(nameof(type), type),
                new JProperty(nameof(id), id)
                )
        {
        }

        public JResource (string type, object id, JObject meta) 
            : base(
                new JProperty(nameof(type), type),
                new JProperty(nameof(id), id),
                new JProperty(nameof(meta), meta)
                )
        {
        }

        internal JResource (string type, object id, JObject meta, object[] content) 
            : base(
                new JProperty(nameof(type), type),
                new JProperty(nameof(id), id),
                new JProperty(nameof(meta), meta)
                )
        {
        }
    }
}
