using System;
using System.Collections.Generic;
using System.Text;

namespace JHome
{
    /// Relation types from RFC 5988
    /// https://tools.ietf.org/html/rfc5988#section-4.1
    public partial class JLink
    {
        /// <summary> Creates a new JLink instance that designates a substitute for the link's context.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForAlternate(string url) =>
            new JLink(
                relationType: "alternate",
                url: url);

        /// <summary> Creates a new JLink instance that refers to an appendix.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForAppendix(string url) =>
            new JLink(
                relationType: "appendix",
                url: url);

        /// <summary> Creates a new JLink instance that refers to a bookmark or entry point.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForBookmark(string url) =>
            new JLink(
                relationType: "bookmark",
                url: url);

        /// <summary> Creates a new JLink instance that refers to a chapter in a collection of resources.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForChapter(string url) =>
            new JLink(
                relationType: "chapter",
                url: url);

        /// <summary> Creates a new JLink instance that refers to a table of contents.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForContents(string url) =>
            new JLink(
                relationType: "contents",
                url: url);

        /// <summary> Creates a new JLink instance that refers to a copyright statement that applies to the link's context.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForCopyright(string url) =>
            new JLink(
                relationType: "copyright",
                url: url);

        /// <summary> Creates a new JLink instance that refers to a resource containing the most recent item(s) in a collection of resources.</summary>
        /// <remarks> [RFC5005]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForCurrent(string url) =>
            new JLink(
                relationType: "current",
                url: url);

        /// <summary> Creates a new JLink instance that refers to a resource providing information about the link's context.</summary>
        /// <remarks> <http://www.w3.org/TR/powder-dr/#assoc-linking>
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForDescribedby(string url) =>
            new JLink(
                relationType: "describedby",
                url: url);


        /// <summary> Creates a new JLink instance that refers to a resource that can be used to edit the link's context.</summary>
        /// <remarks> [RFC5023]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForEdit(string url) =>
            new JLink(
                relationType: "edit",
                url: url);

        /// <summary> Creates a new JLink instance that refers to a resource that can be used to edit media associated with the link's context.</summary>
        /// <remarks> [RFC5023]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForEditMedia(string url) =>
            new JLink(
                relationType: "edit-media",
                url: url);

        /// <summary> Creates a new JLink instance that identifies a related resource that is potentially large and might require special handling.</summary>
        /// <remarks> [RFC4287]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForEnclosure(string url) =>
            new JLink(
                relationType: "enclosure",
                url: url);

        /// <summary> Creates a new JLink instance that is an IRI that refers to the furthest preceding resource in a series of resources.</summary>
        /// <remarks> [RFC5988]
        ///  Notes: this relation type registration did not indicate a
        ///       reference.  Originally requested by Mark Nottingham in December
        ///       2004.
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForFirst(string url) =>
            new JLink(
                relationType: "first",
                url: url);


        /// <summary> Creates a new JLink instance that refers to a glossary of terms.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForGlossary(string url) =>
             new JLink(
                 relationType: "glossary",
                 url: url);

        /// <summary> Creates a new JLink instance that refers to a resource offering help (more information, links to other sources information, etc.)</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForHelp(string url) =>
            new JLink(
                relationType: "help",
                url: url);

        /// <summary> Creates a new JLink instance that refers to a hub that enables registration for notification of updates to the context.</summary>
        /// <remarks> <http://pubsubhubbub.googlecode.com/> <http://pubsubhubbub.googlecode.com/svn/trunk/pubsubhubbub-core-0.3.html>
        /// Notes: this relation type was requested by Brett Slatkin.
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForHub(string url) =>
            new JLink(
                relationType: "hub",
                url: url);

        /// <summary> Creates a new JLink instance that refers to an index.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForIndex(string url) =>
            new JLink(
                relationType: "index",
                url: url);

        /// <summary> Creates a new JLink instance that is an IRI that refers to the furthest following resource in a series of resources.</summary>
        /// <remarks> [RFC5988]
        /// Notes: this relation type registration did not indicate a
        ///   reference.  Originally requested by Mark Nottingham in December
        ///   2004.
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForLast(string url) =>
            new JLink(
                relationType: "last",
                url: url);

        /// <summary> Creates a new JLink instance that points to a resource containing the latest (e.g., current) version of the context.</summary>
        /// <remarks> [RFC5829]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForLatestVersion(string url) =>
            new JLink(
                relationType: "latest-version",
                url: url);

        /// <summary> Creates a new JLink instance that refers to a license associated with the link's context.</summary>
        /// <remarks> [RFC4946]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForLicense(string url) =>
            new JLink(
                relationType: "license",
                url: url);

