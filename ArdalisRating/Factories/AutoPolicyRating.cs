using ArdalisRating.Loggers;
using ArdalisRating.Policies;

namespace ArdalisRating.Factories
{
    public class AutoPolicyRating : IPolicyRating
    {
        private readonly AutoPolicy _policy;
        private readonly IAutoRatingFactory _autoRatingFactory;
        private readonly ILogger _logger;

        public AutoPolicyRating(AutoPolicy policy) :
            this(policy, new AutoRatingFactory(), new ConsoleLogger())
        {
        }

        public AutoPolicyRating(AutoPolicy policy, ILogger logger) :
            this(policy, new AutoRatingFactory(), logger)
        {
        }

        public AutoPolicyRating(AutoPolicy policy, IAutoRatingFactory autoRatingFactory, ILogger logger)
        {
            _policy = policy;
            _autoRatingFactory = autoRatingFactory;
            _logger = logger;
        }

        public decimal Rate()
        {
            _logger.Log("Rating AUTO policy...");
            _logger.Log("Validating policy.");

            var autoRating = _autoRatingFactory.CreateAutoRating(_policy);
            return autoRating.Rate();
        }
    }
}