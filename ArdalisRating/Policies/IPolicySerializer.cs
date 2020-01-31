namespace ArdalisRating.Policies
{
    public interface IPolicySerializer
    {
        IPolicy Deserialize(string serializedPolicy);
    }
}