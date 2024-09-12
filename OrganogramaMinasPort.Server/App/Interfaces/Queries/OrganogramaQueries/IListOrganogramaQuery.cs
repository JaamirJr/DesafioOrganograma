using OrganogramaMinasPort.Server.Contracts.OrganogramaContracts;

namespace OrganogramaMinasPort.Server.App.Interfaces.Queries.OrganogramaQueries
{
    public interface IListOrganogramaQuery
    {
        Task<List<OrganogramaResponse>> Execute(string tipo);
    }
}
