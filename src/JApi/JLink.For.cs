using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JApi
{
    /// Relation types from RFC 5988
    /// https://tools.ietf.org/html/rfc5988#section-4.1
    public partial class JLink
    {
        /// <summary> Creates a JLink.For instance that designates a substitute for the link's context.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForAlternate(string href) =>
            JLink.For(
                name: "alternate",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to an appendix.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForAppendix(string href) =>
            JLink.For(
                name: "appendix",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to a bookmark or entry point.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForBookmark(string href) =>
            JLink.For(
                name: "bookmark",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to a chapter in a collection of resources.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForChapter(string href) =>
            JLink.For(
                name: "chapter",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to a table of contents.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForContents(string href) =>
            JLink.For(
                name: "contents",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to a copyright statement that applies to the link's context.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForCopyright(string href) =>
            JLink.For(
                name: "copyright",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to a resource containing the most recent item(s) in a collection of resources.</summary>
        /// <remarks> [RFC5005]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForCurrent(string href) =>
            JLink.For(
                name: "current",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to a resource providing information about the link's context.</summary>
        /// <remarks> <http://www.w3.org/TR/powder-dr/#assoc-linking>
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForDescribedby(string href) =>
            JLink.For(
                name: "describedby",
                href: href);


        /// <summary> Creates a JLink.For instance that refers to a resource that can be used to edit the link's context.</summary>
        /// <remarks> [RFC5023]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForEdit(string href) =>
            JLink.For(
                name: "edit",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to a resource that can be used to edit media associated with the link's context.</summary>
        /// <remarks> [RFC5023]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForEditMedia(string href) =>
            JLink.For(
                name: "edit-media",
                href: href);

        /// <summary> Creates a JLink.For instance that identifies a related resource that is potentially large and might require special handling.</summary>
        /// <remarks> [RFC4287]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForEnclosure(string href) =>
            JLink.For(
                name: "enclosure",
                href: href);

        /// <summary> Creates a JLink.For instance that is an IRI that refers to the furthest preceding resource in a series of resources.</summary>
        /// <remarks> [RFC5988]
        ///  Notes: this relation type registration did not indicate a
        ///       reference.  Originally requested by Mark Nottingham in December
        ///       2004.
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForFirst(string href) =>
            JLink.For(
                name: "first",
                href: href);


        /// <summary> Creates a JLink.For instance that refers to a glossary of terms.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForGlossary(string href) =>
             JLink.For(
                 name: "glossary",
                 href: href);

        /// <summary> Creates a JLink.For instance that refers to a resource offering help (more information, links to other sources information, etc.)</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForHelp(string href) =>
            JLink.For(
                name: "help",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to a hub that enables registration for notification of updates to the context.</summary>
        /// <remarks> <http://pubsubhubbub.googlecode.com/> <http://pubsubhubbub.googlecode.com/svn/trunk/pubsubhubbub-core-0.3.html>
        /// Notes: this relation type was requested by Brett Slatkin.
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForHub(string href) =>
            JLink.For(
                name: "hub",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to an index.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForIndex(string href) =>
            JLink.For(
                name: "index",
                href: href);

        /// <summary> Creates a JLink.For instance that is an IRI that refers to the furthest following resource in a series of resources.</summary>
        /// <remarks> [RFC5988]
        /// Notes: this relation type registration did not indicate a
        ///   reference.  Originally requested by Mark Nottingham in December
        ///   2004.
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForLast(string href) =>
            JLink.For(
                name: "last",
                href: href);

        /// <summary> Creates a JLink.For instance that points to a resource containing the latest (e.g., current) version of the context.</summary>
        /// <remarks> [RFC5829]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForLatestVersion(string href) =>
            JLink.For(
                name: "latest-version",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to a license associated with the link's context.</summary>
        /// <remarks> [RFC4946]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForLicense(string href) =>
            JLink.For(
                name: "license",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to the next resource in a ordered series of resources.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForNext(string href) =>
            JLink.For(
                name: "next",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to the immediately following archive resource.</summary>
        /// <remarks> [RFC5005]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForNextArchive(string href) =>
            JLink.For(
                name: "next-archive",
                href: href);

        /// <summary> Creates a JLink.For instance that indicates a resource where payment is accepted.</summary>
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
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForPayment(string href) =>
            JLink.For(
                name: "payment",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to the previous resource in an ordered series of resources. Synonym for "previous".</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForPrev(string href) =>
            JLink.For(
                name: "prev",
                href: href);

        /// <summary> Creates a JLink.For instance that points to a resource containing the predecessor version in the version history.</summary>
        /// <remarks> [RFC5829]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForPredecessorVersion(string href) =>
            JLink.For(
                name: "predecessor-version",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to the previous resource in an ordered series of resources. Synonym for "prev".</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForPrevious(string href) =>
            JLink.For(
                name: "previous",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to the immediately preceding archive resource.</summary>
        /// <remarks> [RFC5005]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForPrevArchive(string href) =>
            JLink.For(
                name: "prev-archive",
                href: href);

        /// <summary> Creates a JLink.For instance that identifies a related resource.</summary>
        /// <remarks> [RFC4287]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForRelated(string href) =>
            JLink.For(
                name: "related",
                href: href);

        /// <summary> Creates a JLink.For instance that identifies a resource that is a reply to the context of the link.</summary>
        /// <remarks> [RFC4685]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForReplies(string href) =>
            JLink.For(
                name: "replies",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to a section in a collection of resources.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForSection(string href) =>
            JLink.For(
                name: "section",
                href: href);

        /// <summary> Creates a JLink.For instance that conveys an identifier for the link's context.</summary>
        /// <remarks> [RFC4287]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForSelf(string href) =>
            JLink.For(
                name: "self",
                href: href);

        /// <summary> Creates a JLink.For instance that indicates a URI that can be used to retrieve a service document.</summary>
        /// <remarks> [RFC5023]
        /// Notes: When used in an Atom document, this relation type specifies
        /// Atom Publishing Protocol service documents by default.  Requested
        /// by James Snell.
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForService(string href) =>
            JLink.For(
                name: "service",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to the first resource in a collection of resources.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForStart(string href) =>
            JLink.For(
                name: "start",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to an external style sheet.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForStylesheet(string href) =>
            JLink.For(
                name: "stylesheet",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to a resource serving as a subsection in a collection of resources.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForSubsection(string href) =>
            JLink.For(
                name: "subsection",
                href: href);


        /// <summary> Creates a JLink.For instance that points to a resource containing the successor version in the version history.</summary>
        /// <remarks> [RFC5829]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForSuccessorVersion(string href) =>
            JLink.For(
                name: "successor-version",
                href: href);

        /// <summary> Creates a JLink.For instance that refers to a parent document in a hierarchy of documents.</summary>
        /// <remarks> [RFC5988]
        /// Notes: this relation type registration did not indicate a
        /// reference.  Requested by Noah Slater.
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForUp(string href) =>
            JLink.For(
                name: "up",
                href: href);

        /// <summary> Creates a JLink.For instance that points to a resource containing the version history for the context.</summary>
        /// <remarks> [RFC5829]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForVersionHistory(string href) =>
            JLink.For(
                name: "version-history",
                href: href);

        /// <summary> Creates a JLink.For instance that identifies a resource that is the source of the information in the link's context.</summary>
        /// <remarks> [RFC4287]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForVia(string href) =>
            JLink.For(
                name: "via",
                href: href);

        /// <summary> Creates a JLink.For instance that points to a working copy for this resource.</summary>
        /// <remarks> [RFC5829]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForWorkingCopy(string href) =>
            JLink.For(
                name: "working-copy",
                href: href);

        /// <summary> Creates a JLink.For instance that points to the versioned resource from which this working copy was obtained.</summary>
        /// <remarks> [RFC5829]
        /// <param name="href">The href for this relation</param>
        /// <returns>a JLink.ForProperty for this relation type and href</returns>
        public static JLink ForWorkingCopyOf(string href) =>
            JLink.For(
                name: "working-copy-of",
                href: href);
        
        
    }
}
