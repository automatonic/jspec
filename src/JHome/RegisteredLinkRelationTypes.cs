using System;
using System.Collections.Generic;
using System.Text;

namespace JHome
{
    /// <summary>
    /// Relation types from RFC 5988
    /// </summary>
    /// <remarks>
    /// https://tools.ietf.org/html/rfc5988#section-4.1
    /// </remarks>
    public static class RegisteredLinkRelationTypes
    {
        /// <summary> Designates a substitute for the link's context.</summary>
        /// <remarks>[W3C.REC-html401-19991224]</remarks>
        public const string Alternate = "alternate";

        /// <summary> Refers to an appendix.</summary>
        /// <remarks>[W3C.REC-html401-19991224]</remarks>
        public const string Appendix = "appendix";

        /// <summary> Refers to a bookmark or entry point.</summary>
        /// <remarks>[W3C.REC-html401-19991224]</remarks>
        public const string Bookmark = "bookmark";

        /// <summary> Refers to a chapter in a collection of resources.</summary>
        /// <remarks>[W3C.REC-html401-19991224]</remarks>
        public const string Chapter = "chapter";

        /// <summary> Refers to a table of contents.</summary>
        /// <remarks>[W3C.REC-html401-19991224]</remarks>
        public const string Contents = "contents";

        /// <summary> Refers to a copyright statement that applies to the link's context.</summary>
        /// <remarks>[W3C.REC-html401-19991224]</remarks>
        public const string Copyright = "copyright";

        /// <summary> Refers to a resource containing the most recent item(s) in a collection of resources.</summary>
        /// <remarks>[RFC5005]</remarks>
        public const string Current = "current";

        /// <summary> Refers to a resource providing information about the link's context.</summary>
        /// <remarks> <http://www.w3.org/TR/powder-dr/#assoc-linking>
        public const string Describedby = "describedby";

        /// <summary> Refers to a resource that can be used to edit the link's context.</summary>
        /// <remarks>[RFC5023]</remarks>
        public const string Edit = "edit";

        /// <summary> Refers to a resource that can be used to edit media associated with the link's context.</summary>
        /// <remarks>[RFC5023]</remarks>
        public const string EditMedia = "edit-media";

        /// <summary> Identifies a related resource that is potentially large and might require special handling.</summary>
        /// <remarks>[RFC4287]</remarks>
        public const string Enclosure = "enclosure";

        /// <summary> An IRI that refers to the furthest preceding resource  in a series of resources.</summary>
        /// <remarks>[RFC5988]
        ///  Notes: this relation type registration did not indicate a
        ///       reference.  Originally requested by Mark Nottingham in December
        ///       2004.
        /// </remarks>
        public const string First = "first";


        /// <summary> Refers to a glossary of terms.</summary>
        /// <remarks>[W3C.REC-html401-19991224]</remarks>
        public const string Glossary = "glossary";

        /// <summary> Refers to a resource offering help (more information, links to other sources information, etc.)</summary>
        /// <remarks>[W3C.REC-html401-19991224]</remarks>
        public const string Help = "help";

        /// <summary> Refers to a hub that enables registration for notification of updates to the context.</summary>
        /// <remarks> 
        /// http://pubsubhubbub.googlecode.com/
        /// http://pubsubhubbub.googlecode.com/svn/trunk/pubsubhubbub-core-0.3.html
        /// Notes: this relation type was requested by Brett Slatkin.
        /// </remarks>
        public const string Hub = "hub";

        /// <summary> Refers to an index.</summary>
        /// <remarks>[W3C.REC-html401-19991224]</remarks>
        public const string Index = "index";

        /// <summary> An IRI that refers to the furthest following resource in a series of resources.</summary>
        /// <remarks>[RFC5988]
        /// Notes: this relation type registration did not indicate a
        ///   reference.  Originally requested by Mark Nottingham in December
        ///   2004.
        /// </remarks>
        public const string Last = "last";

        /// <summary> Points to a resource containing the latest (e.g., current) version of the context.</summary>
        /// <remarks>[RFC5829]</remarks>
        public const string LatestVersion = "latest-version";

        /// <summary> Refers to a license associated with the link's context.</summary>
        /// <remarks>[RFC4946]</remarks>
        public const string License = "license";

        /// <summary> Refers to the next resource in a ordered series of resources.</summary>
        /// <remarks>[W3C.REC-html401-19991224]</remarks>
        public const string Next = "next";

