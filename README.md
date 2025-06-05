#  Global Solution - Estações Meteorológicas com ASP.NET Core

Este projeto faz parte da entrega de uma solução .NET para monitoramento de condições climáticas em fazendas, com foco em **temperatura extrema**, **umidade relativa** e **alertas** visuais. Foi desenvolvido utilizando **ASP.NET Core 8**, **Razor Pages** e conexão com **banco de dados Oracle**.

---

##  Funcionalidades

*  **Cadastro de Estações Meteorológicas**
*  **Registro de Leituras de Temperatura e Umidade**
*  **Exibição de Alertas de Condições Extremas**
*  **Listagem visual com destaque em vermelho para alertas**
*  **Conectado a banco de dados Oracle**
*  **APIs REST para integração**

---

##  Tecnologias Utilizadas

* **.NET 8.0 (ASP.NET Core MVC + Razor Pages)**
* **Oracle DB + EF Core**
* **Swagger (documentação e testes das APIs)**
* **Visual Studio 2022**
* **C#**
* **HTML/CSS para Razor Pages**

---

## Demonstração Visual

A página de Alertas exibe uma tabela com os dados meteorológicos e **destaque em vermelho** para condições como "CalorExtremo":


Estação: Fazenda01
Temperatura: 39°C
Umidade: 74%
Condição: CalorExtremo 


---

##  Como Executar o Projeto

### Pré-requisitos

* .NET 8 SDK
* Oracle Database configurado com as tabelas corretas
* Visual Studio 2022

### 1. Clone o repositório


git clone https://github.com/joaooo07/gs-dotnet.git
cd gs-dotnet/global-solution


### 2. Configure o banco de dados

No arquivo `appsettings.Development.json`, configure a string de conexão com seu banco Oracle:


"ConnectionStrings": {
  "OracleConnection": "User Id=USUARIO;Password=SENHA;Data Source=//localhost:1521/XEPDB1"
}


### 3. Execute o projeto

Abra o Visual Studio e pressione `F5` ou rode via terminal:


dotnet run



## Endpoints Principais (via Swagger)

Após executar, acesse: [http://localhost:5164/swagger/index.html](http://localhost:5164/swagger/index.html)

* `GET /api/alertas`
* `POST /api/leituras`
* `POST /api/estacoes`



##  Estrutura do Projeto


global-solution/
│
├── Controllers/
│   ├── AlertasController.cs
│   ├── EstacaoMeteorologicaController.cs
│   └── LeituraTemperaturaController.cs
│
├── Application/
│   ├── Dtos/
│   ├── Interfaces/
│   └── Services/
│
├── Domain/Entities/
├── Data/AppDbContext.cs
├── Migrations/
├── Pages/ (Razor Pages)
├── Program.cs
└── appsettings.json




## Testes Locais

Você pode testar os endpoints usando o Swagger ou ferramentas como **Postman**. Dados de exemplo:


{
  "estacaoNome": "Fazenda01",
  "dataHora": "2025-06-05T11:38:47",
  "temperatura": 39,
  "umidadeRelativa": 74
}




##  Licença

Este projeto foi desenvolvido com fins educacionais e para submissão no contexto do **Global Solution FIAP**.

