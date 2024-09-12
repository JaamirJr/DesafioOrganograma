# Desafio Organograma

Este projeto foi desenvolvido como parte de um desafio de entrevista e é composto por um front-end em React e um back-end estruturado com várias camadas. O objetivo principal foi criar uma aplicação SPA (Single Page Application) para exibir um organograma.

## Front-End

O front-end foi desenvolvido utilizando **React** e é uma SPA que utiliza o **d3-org-chart** para renderizar o organograma de forma dinâmica e interativa. A paleta de cores do front-end foi baseada na logo da empresa para garantir consistência visual com a identidade da marca.

### Tecnologias Utilizadas

- **React**: Biblioteca JavaScript para construção da interface de usuário.
- **d3-org-chart**: Biblioteca para visualização de organogramas.

## Back-End

O back-end foi desenvolvido utilizando **ASP.NET Core** com a versão **.NET 8**. A aplicação segue uma arquitetura em camadas para garantir uma organização clara e modular:

- **Apresentation**: Camada responsável pelos controllers, que lidam com a lógica de entrada e saída de dados.
- **Domain**: Contém as entidades de domínio que representam as principais regras e lógica de negócio.
- **Contracts**: Encapsulamento das entidades do banco de dados para comunicação entre o domínio e a camada de persistência.
- **Application**: Contém os UseCases, separados em **Query** e **Command**, que gerenciam a lógica de aplicação e interação com o domínio.

**Observação:** A camada de **Infraestrutura** e outras camadas adicionais não foram implementadas neste projeto devido às especificações do desafio proposto.

### Princípios e Padrões

- **SOLID**: O projeto segue os princípios SOLID para garantir um código mais limpo e de fácil manutenção. A separação de responsabilidades é claramente definida nas camadas, e as interfaces ajudam a manter o sistema flexível e extensível.
- **Clean Code**: O código foi escrito com foco em clareza e simplicidade. Nomes de variáveis e funções são descritivos e a estrutura do código segue boas práticas para facilitar a leitura e entendimento.
- **Clean Architecture**: O projeto segue os princípios da Clean Architecture, garantindo que as regras de negócio (domínio) estejam desacopladas das camadas externas (como apresentação e persistência). A separação em camadas permite uma melhor organização e facilita a manutenção e escalabilidade do sistema.

## Mock de Dados

Para fins de desenvolvimento e testes, foi utilizado um mock de dados, uma vez que o desafio proposto pela empresa envolvia o desenvolvimento do front-end de um organograma. O mock de dados simula a estrutura do organograma e permite a visualização e interação sem a necessidade de um banco de dados real.

## Instalação e Execução

Instruções sobre como instalar e executar o projeto.

1. Clone o repositório: `git clone https://github.com/JaamirJr/DesafioOrganograma.git`
2. Navegue até o diretório do projeto.
3. Instale as dependências para o front-end e back-end.
4. Execute o projeto localmente.

