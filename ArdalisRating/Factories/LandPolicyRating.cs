using ArdalisRating.Exceptions;
using ArdalisRating.Loggers;
using ArdalisRating.Policies;

namespace ArdalisRating.Factories
{
    public class LandPolicyRating : IPolicyRating
    {
        private readonly LandPolicy _policy;
        private readonly ILogger _logger;

        public LandPolicyRating(LandPolicy policy, ILogger logger)
        {
            _policy = policy;
            _logger = logger;
        }

        public decimal Rate()
        {
            _logger.Log("Rating LAND policy...");
            _logger.Log("Validating policy.");

            if (_policy.BondAmount == 0 || _policy.Valuation == 0)  throw new PolicyException("Land policy must specify Bond Amount and Valuation.");
            if (_policy.BondAmount < 0.8m * _policy.Valuation) throw new PolicyException("Insufficient bond amount.");
            
            return _policy.BondAmount * 0.05m;
        }
    }
}