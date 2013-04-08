using FluentAssertions;
using Xunit;

namespace InspectorSherlock.Tests
{
    public class LanguageSpecs
    {
        [Fact]
        public void SherlockShouldBuildCase()
        {
            var result = Sherlock.BuildCase(1, 2);

            result.Should().BeOfType<CaseFile>();
        }
    }
}
