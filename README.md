# 🛒 Jhon Microservices E-commerce

Projeto de e-commerce construído com **ASP.NET Core 6**, utilizando **arquitetura de microsserviços**. Foco em segurança, separação de responsabilidades e comunicação eficiente entre serviços.

## 🔧 Tecnologias Utilizadas

- **ASP.NET Core 6**
- **RabbitMQ**
- **MySQL**
- **Ocelot**
- **OAuth2 / OpenID / IdentityServer**

## 🧱 Microsserviços

- **Frontend (ASP.NET MVC)** – interface de usuário
- **Product.API** – gerenciamento de produtos
- **Identity.API** – autenticação via IdentityServer
- **API Gateway** – roteamento central com Ocelot

## 🔐 Segurança

- Autenticação com **IdentityServer**
- Tokens JWT com **OAuth2** e **OpenID Connect**

## 📦 Requisitos

- .NET 6 SDK
- RabbitMQ em execução
- MySQL com dois bancos criados:
  - `geek_shopping_product_api` – utilizado pelo serviço de produtos
  - `geek_shopping_identity_server` – utilizado pelo serviço de autenticação
- Visual Studio ou CLI do .NET

<!-- ## ▶️ Como Executar

1. **Clone o repositório**
   ```bash
   git clone https://github.com/seu-usuario/jhon-microservices.git
   cd jhon-microservices
   ```

2. **Configure o MySQL**
   - Crie os bancos de dados:
     - `geek_shopping_product_api`
     - `geek_shopping_identity_server`
   - Atualize as `connectionStrings` nos `appsettings.json` dos serviços correspondentes

3. **Execute os serviços**
   ```bash
   dotnet run --project src/Front/LojaMVC
   dotnet run --project src/Services/Identidade/Identidade.API
   dotnet run --project src/Services/Catalogo/Catalogo.API
   dotnet run --project src/ApiGateways/OcelotGateway/Ocelot.API
   ```

4. **RabbitMQ**
   - Deve estar rodando localmente (`localhost:5672`)
   - Opcional: usar via Docker

5. **Acesse a aplicação**
   - Frontend: `https://localhost:5001`
   - Gateway (Ocelot): `https://localhost:8000` -->

## 🔄 Em Desenvolvimento

- Dockerização de todos os microsserviços
- Microsserviços adicionais
