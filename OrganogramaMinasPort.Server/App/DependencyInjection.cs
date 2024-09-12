using OrganogramaMinasPort.Server.App.Interfaces.Queries.OrganogramaQueries;
using OrganogramaMinasPort.Server.App.UseCases.OrganogramaCases.Mocks;
using OrganogramaMinasPort.Server.App.UseCases.OrganogramaCases.Queries;

namespace OrganogramaMinasPort.Server.App
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApp(
            this IServiceCollection services, IWebHostEnvironment environment)
        {
            if (environment.IsDevelopment())
            {
                services.AddScoped<IListOrganogramaQuery, MockListOrganogramaQuery>();
                
                return services;
            }

            services.AddScoped<IListOrganogramaQuery, ListOrganogramaQuery>();

            return services;
        }
    }
}
