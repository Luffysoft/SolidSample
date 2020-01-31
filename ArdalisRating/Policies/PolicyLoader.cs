using System.IO;

namespace ArdalisRating.Policies
{
    public class PolicyLoader : IPolicyLoader
    {
        public string Load()
        {
            return File.ReadAllText("policy.json");
        }
    }
}
