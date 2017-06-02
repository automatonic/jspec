using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System;

namespace JApi
{
    /// <summary>
    /// Error objects provide additional information about problems encountered while performing an operation. Error objects MUST be returned as an array keyed by errors in the top level of a JSON API document.
    /// </summary>
    public class JError : JObject
    {
        internal JError(params object[] content) : base(content)
        {

        }
        /// <summary>
        /// An error object MAY have the following members:
        /// </summary>
        /// <param name="id">a unique identifier for this particular occurrence of the problem</param>
        /// <param name="aboutHref">a link that leads to further details about this particular occurrence of the problem.</param>
        /// <param name="aboutMeta">meta data for the about link</param>
        /// <param name="status"> the HTTP status code applicable to this problem, expressed as a string value.</param>
        /// <param name="code">an application-specific error code, expressed as a string value.</param>
        /// <param name="title">a short, human-readable summary of the problem that SHOULD NOT change from occurrence to occurrence of the problem, except for purposes of localization.</param>
        /// <param name="detail">a human-readable explanation specific to this occurrence of the problem. Like title, this field’s value can be localized.</param>
        /// <param name="sourcePointer">an object containing references to the source of the error, optionally including any of the following members: a JSON Pointer [RFC6901] to the associated entity in the request document [e.g. "/data" for a primary data object, or "/data/attributes/title" for a specific attribute].</param>
        /// <param name="sourceParameter">a string indicating which URI query parameter caused the error.</param>
        /// <param name="meta">a meta object containing non-standard meta-information about the error.</param>
        public static JError For(
            string id = null, 
            string aboutHref = null, 
            JObject aboutMeta = null, 
            string status = null, 
            string code = null, 
            string title = null, 
            string detail = null, 
            string sourcePointer = null, 
            string sourceParameter = null, 
            JObject meta = null)
        {
            var error = new JError();

            if (id != null)
            {
                error.Add(nameof(id), id);
            }
            var links = JLinks.For(
                JLink.For("about", aboutHref, aboutMeta));
            if (links != null)
            {
                error.Add(nameof(links), links);
            }
            if (status != null)
            {
                error.Add(nameof(status), status);
            }
            if (code != null)
            {
                error.Add(nameof(code), code);
            }
            if (title != null)
            {
                error.Add(nameof(title), title);
            }
            if (detail != null)
            {
                error.Add(nameof(detail), detail);
            }
            var source = new JObject();
            if (sourcePointer != null)
            {
                source.Add("pointer", sourcePointer);
            }
            if (sourceParameter != null)
            {
                source.Add("parameter", sourceParameter);
            }
            if (source.HasValues)
            {
                error.Add(nameof(source), source);
            }
            if (meta != null)
            {
                error.Add(nameof(meta), meta);
            }
            return error;
        }

        public static bool IsValid(JError arg)
        {
            return arg != null;
        }
    }
}
