using System.Threading.Tasks;

public interface ISanityConnector
{
    Task<T[]> Get<T>(string properties) where T : class;
}