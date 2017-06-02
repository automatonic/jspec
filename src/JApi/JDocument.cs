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
        /// <param name="links">the links relevant to the current resource context</param>
        /// <param name="included">an array of resource objects that are related to the primary data and/or each other</param>
        public static JDocument For(
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

            return For(
                data: resource,
                meta: meta,
                jsonapi: jsonapi,
                links: links,
                included: included
            );
        }


        // <summary>
        /// Creates a JSON API document for a resource collection
        /// </summary>
        /// <param name="resources">the document's "primary data" resource collection</param>
        /// <param name="meta">a meta object that contains non-standard meta-information</param>
        /// <param name="jsonapi">details about the api</param>
        /// <param name="included">an array of resource objects that are related to the primary data and/or each other</param>
        public static JDocument For(
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
            return For(
                data: resources.ToArray(),
                meta: meta,
                jsonapi: jsonapi,
                links: links,
                included: included
            );
        }

        // <summary>
        /// Creates a JSON API document for the specified data
        /// </summary>
        /// <param name="resources">the document's "primary data" resource collection</param>
        /// <param name="meta">a meta object that contains non-standard meta-information</param>
        /// <param name="jsonapi">details about the api</param>
        /// <param name="included">an array of resource objects that are related to the primary data and/or each other</param>
        internal static JDocument For(
            object data,
            JObject meta = null,
            JApi jsonapi = null,
            JLinks links = null,
            JResource[] included = null)
        {
            var document = new JDocument(new JProperty(nameof(data), data));
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