        /// <summary> Creates a new JLink instance that refers to the next resource in a ordered series of resources.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForNext(string url) =>
            new JLink(
                relationType: "next",
                url: url);

        /// <summary> Creates a new JLink instance that refers to the immediately following archive resource.</summary>
        /// <remarks> [RFC5005]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForNextArchive(string url) =>
            new JLink(
                relationType: "next-archive",
                url: url);

        /// <summary> Creates a new JLink instance that indicates a resource where payment is accepted.</summary>
        /// <remarks> [RFC5988]
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
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForPayment(string url) =>
            new JLink(
                relationType: "payment",
                url: url);

        /// <summary> Creates a new JLink instance that refers to the previous resource in an ordered series of resources. Synonym for "previous".</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForPrev(string url) =>
            new JLink(
                relationType: "prev",
                url: url);

        /// <summary> Creates a new JLink instance that points to a resource containing the predecessor version in the version history.</summary>
        /// <remarks> [RFC5829]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForPredecessorVersion(string url) =>
            new JLink(
                relationType: "predecessor-version",
                url: url);

        /// <summary> Creates a new JLink instance that refers to the previous resource in an ordered series of resources. Synonym for "prev".</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForPrevious(string url) =>
            new JLink(
                relationType: "previous",
                url: url);

        /// <summary> Creates a new JLink instance that refers to the immediately preceding archive resource.</summary>
        /// <remarks> [RFC5005]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForPrevArchive(string url) =>
            new JLink(
                relationType: "prev-archive",
                url: url);

        /// <summary> Creates a new JLink instance that identifies a related resource.</summary>
        /// <remarks> [RFC4287]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForRelated(string url) =>
            new JLink(
                relationType: "related",
                url: url);

        /// <summary> Creates a new JLink instance that identifies a resource that is a reply to the context of the link.</summary>
        /// <remarks> [RFC4685]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForReplies(string url) =>
            new JLink(
                relationType: "replies",
                url: url);

        /// <summary> Creates a new JLink instance that refers to a section in a collection of resources.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForSection(string url) =>
            new JLink(
                relationType: "section",
                url: url);

        /// <summary> Creates a new JLink instance that conveys an identifier for the link's context.</summary>
        /// <remarks> [RFC4287]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForSelf(string url) =>
            new JLink(
                relationType: "self",
                url: url);

        /// <summary> Creates a new JLink instance that indicates a URI that can be used to retrieve a service document.</summary>
        /// <remarks> [RFC5023]
        /// Notes: When used in an Atom document, this relation type specifies
        /// Atom Publishing Protocol service documents by default.  Requested
        /// by James Snell.
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForService(string url) =>
            new JLink(
                relationType: "service",
                url: url);

        /// <summary> Creates a new JLink instance that refers to the first resource in a collection of resources.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForStart(string url) =>
            new JLink(
                relationType: "start",
                url: url);

        /// <summary> Creates a new JLink instance that refers to an external style sheet.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForStylesheet(string url) =>
            new JLink(
                relationType: "stylesheet",
                url: url);

        /// <summary> Creates a new JLink instance that refers to a resource serving as a subsection in a collection of resources.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForSubsection(string url) =>
            new JLink(
                relationType: "subsection",
                url: url);


        /// <summary> Creates a new JLink instance that points to a resource containing the successor version in the version history.</summary>
        /// <remarks> [RFC5829]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForSuccessorVersion(string url) =>
            new JLink(
                relationType: "successor-version",
                url: url);

        /// <summary> Creates a new JLink instance that refers to a parent document in a hierarchy of documents.</summary>
        /// <remarks> [RFC5988]
        /// Notes: this relation type registration did not indicate a
        /// reference.  Requested by Noah Slater.
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForUp(string url) =>
            new JLink(
                relationType: "up",
                url: url);

        /// <summary> Creates a new JLink instance that points to a resource containing the version history for the context.</summary>
        /// <remarks> [RFC5829]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForVersionHistory(string url) =>
            new JLink(
                relationType: "version-history",
                url: url);

        /// <summary> Creates a new JLink instance that identifies a resource that is the source of the information in the link's context.</summary>
        /// <remarks> [RFC4287]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForVia(string url) =>
            new JLink(
                relationType: "via",
                url: url);

        /// <summary> Creates a new JLink instance that points to a working copy for this resource.</summary>
        /// <remarks> [RFC5829]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForWorkingCopy(string url) =>
            new JLink(
                relationType: "working-copy",
                url: url);

        /// <summary> Creates a new JLink instance that points to the versioned resource from which this working copy was obtained.</summary>
        /// <remarks> [RFC5829]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ForWorkingCopyOf(string url) =>
            new JLink(
                relationType: "working-copy-of",
                url: url);

    }
}
