using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System;

namespace JApi
{
    /// <summary>
    /// http://jsonapi.org/format/#document-structure
    /// </summary>
    public class JDocument : JObject
    {
        internal JDocument(params object[] content) : base(content)
        {
        }

        /// <summary>
        /// Creates a JSON API document for a single resource
        /// </summary>
        /// <param name="resource">the document's "primary data" resource</param>
        /// <param name="meta">a meta object that contains non-standard meta-information</param>
        /// <param name="jsonapi">details about the api</param>
        /// <param name="self">the link that generated the current response document</param>
        /// <param name="related">a related resource link when the primary data represents a resource relationship</param>
        /// <param name="first">the first page of data</param>
        /// <param name="last">the last page of data</param>
        /// <param name="prev">the prev page of data</param>
        /// <param name="next">the next page of data</param>
        /// <param name="additionalLinks">additional custom links</param>
        /// <param name="included">an array of resource objects that are related to the primary data and/or each other</param>
        public static JDocument ForResource(
            JResource resource,
            JObject meta = null,
            JApi jsonapi = null,
            string self = null,
            string related = null,
            string first = null,
            string last = null,
            string prev = null,
            string next = null,
            JLink[] additionalLinks = null,
            JResource[] included = null)
        => ForResource(
            resource: resource,
            meta: meta,
            jsonapi: jsonapi,
            links: JLinks.For(
                self: self,
                related: related,
                first: first,
                last: last,
                prev: prev,
                next: next,
                additionalLinks: additionalLinks),
            included: included
        );

        /// <summary>
        /// Creates a JSON API document for a single resource
        /// </summary>
        /// <param name="resource">the document's "primary data" resource</param>
        /// <param name="meta">a meta object that contains non-standard meta-information</param>
        /// <param name="jsonapi">details about the api</param>
        /// <param name="links">the links relevant to the current resource context</param>
        /// <param name="included">an array of resource objects that are related to the primary data and/or each other</param>
        public static JDocument ForResource(
            JResource resource,
            JObject meta = null,
            JApi jsonapi = null,
            JLinks links = null,
            JResource[] included = null)
        {
            if (resource == null)
            {
                throw new ArgumentNullException(nameof(resource));
            }

            var document = new JDocument(new JProperty("data", resource));
            if (meta != null)
            {
                document.Add(nameof(meta), meta);
            }
            if (jsonapi != null)
            {
                document.Add(nameof(jsonapi), jsonapi);
            }
            if (links != null && links.HasValues)
            {
                document.Add(nameof(links), links);
            }
            if (included != null)
            {
                document.Add(nameof(included), new JArray(included));
            }
            return document;
        }

        /// <summary>
        /// Creates a JSON API document for a resource collection
        /// </summary>
        /// <param name="resources">the document's "primary data" resource collection</param>
        /// <param name="meta">a meta object that contains non-standard meta-information</param>
        /// <param name="jsonapi">details about the api</param>
        /// <param name="self">the link that generated the current response document</param>
        /// <param name="related">a related resource link when the primary data represents a resource relationship</param>
        /// <param name="first">the first page of data</param>
        /// <param name="last">the last page of data</param>
        /// <param name="prev">the prev page of data</param>
        /// <param name="next">the next page of data</param>
        /// <param name="links">additional custom links</param>
        /// <param name="included">an array of resource objects that are related to the primary data and/or each other</param>
        public JDocument ForResourceCollection(
            IEnumerable<JResource> resources,
            JObject meta = null,
            JApi jsonapi = null,
            string self = null,
            string related = null,
            string first = null,
            string last = null,
            string prev = null,
            string next = null,
            JLink[] additionalLinks = null,
            JResource[] included = null)
        => ForResourceCollection(
            resources: resources,
            meta: meta,
            jsonapi: jsonapi,
            links: JLinks.For(
                self: self,
                related: related,
                first: first,
                last: last,
                prev: prev,
                next: next,
                additionalLinks: additionalLinks),
            included: included
        );

