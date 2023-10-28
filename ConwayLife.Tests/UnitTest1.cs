using FluentAssertions;

namespace ConwayLife.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var a = 7;
        a.Should().Be(7);
    }
}