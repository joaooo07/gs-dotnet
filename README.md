#  Global Solution - Sistema de Gerenciamento de Fornecedores e Vendedores

Este projeto é uma solução desenvolvida em .NET com foco na gestão eficiente de fornecedores e vendedores. Ele faz parte de um desafio acadêmico e foi pensado para simular uma aplicação real com boas práticas de arquitetura, organização e versionamento de código.

##  Funcionalidades

- Cadastro de fornecedores e vendedores
- Listagem e edição de dados
- Validações com DataAnnotations
- API RESTful documentada com Swagger
- Uso de padrões como DTOs, Repository e Injeção de Dependência
- Configuração para banco de dados Oracle

##  Tecnologias Utilizadas

- .NET 8.0 (C#)
- ASP.NET Core Web API
- Oracle Database (com string de conexão configurável)
- Swagger (OpenAPI)
- Visual Studio 2022

##  Como Executar Localmente

1. **Clone o repositório:**

   git clone https://github.com/joaooo07/gs-dotnet.git


2. **Abra o projeto no Visual Studio 2022.**

3. **Configure a string de conexão no `appsettings.json` com seu ambiente Oracle.**

4. **Execute o projeto (F5) ou via terminal:**
   dotnet run

5. **Acesse a documentação da API:**
   https://localhost:{porta}/swagger

##  Testes

Você pode testar os endpoints diretamente pelo Swagger ou utilizar ferramentas como Postman e Insomnia.

##  Estrutura do Projeto


global-solution/
├── Controllers/
├── DTOs/
├── Models/
├── Repositories/
├── Services/
├── appsettings.json
└── Program.cs


##  Observações

* O projeto está funcional e pronto para testes com banco de dados.
* O Oracle é essencial para a execução completa do sistema — mantenha-o disponível.

##  Sobre

Este projeto foi desenvolvido como parte da disciplina de desenvolvimento de software. Além de exercitar práticas de arquitetura backend, ele também integra conceitos de versionamento com Git e publicação no GitHub.

---

 **Desenvolvedor:** João Motta
 [GitHub](https://github.com/joaooo07)

```

