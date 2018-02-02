using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("/api/author")]
public class AuthorApiController : Controller
{
    private ISanityConnector _sanity;

    public AuthorApiController(ISanityConnector sanity)
    {
        _sanity = sanity;
    }

    [HttpGet]
    public async Task<Author[]> Get()
    {
        return await _sanity.Get<Author>("");
    }
}