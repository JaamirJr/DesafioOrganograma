using Microsoft.AspNetCore.Mvc;
using OrganogramaMinasPort.Server.App.Interfaces.Queries.OrganogramaQueries;

namespace OrganogramaMinasPort.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrganogramaController : ControllerBase
    {
        private readonly IListOrganogramaQuery _listOrganogramaQuery;

        public OrganogramaController(IListOrganogramaQuery listOrganogramaQuery)
        {
            _listOrganogramaQuery = listOrganogramaQuery;
        }

        [HttpGet("{tipo}")]
        public async Task<IActionResult> Get(string tipo)
        {
            return Ok(await _listOrganogramaQuery.Execute(tipo));
        }
    }
}
