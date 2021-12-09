using Xbehave;
using Xunit;

namespace SlowXBehaveTests;

public class Scenarios
{
    [Scenario]
    public void Scenario()
    {
        for (var i = 0; i < 1000; i++)
        {
            $"step {i}".x(() => { });
        }
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void Theory(int i)
    {

    }

    public static IEnumerable<object[]> Data()
    {
        var array = new List<object[]>(1000);
        for (int i = 0; i < 1000; i++)
        {
            array.Add(new[] {(object)i});
        }

        return array;
    }
}