        /// <summary> Refers to the immediately following archive resource.</summary>
        /// <remarks>[RFC5005]</remarks>
        public const string NextArchive = "next-archive";

        /// <summary> indicates a resource where payment is accepted.</summary>
        /// <remarks>
        /// [RFC5988]
        /// Notes: this relation type registration did not indicate a
        /// reference.  Requested by Joshua Kinberg and Robert Sayre.It is
        /// meant as a general way to facilitate acts of payment, and thus
        /// this specification makes no assumptions on the type of payment or
        /// transaction protocol.  Examples may include a Web page where
        /// donations are accepted or where goods and services are available
        /// for purchase.rel= "payment" is not intended to initiate an
        /// automated transaction.In Atom documents, a link element with a
        /// rel = "payment" attribute may exist at the feed/channel level and/or
        /// the entry/item level.  For example, a rel = "payment" link at the
        /// feed/channel level may point to a "tip jar" URI, whereas an entry/
        /// item containing a book review may include a rel= "payment" link
        /// that points to the location where the book may be purchased
        /// through an online retailer.
        /// </remarks>
        public const string Payment = "payment";

        /// <summary> Refers to the previous resource in an ordered series of resources.Synonym for "previous".</summary>
        /// <remarks>[W3C.REC-html401-19991224]</remarks>
        public const string Prev = "prev";

        /// <summary> Points to a resource containing the predecessor version in the version history.</summary>
        /// <remarks>[RFC5829]</remarks>
        public const string PredecessorVersion = "predecessor-version";

        /// <summary> Refers to the previous resource in an ordered series of resources.Synonym for "prev".</summary>
        /// <remarks>[W3C.REC-html401-19991224]</remarks>
        public const string Previous = "previous";

        /// <summary> Refers to the immediately preceding archive resource.</summary>
        /// <remarks>[RFC5005]</remarks>
        public const string PrevArchive = "prev-archive";

        /// <summary> Identifies a related resource.</summary>
        /// <remarks>[RFC4287]</remarks>
        public const string Related = "related";

        /// <summary> Identifies a resource that is a reply to the context of the link.</summary>
        /// <remarks>[RFC4685]</remarks>
        public const string Replies = "replies";

        /// <summary> Refers to a section in a collection of resources.</summary>
        /// <remarks>[W3C.REC-html401-19991224]</remarks>
        public const string Section = "section";

        /// <summary> Conveys an identifier for the link's context.</summary>
        /// <remarks>[RFC4287]</remarks>
        public const string Self = "self";

        /// <summary> Indicates a URI that can be used to retrieve a service document.</summary>
        /// <remarks>
        /// [RFC5023]
        /// Notes: When used in an Atom document, this relation type specifies
        /// Atom Publishing Protocol service documents by default.  Requested
        /// by James Snell.
        /// </remarks>
        public const string Service = "service";

        /// <summary> Refers to the first resource in a collection of resources.</summary>
        /// <remarks>[W3C.REC-html401-19991224]</remarks>
        public const string Start = "start";

        /// <summary> Refers to an external style sheet.</summary>
        /// <remarks>[W3C.REC-html401-19991224]</remarks>
        public const string Stylesheet = "stylesheet";

        /// <summary> Refers to a resource serving as a subsection in a collection of resources.</summary>
        /// <remarks>[W3C.REC-html401-19991224]</remarks>
        public const string Subsection = "subsection";

        /// <summary> Points to a resource containing the successor version in the version history.</summary>
        /// <remarks>[RFC5829]</remarks>
        public const string SuccessorVersion = "successor-version";

        /// <summary> Refers to a parent document in a hierarchy of documents.</summary>
        /// <remarks>
        /// [RFC5988]
        /// Notes: this relation type registration did not indicate a
        /// reference.  Requested by Noah Slater.
        /// </remarks>
        public const string Up = "up";

        /// <summary> points to a resource containing the version history for the context.</summary>
        /// <remarks>[RFC5829]</remarks>
        public const string VersionHistory = "version-history";

        /// <summary> Identifies a resource that is the source of the information in the link's context.</summary>
        /// <remarks>[RFC4287]</remarks>
        public const string Via = "via";

        /// <summary> Points to a working copy for this resource.</summary>
        /// <remarks>[RFC5829]</remarks>
        public const string WorkingCopy = "working-copy";

        /// <summary> Points to the versioned resource from which this working copy was obtained.</summary>
        /// <remarks>[RFC5829]</remarks>
        public const string WorkingCopyOf = "working-copy-of";

    }
}
