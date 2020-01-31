using ArdalisRating.Policies;

namespace ArdalisRating.Factories
{
    public interface IAutoRatingFactory
    {
        IAutoRating CreateAutoRating(AutoPolicy policy);
    }
}