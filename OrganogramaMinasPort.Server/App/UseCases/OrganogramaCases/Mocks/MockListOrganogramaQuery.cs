using OrganogramaMinasPort.Server.App.Interfaces.Queries.OrganogramaQueries;
using OrganogramaMinasPort.Server.Contracts.OrganogramaContracts;
using OrganogramaMinasPort.Server.Domain.Entities;

namespace OrganogramaMinasPort.Server.App.UseCases.OrganogramaCases.Mocks
{
    public class MockListOrganogramaQuery : IListOrganogramaQuery
    {
        public async Task<List<OrganogramaResponse>> Execute()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "João Silva",
                    PositionName = "Diretor Geral",
                    Phone = "99887766",
                    Email = "joao.silva@email.com",
                    Location = "Escritório Administrativo",
                    Department = "",
                    Description = "Responsável pela gestão geral da empresa.",
                    ImageUrl = "https://randomuser.me/api/portraits/men/28.jpg"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Tiago Costa",
                    PositionName = "COO",
                    Phone = "99887767",
                    Email = "tiago.costa@email.com",
                    Location = "Escritório Administrativo",
                    Department = "",
                    Description = "Gerencia as operações diárias da empresa.",
                    ImageUrl = "https://randomuser.me/api/portraits/men/20.jpg"
                },
                new Employee
                {
                    Id = 3,
                    Name = "Kate Oliveira",
                    PositionName = "CTO",
                    Phone = "99887768",
                    Email = "kate.oliveira@email.com",
                    Location = "Escritório Administrativo",
                    Department = "", // Não há valor fornecido
                    Description = "Responsável pela tecnologia e desenvolvimento de produtos.",
                    ImageUrl = "https://randomuser.me/api/portraits/women/3.jpg"
                },
                new Employee
                {
                    Id = 4,
                    Name = "Erica Martins",
                    PositionName = "Gerente de TI",
                    Phone = "99887769",
                    Email = "erica.martins@email.com",
                    Location = "Pátio Fabril de Fundidos",
                    Department = "TI",
                    Description = "Coordena a equipe de TI e supervisiona os projetos de tecnologia.",
                    ImageUrl = "https://randomuser.me/api/portraits/women/8.jpg"
                },
                new Employee
                {
                    Id = 5,
                    Name = "Paul Santos",
                    PositionName = "Gerente de Produtos",
                    Phone = "99887770",
                    Email = "paul.santos@email.com",
                    Location = "Pátio Fabril de Fundidos",
                    Department = "Produtos",
                    Description = "Gerencia projetos importantes e supervisiona as equipes.",
                    ImageUrl = "https://randomuser.me/api/portraits/men/6.jpg"
                },
                new Employee
                {
                    Id = 7,
                    Name = "Sofia Almeida",
                    PositionName = "Analista de RH",
                    Phone = "99887771",
                    Email = "sofia.almeida@email.com",
                    Location = "Escritório Administrativo",
                    Department = "RH",
                    Description = "Analista de Recursos Humanos, responsável pela gestão de benefícios e recrutamento.",
                    ImageUrl = "https://randomuser.me/api/portraits/women/4.jpg"
                },
                new Employee
                {
                    Id = 8,
                    Name = "Carlos Lima",
                    PositionName = "Coordenador de RH",
                    Phone = "99887772",
                    Email = "carlos.lima@email.com",
                    Location = "Escritório Administrativo",
                    Department = "RH",
                    Description = "Coordenador de Recursos Humanos, supervisiona as operações de RH e desenvolvimento de pessoal.",
                    ImageUrl = "https://randomuser.me/api/portraits/men/7.jpg"
                },
                new Employee
                {
                    Id = 10,
                    Name = "Ana Souza",
                    PositionName = "Especialista em Produtos Metalúrgicos",
                    Phone = "99887773",
                    Email = "ana.souza@email.com",
                    Location = "Pátio Fabril de Fundidos",
                    Department = "Produtos",
                    Description = "Focado no desenvolvimento de novos produtos e na otimização dos existentes no setor de metalurgia e siderurgia.",
                    ImageUrl = "https://randomuser.me/api/portraits/women/5.jpg"
                },
                new Employee
                {
                    Id = 11,
                    Name = "Léo Oliveira",
                    PositionName = "Engenheiro de Produtos Siderúrgicos",
                    Phone = "99887774",
                    Email = "leo.oliveira@email.com",
                    Location = "Pátio Fabril de Fundidos",
                    Department = "Produtos",
                    Description = "Responsável pela pesquisa e desenvolvimento de novos produtos siderúrgicos",
                    ImageUrl = "https://randomuser.me/api/portraits/men/8.jpg"
                },
                new Employee
                {
                    Id = 13,
                    Name = "Laura Costa",
                    PositionName = "Coordenador de Marketing",
                    Phone = "99887775",
                    Email = "laura.costa@email.com",
                    Location = "Centro de Distribuição",
                    Department = "Marketing",
                    Description = "Coordena campanhas de marketing e estratégias de comunicação.",
                    ImageUrl = "https://randomuser.me/api/portraits/women/6.jpg"
                },
                new Employee
                {
                    Id = 14,
                    Name = "Bruno Alves",
                    PositionName = "Analista de Marketing",
                    Phone = "99887776",
                    Email = "bruno.alves@email.com",
                    Location = "Centro de Distribuição",
                    Department = "Marketing",
                    Description = "Analista de Marketing, responsável por análise de mercado e relatórios.",
                    ImageUrl = "https://randomuser.me/api/portraits/men/9.jpg"
                },
                new Employee
                {
                    Id = 16,
                    Name = "Mariana Santos",
                    PositionName = "Gerente de Vendas",
                    Phone = "99887777",
                    Email = "mariana.santos@email.com",
                    Location = "Centro de Distribuição",
                    Department = "Vendas",
                    Description = "Gerente de Vendas, supervisiona a equipe de vendas e estratégias comerciais.",
                    ImageUrl = "https://randomuser.me/api/portraits/women/7.jpg"
                },
                new Employee
                {
                    Id = 17,
                    Name = "Lucas Pereira",
                    PositionName = "Representante de Vendas",
                    Phone = "99887778",
                    Email = "lucas.pereira@email.com",
                    Location = "Centro de Distribuição",
                    Department = "Vendas",
                    Description = "Representante de Vendas, responsável por atender clientes e fechar negócios.",
                    ImageUrl = "https://randomuser.me/api/portraits/men/10.jpg"
                },
                new Employee
                {
                    Id = 19,
                    Name = "Júlia Ribeiro",
                    PositionName = "Auxiliar de Infraestrutura I",
                    Phone = "99887779",
                    Email = "julia.ribeiro@email.com",
                    Location = "Pátio Fabril de Fundidos",
                    Department = "TI",
                    Description = "Auxiliar de Infraestrutura, suporte em manutenção de hardware e software.",
                    ImageUrl = "https://randomuser.me/api/portraits/women/18.jpg"
                },
                new Employee
                {
                    Id = 20,
                    Name = "Roberto Silva",
                    PositionName = "Desenvolvedor I",
                    Phone = "99887780",
                    Email = "roberto.silva@email.com",
                    Location = "Pátio Fabril de Fundidos",
                    Department = "TI",
                    Description = "Desenvolvedor de software, com foco em projetos iniciais.",
                    ImageUrl = "https://randomuser.me/api/portraits/men/11.jpg"
                },
                new Employee
                {
                    Id = 21,
                    Name = "Claudia Martins",
                    PositionName = "Auxiliar de Infraestrutura II",
                    Phone = "99887781",
                    Email = "claudia.martins@email.com",
                    Location = "Pátio Fabril de Fundidos",
                    Department = "TI",
                    Description = "Auxiliar de Infraestrutura, com mais experiência em manutenção.",
                    ImageUrl = "https://randomuser.me/api/portraits/women/9.jpg"
                },
                new Employee
                {
                    Id = 22,
                    Name = "Fernando Almeida",
                    PositionName = "Desenvolvedor II",
                    Phone = "99887782",
                    Email = "fernando.almeida@email.com",
                    Location = "Pátio Fabril de Fundidos",
                    Department = "TI",
                    Description = "Desenvolvedor com experiência intermediária em projetos de software.",
                    ImageUrl = "https://randomuser.me/api/portraits/men/12.jpg"
                },
                new Employee
                {
                    Id = 23,
                    Name = "Patrícia Costa",
                    PositionName = "Auxiliar de Infraestrutura III",
                    Phone = "99887783",
                    Email = "patricia.costa@email.com",
                    Location = "Pátio Fabril de Fundidos",
                    Department = "TI",
                    Description = "Auxiliar de Infraestrutura com habilidades avançadas.",
                    ImageUrl = "https://randomuser.me/api/portraits/women/10.jpg"
                },
                new Employee
                {
                    Id = 24,
                    Name = "Gustavo Martins",
                    PositionName = "Desenvolvedor III",
                    Phone = "99887784",
                    Email = "gustavo.martins@email.com",
                    Location = "Pátio Fabril de Fundidos",
                    Department = "TI",
                    Description = "Desenvolvedor avançado com conhecimento em múltiplas tecnologias.",
                    ImageUrl = "https://randomuser.me/api/portraits/men/32.jpg"
                },
                new Employee
                {
                    Id = 25,
                    Name = "Juliana Lima",
                    PositionName = "Auxiliar de Infraestrutura II",
                    Phone = "99887785",
                    Email = "juliana.lima@email.com",
                    Location = "Pátio Fabril de Fundidos",
                    Department = "TI",
                    Description = "Auxiliar de Infraestrutura II, com foco em suporte técnico.",
                    ImageUrl = "https://randomuser.me/api/portraits/women/11.jpg"
                },
                new Employee
                {
                    Id = 26,
                    Name = "Rafael Pereira",
                    PositionName = "Desenvolvedor IV",
                    Phone = "99887786",
                    Email = "rafael.pereira@email.com",
                    Location = "Pátio Fabril de Fundidos",
                    Department = "TI",
                    Description = "Desenvolvedor sênior, responsável por liderança técnica.",
                    ImageUrl = "https://randomuser.me/api/portraits/men/14.jpg"
                },
                new Employee
                {
                    Id = 27,
                    Name = "Fernanda Silva",
                    PositionName = "Desenvolvedor I",
                    Phone = "99887787",
                    Email = "fernanda.silva@email.com",
                    Location = "Pátio Fabril de Fundidos",
                    Department = "TI",
                    Description = "Desenvolvedora júnior, focada em front-end.",
                    ImageUrl = "https://randomuser.me/api/portraits/women/12.jpg"
                },
                new Employee
                {
                    Id = 28,
                    Name = "Diego Santos",
                    PositionName = "Desenvolvedor III",
                    Phone = "99887788",
                    Email = "diego.santos@email.com",
                    Location = "Pátio Fabril de Fundidos",
                    Department = "TI",
                    Description = "Desenvolvedor com experiência em back-end e integrações.",
                    ImageUrl = "https://randomuser.me/api/portraits/men/15.jpg"
                },
                new Employee
                {
                    Id = 29,
                    Name = "Larissa Rodrigues",
                    PositionName = "Auxiliar de Infraestrutura III",
                    Phone = "99887789",
                    Email = "larissa.rodrigues@email.com",
                    Location = "Pátio Fabril de Fundidos",
                    Department = "TI",
                    Description = "Auxiliar de Infraestrutura com expertise em redes.",
                    ImageUrl = "https://randomuser.me/api/portraits/women/13.jpg"
                },
                new Employee
                {
                    Id = 30,
                    Name = "Lucas Ferreira",
                    PositionName = "Desenvolvedor IV",
                    Phone = "99887790",
                    Email = "lucas.ferreira@email.com",
                    Location = "Pátio Fabril de Fundidos",
                    Department = "TI",
                    Description = "Desenvolvedor com profundo conhecimento em tecnologias de software.",
                    ImageUrl = "https://randomuser.me/api/portraits/men/16.jpg"
                },




            };

            List<Hierarchy> hierarchies = new List<Hierarchy>
            {
                new Hierarchy{ Id = 1, EmployeeId = 2, ParentId = "1" },
                new Hierarchy{ Id = 2, EmployeeId = 3, ParentId = "1" },
                new Hierarchy{ Id = 3, TeamId = 31, ParentId = "3" },
                new Hierarchy{ Id = 4, EmployeeId = 4, ParentId = "31" },
                new Hierarchy{ Id = 5, EmployeeId = 5, ParentId = "31" },
                new Hierarchy{ Id = 6, TeamId = 6, ParentId = "1" },
                new Hierarchy { Id = 7, EmployeeId = 7, ParentId = "6" },
                new Hierarchy { Id = 8, EmployeeId = 8, ParentId = "6" },
                new Hierarchy { Id = 9, TeamId = 9, ParentId = "5" },
                new Hierarchy { Id = 10, EmployeeId = 10, ParentId = "9" },
                new Hierarchy { Id = 11, EmployeeId = 11, ParentId = "9" },
                new Hierarchy { Id = 12, TeamId = 12, ParentId = "2" },
                new Hierarchy { Id = 13, EmployeeId = 13, ParentId = "12" },
                new Hierarchy { Id = 14, EmployeeId = 14, ParentId = "12" },
                new Hierarchy { Id = 15, TeamId = 15, ParentId = "1" },
                new Hierarchy { Id = 16, EmployeeId = 16, ParentId = "15" },
                new Hierarchy { Id = 17, EmployeeId = 17, ParentId = "15" },
                new Hierarchy { Id = 18, TeamId = 18, ParentId = "4" },
                new Hierarchy { Id = 19, EmployeeId = 19, ParentId = "18" },
                new Hierarchy { Id = 20, EmployeeId = 20, ParentId = "18" },
                new Hierarchy { Id = 21, EmployeeId = 21, ParentId = "18" },
                new Hierarchy { Id = 22, EmployeeId = 22, ParentId = "18" },
                new Hierarchy { Id = 23, EmployeeId = 23, ParentId = "18" },
                new Hierarchy { Id = 24, EmployeeId = 24, ParentId = "18" },
                new Hierarchy { Id = 25, EmployeeId = 25, ParentId = "18" },
                new Hierarchy { Id = 26, EmployeeId = 26, ParentId = "18" },
                new Hierarchy { Id = 27, EmployeeId = 27, ParentId = "18" },
                new Hierarchy { Id = 28, EmployeeId = 28, ParentId = "18" },
                new Hierarchy { Id = 29, EmployeeId = 29, ParentId = "18" },
                new Hierarchy { Id = 30, EmployeeId = 30, ParentId = "18" },
            };

            List<Team> teams = new List<Team>
            {
                new Team
                {
                    Id = 31,
                    Name = "Tecnologia e Inovação",
                    Description = "Equipe de Tecnologia"
                },
                new Team
                {
                    Id = 6,
                    Name = "RH",
                    Description = "Equipe de Recursos Humanos"
                },
                new Team
                {
                    Id = 9,
                    Name = "Produtos",
                    Description = "Equipe de Desenvolvimento de Produtos"
                },
                new Team
                {
                    Id = 12,
                    Name = "Marketing",
                    Description = "Equipe de Marketing"
                },
                new Team
                {
                    Id = 15,
                    Name = "Vendas",
                    Description = "Equipe de Vendas"
                },
                new Team
                {
                    Id = 18,
                    Name = "TI",
                    Description = "Auxiliar de Infraestrutura I; Auxiliar de Infraestrutura II; Auxiliar de Infraestrutura III; Desenvolvedor I; Desenvolvedor II; Desenvolvedor III; Desenvolvedor IV"
                },

            };

            List<OrganogramaResponse> organogramas = CreateOrganogramaResponse(employees, teams, hierarchies);

            return await Task.FromResult(organogramas);
        }

        private List<OrganogramaResponse> CreateOrganogramaResponse(List<Employee> employees, List<Team> teams, List<Hierarchy> hierarchies)
        {
            var result = new List<OrganogramaResponse>();

            foreach (var employee in employees)
            {
                result.Add(new OrganogramaResponse
                {
                    Id = employee.Id,
                    ParentId = hierarchies.FirstOrDefault(h => h.EmployeeId == employee.Id)?.ParentId ?? "",
                    Name = employee.Name,
                    PositionName = employee.PositionName,
                    Phone = employee.Phone,
                    Email = employee.Email,
                    Team = string.Empty,
                    Location = employee.Location,
                    Department = employee.Department,
                    Description = employee.Description,
                    ImageUrl = employee.ImageUrl
                });
            }

            foreach (var team in teams)
            {
                result.Add(new OrganogramaResponse
                {
                    Id = team.Id,
                    ParentId = hierarchies.FirstOrDefault(h => h.TeamId == team.Id)?.ParentId ?? "",
                    Team = team.Name,
                    Description = team.Description,
                });
            }

            return result;
        }
    }
}
