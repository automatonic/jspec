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
    public partial class JLink
    {
        /// <summary> Designates a substitute for the link's context.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToAlternate(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Alternate,
                url: url);


        /// <summary> Refers to an appendix.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToAppendix(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Appendix,
                url: url);

        /// <summary> Refers to a bookmark or entry point.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToBookmark(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Bookmark,
                url: url);

        /// <summary> Refers to a chapter in a collection of resources.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToChapter(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Chapter,
                url: url);

        /// <summary> Refers to a table of contents.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToContents(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Contents,
                url: url);

        /// <summary> Refers to a copyright statement that applies to the link's context.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToCopyright(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Copyright,
                url: url);

        /// <summary> Refers to a resource containing the most recent item(s) in a collection of resources.</summary>
        /// <remarks> [RFC5005]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToCurrent(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Current,
                url: url);

        /// <summary> Refers to a resource providing information about the link's context.</summary>
        /// <remarks> <http://www.w3.org/TR/powder-dr/#assoc-linking>
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToDescribedby(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Describedby,
                url: url);


        /// <summary> Refers to a resource that can be used to edit the link's context.</summary>
        /// <remarks> [RFC5023]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToEdit(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Edit,
                url: url);

        /// <summary> Refers to a resource that can be used to edit media associated with the link's context.</summary>
        /// <remarks> [RFC5023]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToEditMedia(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.EditMedia,
                url: url);

        /// <summary> Identifies a related resource that is potentially large and might require special handling.</summary>
        /// <remarks> [RFC4287]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToEnclosure(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Enclosure,
                url: url);

        /// <summary> An IRI that refers to the furthest preceding resource  in a series of resources.</summary>
        /// <remarks> [RFC5988]
        ///  Notes: this relation type registration did not indicate a
        ///       reference.  Originally requested by Mark Nottingham in December
        ///       2004.
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToFirst(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.First,
                url: url);


        /// <summary> Refers to a glossary of terms.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToGlossary(string url) =>
             new JLink(
                 relationType: RegisteredLinkRelationTypes.Glossary,
                 url: url);

        /// <summary> Refers to a resource offering help (more information, links to other sources information, etc.)</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToHelp(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Help,
                url: url);

        /// <summary> Refers to a hub that enables registration for notification of updates to the context.</summary>
        /// <remarks> <http://pubsubhubbub.googlecode.com/> <http://pubsubhubbub.googlecode.com/svn/trunk/pubsubhubbub-core-0.3.html>
        /// Notes: this relation type was requested by Brett Slatkin.
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToHub(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Hub,
                url: url);

        /// <summary> Refers to an index.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToIndex(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Index,
                url: url);

        /// <summary> An IRI that refers to the furthest following resource in a series of resources.</summary>
        /// <remarks> [RFC5988]
        /// Notes: this relation type registration did not indicate a
        ///   reference.  Originally requested by Mark Nottingham in December
        ///   2004.
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToLast(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Last,
                url: url);

        /// <summary> Points to a resource containing the latest (e.g., current) version of the context.</summary>
        /// <remarks> [RFC5829]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToLatestVersion(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.LatestVersion,
                url: url);

        /// <summary> Refers to a license associated with the link's context.</summary>
        /// <remarks> [RFC4946]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToLicense(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.License,
                url: url);

        /// <summary> Refers to the next resource in a ordered series of resources.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToNext(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Next,
                url: url);

        /// <summary> Refers to the immediately following archive resource.</summary>
        /// <remarks> [RFC5005]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToNextArchive(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.NextArchive,
                url: url);

        /// <summary> indicates a resource where payment is accepted.</summary>
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
        public static JLink ToPayment(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Payment,
                url: url);

        /// <summary> Refers to the previous resource in an ordered series of resources.Synonym for "previous".</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToPrev(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Prev,
                url: url);

        /// <summary> Points to a resource containing the predecessor version in the version history.</summary>
        /// <remarks> [RFC5829]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToPredecessorVersion(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.PredecessorVersion,
                url: url);

        /// <summary> Refers to the previous resource in an ordered series of resources.Synonym for "prev".</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToPrevious(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Previous,
                url: url);

        /// <summary> Refers to the immediately preceding archive resource.</summary>
        /// <remarks> [RFC5005]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToPrevArchive(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.PrevArchive,
                url: url);

        /// <summary> Identifies a related resource.</summary>
        /// <remarks> [RFC4287]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToRelated(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Related,
                url: url);

        /// <summary> Identifies a resource that is a reply to the context of the link.</summary>
        /// <remarks> [RFC4685]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToReplies(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Replies,
                url: url);

        /// <summary> Refers to a section in a collection of resources.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToSection(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Section,
                url: url);

        /// <summary> Conveys an identifier for the link's context.</summary>
        /// <remarks> [RFC4287]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToSelf(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Self,
                url: url);

        /// <summary> Indicates a URI that can be used to retrieve a service document.</summary>
        /// <remarks> [RFC5023]
        /// Notes: When used in an Atom document, this relation type specifies
        /// Atom Publishing Protocol service documents by default.  Requested
        /// by James Snell.
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToService(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Service,
                url: url);

        /// <summary> Refers to the first resource in a collection of resources.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToStart(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Start,
                url: url);

        /// <summary> Refers to an external style sheet.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToStylesheet(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Stylesheet,
                url: url);

        /// <summary> Refers to a resource serving as a subsection in a collection of resources.</summary>
        /// <remarks> [W3C.REC-html401-19991224]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToSubsection(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Subsection,
                url: url);


        /// <summary> Points to a resource containing the successor version in the version history.</summary>
        /// <remarks> [RFC5829]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToSuccessorVersion(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.SuccessorVersion,
                url: url);

        /// <summary> Refers to a parent document in a hierarchy of documents.</summary>
        /// <remarks> [RFC5988]
        /// Notes: this relation type registration did not indicate a
        /// reference.  Requested by Noah Slater.
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToUp(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Up,
                url: url);

        /// <summary> points to a resource containing the version history for the context.</summary>
        /// <remarks> [RFC5829]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToVersionHistory(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.VersionHistory,
                url: url);

        /// <summary> Identifies a resource that is the source of the information in the link's context.</summary>
        /// <remarks> [RFC4287]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToVia(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.Via,
                url: url);

        /// <summary> Points to a working copy for this resource.</summary>
        /// <remarks> [RFC5829]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToWorkingCopy(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.WorkingCopy,
                url: url);

        /// <summary> Points to the versioned resource from which this working copy was obtained.</summary>
        /// <remarks> [RFC5829]
        /// <param name="url">The URL for this relation</param>
        /// <returns>a new JLinkProperty for this relation type and URL</returns>
        public static JLink ToWorkingCopyOf(string url) =>
            new JLink(
                relationType: RegisteredLinkRelationTypes.WorkingCopyOf,
                url: url);

    }
}
