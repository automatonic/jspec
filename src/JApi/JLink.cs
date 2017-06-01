using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JApi
{
    /// <summary>
    /// Each member of a links object is a "link"
    /// </summary>
    public partial class JLink : JProperty
    {
        internal JLink(string name, object content) : base(
            name: name,
            content: content)
        {
        }

        public static JLink For(string name, string href)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            return new JLink(name, href);
        }

        public static JLink For(string name, string href, JObject meta)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (meta == null)
            {
                return For(name: name, href: href);
            }

            var content = new JObject(
                new JProperty(name: nameof(href), content: href),
                new JProperty(name: nameof(meta), content: meta));
            return new JLink(name, content);
        }

        public static IEnumerable<JLink> Concat(
            string self,
            string related,
            string first,
            string last,
            string prev,
            string next,
            params JLink[] links)
        {
            if (!string.IsNullOrWhiteSpace(self))
            {
                yield return new JLink(nameof(self), self);
            }
            if (!string.IsNullOrWhiteSpace(related))
            {
                yield return new JLink(nameof(related), related);
            }
            if (!string.IsNullOrWhiteSpace(first))
            {
                yield return new JLink(nameof(first), first);
            }
            if (!string.IsNullOrWhiteSpace(last))
            {
                yield return new JLink(nameof(last), last);
            }
            if (!string.IsNullOrWhiteSpace(prev))
            {
                yield return new JLink(nameof(prev), prev);
            }
            if (!string.IsNullOrWhiteSpace(next))
            {
                yield return new JLink(nameof(next), next);
            }
            if (links != null)
            {
                foreach (var link in links)
                {
                    yield return link;
                }
            }
        }
    }
}
