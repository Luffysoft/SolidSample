using ArdalisRating.Policies;

namespace ArdalisRating.Factories
{
    public class AutoRatingFactory : IAutoRatingFactory
    {
        public IAutoRating CreateAutoRating(AutoPolicy policy)
        {
            switch (policy.Make)
            {
                case "BMW": return new BMWRating(policy.Deductible);
                case null: case "": return new NoMakeRating();
                default: return new NullRating();
            }
        }
    }
}
