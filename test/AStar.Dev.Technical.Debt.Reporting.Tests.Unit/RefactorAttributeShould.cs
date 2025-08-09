using System.Reflection;

namespace AStar.Dev.Technical.Debt.Reporting.Tests.Unit;

public class RefactorAttributeShould
{
    [Fact]
    public void ShouldContainOnlyExpectedPublicPropertiesWithCorrectValues()
    {
        const int    expectedPainEstimate   = 5;
        const int    expectedHoursToResolve = 3;
        const string expectedDescription    = "Refactor this mess";

        var attribute = new RefactorAttribute(expectedPainEstimate, expectedHoursToResolve, expectedDescription);

        var expectedProperties = new[]
                                 {
                                     new { Name = "PainEstimate", Type   = typeof(int), Value    = (object)expectedPainEstimate },
                                     new { Name = "HoursToResolve", Type = typeof(int), Value    = (object)expectedHoursToResolve },
                                     new { Name = "Description", Type    = typeof(string), Value = (object)expectedDescription },
                                     new { Name = "TypeId", Type         = typeof(object), Value = attribute.TypeId }
                                 };

        var actualProperties = typeof(RefactorAttribute)
            .GetProperties(BindingFlags.Instance | BindingFlags.Public);

        actualProperties.Length.ShouldBe(expectedProperties.Length);

        foreach (var expected in expectedProperties)
        {
            var actual = actualProperties.SingleOrDefault(p => p.Name == expected.Name);
            actual.ShouldNotBeNull();
            actual.PropertyType.ShouldBe(expected.Type);

            var actualValue = actual.GetValue(attribute);
            actualValue.ShouldBe(expected.Value);
        }
    }
}
