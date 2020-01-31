using ArdalisRating.Exceptions;

namespace ArdalisRating.Factories
{
    public class NoMakeRating : IAutoRating
    {
        public decimal Rate()
        {
            throw new PolicyException("Auto policy must specify Make");
        }
    }
}