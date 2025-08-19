# Client Management - Frontend

Este é o frontend do projeto **Client Management**, desenvolvido com React e TypeScript. Ele oferece uma interface para cadastro e gerenciamento de clientes, integrando-se à API backend.

## Como começar

Siga os passos abaixo para rodar o frontend localmente:

1. **Clone o repositório**
   ```bash
   git clone <repository-url>
   cd client-management/client
   ```

2. **Instale as dependências**
   Certifique-se de ter o Node.js instalado. Em seguida, execute:
   ```bash
   npm install
   ```

3. **Execute a aplicação**
   Inicie o servidor de desenvolvimento com:
   ```bash
   npm start
   ```
   A aplicação estará disponível em `http://localhost:3000`.

## Estrutura de Pastas

- `public/`: Arquivos estáticos, incluindo `index.html`.
- `src/`: Código-fonte da aplicação React.
  - `components/`: Componentes React, como `ClientForm.tsx`.
  - `types/`: Definições de tipos TypeScript, como `Client.ts`.
  - `App.tsx`: Componente principal da aplicação.
  - `index.tsx`: Ponto de entrada da aplicação.

## Funcionalidades

- Formulário intuitivo para gestão de clientes.
- Validações de campos obrigatórios e formato de e-mail.
- Integração com a API backend para criação e gerenciamento de clientes.

## Licença

Este projeto está licenciado sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.