using System;
using ArdalisRating.Exceptions;
using ArdalisRating.Loggers;
using ArdalisRating.Policies;

namespace ArdalisRating.Factories
{
    public class LifePolicyRating : IPolicyRating
    {
        private readonly LifePolicy _policy;
        private readonly ILogger _logger;

        public LifePolicyRating(LifePolicy policy, ILogger logger)
        {
            _policy = policy;
            _logger = logger;
        }

        public decimal Rate()
        {
            _logger.Log("Rating LIFE policy...");
            _logger.Log("Validating policy.");

            if (_policy.DateOfBirth == DateTime.MinValue) throw new PolicyException("Life policy must include Date of Birth.");
            if (_policy.DateOfBirth < DateTime.Today.AddYears(-100)) throw new PolicyException("Centenarians are not eligible for coverage.");
            if (_policy.Amount == 0) throw new PolicyException("Life policy must include an Amount.");
            
            var age = DateTime.Today.Year - _policy.DateOfBirth.Year;
            if (_policy.DateOfBirth.Month == DateTime.Today.Month &&
                DateTime.Today.Day < _policy.DateOfBirth.Day ||
                DateTime.Today.Month < _policy.DateOfBirth.Month)
            {
                age--;
            }
            var baseRate = _policy.Amount * age / 200;
            if (_policy.IsSmoker)
            {
                return  baseRate * 2;
            }
            return baseRate;
        }
    }
}