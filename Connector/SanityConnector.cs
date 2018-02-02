using System.Net;
using System.Threading.Tasks;
using Olav.Sanity.Client;

public class SanityConnector : ISanityConnector
{
    private SanityClient _client;

    public SanityConnector(string projectId, string dataSet, string token)
    {
        _client = new SanityClient(projectId, dataSet, token, false);
    }

    public async Task<T[]> Get<T>(string properties) where T : class
    {
        (HttpStatusCode, FetchResult<T>) result = await _client.Fetch<T>($"*[_type=='{typeof(T).Name.ToLower()}']{properties}");
        return result.Item2?.Result;
    }
}
