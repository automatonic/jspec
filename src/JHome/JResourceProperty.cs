using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace JHome
{
    /// <summary>
    /// whose member names are link relation types[RFC5988], and values are URLs[RFC3986]
    /// </summary>
    public class JResourceProperty : JProperty
    {
        /// <summary>
        /// Direct links are indicated with an "href" property, whose value is a URI[RFC3986].
        /// </summary>
        /// <param name="relationType"></param>
        /// <param name="href"></param>
        public JResourceProperty(string relationType, string href) : base(
            name: relationType,
            content: Content(href))
        {
        }

        public JResourceProperty(string relationType, string hrefTemplate, params JProperty[] hrefVars) : base(
            name: relationType,
            content: Content(hrefTemplate, hrefVars))
        {
        }

        private static object Content(string href)
        {
            if (href == null)
            {
                throw new ArgumentNullException(nameof(href));
            }
            return new JObject(
                new JProperty(nameof(href), href));
        }

        private static object Content(string hrefTemplate, JProperty[] hrefVars)
        {
            if (hrefTemplate == null)
            {
                throw new ArgumentNullException(nameof(hrefTemplate));
            }
            if (!hrefVars.Any())
            {
                throw new ArgumentException(nameof(hrefVars));
            }
            return new JObject(
                new JProperty(nameof(hrefTemplate), hrefTemplate),
                new JProperty(nameof(hrefVars), new JObject(hrefVars)));
        }
    }
}
