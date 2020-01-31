using ArdalisRating.Loggers;
using ArdalisRating.Policies;

namespace ArdalisRating.Factories
{
    public class PolicyRatingFactory : IPolicyRatingFactory
    {
        public IPolicyRating CreatePolicyRating(string serializedPolicy, ILogger logger)
        {
            var policySerializer = new PolicySerializer();
            var policy = policySerializer.Deserialize(serializedPolicy);

            switch (policy.Type)
            {
                case PolicyType.Auto: return new AutoPolicyRating(policy as AutoPolicy, logger);
                case PolicyType.Land: return new LandPolicyRating(policy as LandPolicy, logger);
                case PolicyType.Life: return new LifePolicyRating(policy as LifePolicy, logger);
                default: return new UnknownPolicyRating(logger);
            }
        }
    }
}
