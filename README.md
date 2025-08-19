# Client Management

Este projeto é uma aplicação full-stack para cadastro e gerenciamento de clientes, composta por um backend em .NET e um frontend em React.

## Estrutura do Projeto

```
client-management
├── backend
│   ├── ClientManagementApi.sln
│   ├── ClientManagementApi
│   │   ├── Controllers
│   │   │   └── ClientController.cs
│   │   ├── Models
│   │   │   └── Client.cs
│   │   ├── Services
│   │   │   └── ClientService.cs
│   │   ├── Program.cs
│   │   ├── Startup.cs
│   │   └── ClientManagementApi.csproj
│   └── README.md
├── client
│   ├── public
│   │   └── index.html
│   ├── src
│   │   ├── components
│   │   │   └── ClientForm.tsx
│   │   ├── App.tsx
│   │   ├── index.tsx
│   │   └── types
│   │       └── Client.ts
│   ├── package.json
│   ├── tsconfig.json
│   └── README.md
└── README.md
```

## Backend

O backend é desenvolvido em .NET e fornece uma API RESTful para gerenciamento de clientes. Inclui:

- **Controllers**: Manipula as requisições e respostas HTTP.
- **Models**: Define a estrutura dos dados dos clientes.
- **Services**: Contém a lógica de negócio para gerenciamento dos clientes.

### Como executar

1. Navegue até o diretório `backend`.
2. Abra o arquivo de solução `ClientManagementApi.sln` em seu IDE .NET preferido.
3. Restaure as dependências e execute a aplicação.

## Frontend

O frontend é desenvolvido em React e TypeScript, oferecendo uma interface para cadastro e gerenciamento de clientes. Inclui:

- **Components**: Componentes de interface, como o formulário de clientes.
- **Types**: Definições de tipos TypeScript para segurança de tipos.

### Como executar

1. Navegue até o diretório `client`.
2. Instale as dependências com `npm install`.
3. Inicie a aplicação com `npm start`.

## Uso

Com ambos backend e frontend em execução, acesse a aplicação pelo navegador. O frontend se comunica com a API para realizar operações de cadastro, consulta, edição e remoção de clientes.

## Licença

Este projeto está licenciado sob a licença MIT. Consulte o arquivo LICENSE para
