using FluentAssertions;
using System;
using Xunit;

namespace JApi
{
    /// <summary>
    /// http://jsonapi.org/format/#document-top-level
    /// MAY and MUST rules for all JDocumentObjects instances
    /// </summary>
    public class JDocumentObjectMay
    {
        [Fact]
        public void RepresentAnArrayOfResourceIdentifierObjects()
        {
            var instance = JDocument.ForResourceCollection(new[] {
                new JResource("dwarf", "gimly"),
                new JResource("dwarf", "thorin")
            });
            var result = instance.ToString(Newtonsoft.Json.Formatting.None);
            result.Should().Be("{\"data\":[{\"type\":\"dwarf\",\"id\":\"gimly\"},{\"type\":\"dwarf\",\"id\":\"thorin\"}]}");
        }

        [Fact]
        public void RepresentAnArrayOfResourceObjects()
        {
            var instance = JDocument.ForResourceCollection(new[] {
                new JResource("dwarf", "gimly"),
                new JResource("dwarf", "thorin")
            });
            var result = instance.ToString(Newtonsoft.Json.Formatting.None);
            result.Should().Be("{\"data\":[{\"type\":\"dwarf\",\"id\":\"gimly\"},{\"type\":\"dwarf\",\"id\":\"thorin\"}]}");
        }

        [Fact]
        public void RepresentAnEmptyArrayOfResourceObjects()
        {
            var instance = JDocument.ForResourceCollection(new JResource[] { });
            var result = instance.ToString(Newtonsoft.Json.Formatting.None);
            result.Should().Be("{\"data\":[]}");
        }

        [Fact]
        public void RepresentASingleNullResourceObject()
        {
            var instance = JDocument.ForResource(data: default(JResource));
            var result = instance.ToString(Newtonsoft.Json.Formatting.None);
            result.Should().Be("{\"data\":null}");
        }

        [Fact]
        public void RepresentASingleResourceIdentifierObject()
        {
            var instance = JDocument.ForResource(new JResource("dwarf", "gimly"));
            var result = instance.ToString(Newtonsoft.Json.Formatting.None);
            result.Should().Be("{\"data\":{\"type\":\"dwarf\",\"id\":\"gimly\"}}");
        }

        [Fact]
        public void RepresentASingleResourceObject()
        {
            var instance = JDocument.ForResource(new JResource("dwarf", "gimly"));
            var result = instance.ToString(Newtonsoft.Json.Formatting.None);
            result.Should().Be("{\"data\":{\"type\":\"dwarf\",\"id\":\"gimly\"}}");
        }
    }
}