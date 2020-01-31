using Newtonsoft.Json;
using System.IO;
using ArdalisRating.Policies;
using Xunit;

namespace ArdalisRating.Tests
{
    public class RatingEngineRate
    {
[Fact]
public void ReturnsRatingOf10000For200000LandPolicy()
{
    var policy = new LandPolicy
    {
        Type = PolicyType.Land,
        BondAmount = 200000,
        Valuation = 200000
    };
    string json = JsonConvert.SerializeObject(policy);
    File.WriteAllText("policy.json", json);

    var engine = new RatingEngine();
    var result = engine.Rate();

    Assert.Equal(10000, result);
}

        [Fact]
        public void ReturnsRatingOf0For200000BondOn260000LandPolicy()
        {
            var policy = new LandPolicy
            {
                Type = PolicyType.Land,
                BondAmount = 200000,
                Valuation = 260000
            };
            string json = JsonConvert.SerializeObject(policy);
            File.WriteAllText("policy.json", json);

            var engine = new RatingEngine();
            var result = engine.Rate();

            Assert.Equal(0, result);
        }
    }
}
