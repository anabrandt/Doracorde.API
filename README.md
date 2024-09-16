
```markdown
# Doracorde API

## Integrantes do Grupo
- **Ana Carolina Tavares** - RM552283
- **Giovanni Paschoalatto** - RM98837
- **Sofia Sprocatti** - RM99208
- **Vinicius Minei** - RM98486
- **Gabriel Lopes Pereira** - RM98023

## Descrição do Projeto

A **Doracorde API** é uma solução desenvolvida para a plataforma "Doracorde: Educação Musical Online", que oferece uma abordagem acessível e personalizada para o aprendizado musical, especialmente focada em pessoas com deficiência visual. Esta API foi construída utilizando **ASP.NET Core Web API** e integra funcionalidades para gerenciar cursos e alunos de forma eficiente.

## Arquitetura

Optamos por uma arquitetura **monolítica** para a API. Essa escolha foi feita considerando a simplicidade e os requisitos do projeto, onde todas as funcionalidades da aplicação estão centralizadas em uma única aplicação. Uma arquitetura monolítica é mais fácil de gerenciar para um projeto dessa escala e permite maior rapidez no desenvolvimento e manutenção, sem a necessidade de lidar com a complexidade de microsserviços.

### Justificativa

A arquitetura monolítica é ideal para aplicações de médio porte, onde a sobrecarga de gerenciamento e manutenção de microsserviços não se justifica. Além disso, para o propósito acadêmico, esta abordagem simplifica a implementação e evita os desafios de comunicação e deploy distribuído que acompanham a arquitetura de microservices.

## Design Patterns Utilizados

- **Singleton**: O padrão Singleton foi implementado para o gerenciamento de configurações, garantindo que apenas uma instância da classe de configuração seja criada durante a execução da aplicação.
- **Repository Pattern**: Foi utilizado para abstrair o acesso ao banco de dados, promovendo um design mais modular e permitindo que o código de persistência fique separado da lógica de negócio.
  
## Tecnologias Utilizadas

- **ASP.NET Core Web API** - Framework principal para a criação da API.
- **Oracle** - Banco de dados relacional utilizado para persistência de dados.
- **Swagger/OpenAPI** - Para documentação automática dos endpoints da API.
- **MongoDB** - Integração com um banco de dados NoSQL para operações de CRUD.

## Endpoints CRUD

A API oferece endpoints CRUD para gerenciar **Cursos**, incluindo operações como:
- `GET /api/curso` - Retorna todos os cursos.
- `GET /api/curso/{id}` - Retorna um curso específico por ID.
- `POST /api/curso` - Cria um novo curso.
- `PUT /api/curso/{id}` - Atualiza um curso existente.
- `DELETE /api/curso/{id}` - Exclui um curso por ID.

## Como Executar a API

### Pré-requisitos

- [.NET Core SDK](https://dotnet.microsoft.com/download) versão 5.0 ou superior.
- [Oracle Database](https://www.oracle.com/database/) configurado e rodando.
- MongoDB configurado, se for utilizar o banco NoSQL para testes.

### Passos para rodar a aplicação

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/seu-usuario/doracorde-api.git
   cd doracorde-api
   ```

2. **Configure a string de conexão no arquivo `appsettings.json`:**
   Substitua as informações de conexão com o banco de dados Oracle e MongoDB no arquivo `appsettings.json`.

3. **Restaure as dependências do projeto:**
   ```bash
   dotnet restore
   ```

4. **Compile o projeto:**
   ```bash
   dotnet build
   ```

5. **Execute a aplicação:**
   ```bash
   dotnet run
   ```

6. **Acesse a documentação Swagger:**
   - Após iniciar a API, abra o navegador e acesse: `http://localhost:5000/swagger` para visualizar e testar os endpoints disponíveis.

### Rodar Testes

O projeto inclui um conjunto de testes de unidade que podem ser executados com o comando:

```bash
dotnet test
```
