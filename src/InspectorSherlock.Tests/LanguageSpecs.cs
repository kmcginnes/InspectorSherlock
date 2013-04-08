using FluentAssertions;
using Xunit;

namespace InspectorSherlock.Tests
{
    public class LanguageSpecs
    {
        [Fact]
        public void SherlockShouldBuildCaseResultingInCaseFile()
        {
            var result = Sherlock.BuildCase(1, 2);

            result.Should().NotBeNull();
            result.Should().BeOfType<CaseFile>();
        }

        [Fact]
        public void CaseFileShouldInferSuspectsResultingInHypothesis()
        {
            var caseFile = new CaseFile();

            var result = caseFile.InferSuspects();

            result.Should().NotBeNull();
            result.Should().BeOfType<Hypothesis>();
        }
    }
}
