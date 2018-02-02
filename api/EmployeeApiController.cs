using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("/api/employee")]
public class EmployeeApiController : Controller
{
    private ISanityConnector _sanityConnector;

    public EmployeeApiController(ISanityConnector sanityConnector)
    {
        _sanityConnector = sanityConnector;
    }

    [HttpGet]
    public async Task<Employee[]> Get()
    {
        return await _sanityConnector.Get<Employee>("{name, position, bio, 'imageUrl':image.asset->url}");
    }
}