        // <summary>
        /// Creates a JSON API document for a resource collection
        /// </summary>
        /// <param name="resources">the document's "primary data" resource collection</param>
        /// <param name="meta">a meta object that contains non-standard meta-information</param>
        /// <param name="jsonapi">details about the api</param>
        /// <param name="included">an array of resource objects that are related to the primary data and/or each other</param>
        public JDocument ForResourceCollection(
            IEnumerable<JResource> resources,
            JObject meta = null,
            JApi jsonapi = null,
            JLinks links = null,
            JResource[] included = null)
        {
            if (resources == null)
            {
                throw new ArgumentNullException(nameof(resources));
            }

            var document = new JDocument(new JProperty("data", resources.ToArray()));
            if (meta != null)
            {
                document.Add(nameof(meta), meta);
            }
            if (jsonapi != null)
            {
                document.Add(nameof(jsonapi), jsonapi);
            }
            if (links != null && links.HasValues)
            {
                document.Add(nameof(links), links);
            }
            if (included != null)
            {
                document.Add(nameof(included), new JArray(included));
            }
            return document;
        }

        /// <summary>
        /// Creates a JSON API document that represents one or more errors
        /// </summary>
        /// <param name="errors">one or more error objects</param>
        /// <param name="meta"></param>
        /// <param name="jsonapi"></param>
        /// <param name="self"></param>
        /// <param name="related"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="prev"></param>
        /// <param name="next"></param>
        /// <param name="links"></param>
        /// <param name="meta"></param>
        public JDocument For(
            IEnumerable<JError> errors,
            JObject meta = null,
            JApi jsonapi = null,
            string self = null,
            string related = null,
            string first = null,
            string last = null,
            string prev = null,
            string next = null,
            JLink[] additionalLinks = null,
            JResource[] included = null)
        => For(
            errors: errors,
            meta: meta,
            jsonapi: jsonapi,
            links: JLinks.For(
                self: self,
                related: related,
                first: first,
                last: last,
                prev: prev,
                next: next,
                additionalLinks: additionalLinks),
            included: included
        );

        /// <summary>
        /// Creates a JSON API document that represents a single error
        /// </summary>
        /// <param name="error">an error objects</param>
        /// <param name="meta"></param>
        /// <param name="jsonapi"></param>
        /// <param name="self"></param>
        /// <param name="related"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="prev"></param>
        /// <param name="next"></param>
        /// <param name="links"></param>
        /// <param name="meta"></param>
        public JDocument For(
            JError error,
            JObject meta = null,
            JApi jsonapi = null,
            string self = null,
            string related = null,
            string first = null,
            string last = null,
            string prev = null,
            string next = null,
            JLink[] additionalLinks = null,
            JResource[] included = null)
        => For(
            error: error,
            meta: meta,
            jsonapi: jsonapi,
            links: JLinks.For(
                self: self,
                related: related,
                first: first,
                last: last,
                prev: prev,
                next: next,
                additionalLinks: additionalLinks),
            included: included
        );

        /// <summary>
        /// Creates a JSON API document that represents a single error
        /// </summary>
        /// <param name="error">an error object</param>
        /// <param name="meta"></param>
        /// <param name="jsonapi"></param>
        /// <param name="links"></param>
        /// <param name="included"></param>
        public JDocument For(
            JError error,
            JObject meta = null,
            JApi jsonapi = null,
            JLinks links = null,
            IEnumerable<JResource> included = null)
        {
            if (error == null)
            {
                throw new ArgumentNullException(nameof(error));
            }
            return For(
                errors: new[] { error },
                meta: meta,
                jsonapi: jsonapi,
                links: links,
                included: included
                );
        }

        /// <summary>
        /// Creates a JSON API document that represents one or more errors
        /// </summary>
        /// <param name="errors">one or more error objects</param>
        /// <param name="meta"></param>
        /// <param name="jsonapi"></param>
        /// <param name="links"></param>
        /// <param name="included"></param>
        public JDocument For(
            IEnumerable<JError> errors,
            JObject meta = null,
            JApi jsonapi = null,
            JLinks links = null,
            IEnumerable<JResource> included = null)
        {
            var validErrors = errors?.Where(JError.IsValid)?.ToArray();
            if (validErrors == null || !validErrors.Any())
            {
                throw new ArgumentNullException(nameof(errors));
            }

            var document = new JDocument(new JProperty(nameof(errors), validErrors));
            if (meta != null)
            {
                document.Add(nameof(meta), meta);
            }
            if (jsonapi != null)
            {
                document.Add(nameof(jsonapi), jsonapi);
            }
            if (links != null && links.HasValues)
            {
                document.Add(nameof(links), links);
            }
            if (included != null)
            {
                document.Add(nameof(included), new JArray(included));
            }
            return document;
        }
    }
}
