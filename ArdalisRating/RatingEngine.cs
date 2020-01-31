using ArdalisRating.Factories;
using ArdalisRating.Loggers;
using ArdalisRating.Policies;

namespace ArdalisRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        private readonly IPolicyLoader _policyLoader;
        private readonly IPolicyRatingFactory _policyRatingFactory;
        private readonly ILogger _logger;

        public RatingEngine() :
            this(
                new PolicyLoader(),
                new PolicyRatingFactory(),
                new ConsoleLogger())
        {
        }

        public RatingEngine(
            IPolicyLoader policyLoader,
            IPolicyRatingFactory policyRatingFactory,
            ILogger logger)
        {
            _policyLoader = policyLoader;
            _policyRatingFactory = policyRatingFactory;
            _logger = logger;
        }

        public decimal Rate()
        {
            _logger.Log("Starting rate.");

            _logger.Log("Loading policy.");
            var serializedPolicy = _policyLoader.Load();

            var policyRating = _policyRatingFactory.CreatePolicyRating(serializedPolicy, _logger);
            var rating = policyRating.Rate();

            _logger.Log("Rating completed.");

            return rating;
        }
    }
}
