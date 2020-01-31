using ArdalisRating.Loggers;
using ArdalisRating.Policies;

namespace ArdalisRating.Factories
{
    public interface IPolicyRatingFactory
    {
        IPolicyRating CreatePolicyRating(string serializedPolicy, ILogger logger);
    }
}