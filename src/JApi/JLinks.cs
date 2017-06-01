using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace JApi
{
    /// <summary>
    /// Where specified, a links member can be used to represent links. The value of each links member MUST be an object (a “links object”).
    /// </summary>
    public class JLinks : JObject
    {
        /// <summary>
        /// Creates a links object from the specified properties
        /// </summary>
        /// <param name="links"></param>
        public JLinks(params JLink[] links) : base(
            content: links)
        {
        }

        public static JLinks For(
            string self,
            string related,
            string first,
            string last,
            string prev,
            string next,
            params JLink[] additionalLinks)
       => For(
                JLink.ForSelf(self),
                JLink.ForRelated(related),
                JLink.ForFirst(first),
                JLink.ForLast(last),
                JLink.ForPrev(prev),
                JLink.ForNext(next))
        .AddRange(additionalLinks);

        public static JLinks For(params JLink[] links)
        {
            var validLinks = links.Where(x => x != null);
            if (validLinks.Any())
            {
                return null;
            }
            return new JLinks(validLinks.ToArray());
        }

        /// <summary>
        /// Add any of the supplied links (non-null) to this links object
        /// </summary>
        /// <param name="links"></param>
        /// <returns></returns>
        public JLinks AddRange(JLink[] links)
        {
            foreach (var link in links)
            {
                if (link != null)
                {
                    Add(link);
                }
            }
            return this;
        }
    }
}
