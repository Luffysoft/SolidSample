using System;

namespace ArdalisRating.Exceptions
{
    public class PolicyException : Exception
    {
        public PolicyException(string message) :
            base(message)
        {
        }
    }
}
