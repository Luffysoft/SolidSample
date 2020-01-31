using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ArdalisRating.Policies
{
    public class PolicySerializer : IPolicySerializer
    {
        public IPolicy Deserialize(string serializedPolicy)
        {
            if (serializedPolicy.Contains("Life"))
                return JsonConvert.DeserializeObject<LifePolicy>(serializedPolicy, new StringEnumConverter());

            if (serializedPolicy.Contains("Land"))
                return JsonConvert.DeserializeObject<LandPolicy>(serializedPolicy, new StringEnumConverter());

            return JsonConvert.DeserializeObject<AutoPolicy>(serializedPolicy, new StringEnumConverter());
        }
    }
}
