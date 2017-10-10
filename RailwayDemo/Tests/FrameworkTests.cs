using CSharpFunctionalExtensions;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace RailwayDemo.Tests
{
    // This class verifies that all required 3rd party libs work with dotnetcore
    public class FrameworkTests
    {
        [Fact]
        public void FluentAssertions_work_with_dotnetcore()
            => true.Should().BeTrue();

        [Fact]
        public void NSubstitute_works_with_dotnetcore()
            => Substitute.For<IFoo>().Blub("test").Returns("test");

        [Fact]
        public void CSharpFunctionalExtensions_work_with_dotnetcore()
            => Result.Ok().IsSuccess.Should().BeTrue();
    }

    public interface IFoo
    {
        string Blub(string s);
    }
}