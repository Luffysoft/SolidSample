namespace ArdalisRating.Factories
{
    public class NullRating : IAutoRating
    {
        public decimal Rate()
        {
            return decimal.MinValue;
        }
    }
}