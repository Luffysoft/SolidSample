using ArdalisRating.Exceptions;
using ArdalisRating.Loggers;

namespace ArdalisRating.Factories
{
    public class UnknownPolicyRating : IPolicyRating
    {
        private readonly ILogger _logger;

        public UnknownPolicyRating(ILogger logger)
        {
            _logger = logger;
        }

        public decimal Rate()
        {
            throw new PolicyException("Unknown policy type");
        }
    }
}