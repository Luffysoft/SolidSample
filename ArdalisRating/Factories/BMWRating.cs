namespace ArdalisRating.Factories
{
    public class BMWRating : IAutoRating
    {
        private readonly decimal _deductible;

        public BMWRating(decimal deductible)
        {
            _deductible = deductible;
        }

        private bool HasDeduction => _deductible < 500;

        public decimal Rate()
        {
            return HasDeduction ? 1000m : 900m; ;
        }
    }
}