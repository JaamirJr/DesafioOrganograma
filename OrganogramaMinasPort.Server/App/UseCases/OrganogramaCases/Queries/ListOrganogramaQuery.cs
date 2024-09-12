using OrganogramaMinasPort.Server.App.Interfaces.Queries.OrganogramaQueries;
using OrganogramaMinasPort.Server.Contracts.OrganogramaContracts;

namespace OrganogramaMinasPort.Server.App.UseCases.OrganogramaCases.Queries
{
    public class ListOrganogramaQuery : IListOrganogramaQuery
    {
        //private readonly IListOrganogramaRepository _repository;
        //private readonly IMapper _mapper;

        //public MockListOrganogramaQuery(IListOrganogramaRepository repository, IMapper mapper)
        //{
        //    _repository = repository;
        //    _mapper = mapper;
        //}

        public Task<List<OrganogramaResponse>> Execute(string tipo)
        {
            // Aqui faria a implementação do List do Organograma, buscando os dados da camada de Infraestrura;

            throw new NotImplementedException();
        }
    }
}
