# Projeto de API Car Sale Verzel

O **Car Sale Verzel** é um sistema de catálogo de vendas de veículos que foi desenvolvido com React no front-end e .NET Core com C# no back-end. Esta documentação descreve a estrutura e os principais componentes da API no lado do servidor.

## Visão Geral

A API do Car Sale Verzel é responsável por fornecer dados sobre veículos, gerenciar o catálogo de veículos, realizar operações de vendas e muito mais. A API segue as melhores práticas de desenvolvimento .NET Core e utiliza o padrão RESTful para comunicação.

## Devlog Passo a Passo

- [x] **Configuração do Ambiente e Inicialização do Projeto**
  - [x] Configurar o ambiente de desenvolvimento: Node.js, SDK .NET e extensões relevantes no Visual Studio Code.
  - [x] Criar o projeto React com TypeScript usando o comando `npm create vitest@latest`.
  - [x] Inicializar o repositório Git e fazer o primeiro commit.

- [x] **Implementação do Back-end**
  - [x] Criar uma nova solução no Visual Studio para o projeto back-end.
  - [x] Adicionar um projeto ASP.NET Core Web API à solução.
  - [x] Definir o modelo de carro (id, modelo, marca, foto, nome) usando classes em C#.
  - [x] Configurar o banco de dados usando o Entity Framework Core.
  - [x] Implementar endpoints da API para operações CRUD de veículos.

- [ ] **Autenticação JWT**
  - [ ] Adicionar o pacote NuGet necessário para suportar autenticação JWT.
  - [ ] Implementar funcionalidade de registro e autenticação de usuários.
  - [ ] Gerar tokens JWT para autenticação.

## Tecnologias Utilizadas

- **Plataforma de Desenvolvimento**: .NET Core
- **Linguagem de Programação**: C#
- **Banco de Dados**: Em memória
- **Framework Web**: ASP.NET Core
- **Autenticação e Autorização**: JWT

## Endpoints Principais

A seguir estão alguns dos principais endpoints da API:

1. **Listar Veículos**: `GET /api/cars`
   - Descrição: Retorna uma lista de todos os veículos disponíveis no catálogo.

2. **Detalhes do Veículo**: `GET /api/cars/{id}`
   - Descrição: Retorna os detalhes de um veículo específico com base no ID.

3. **Adicionar Veículo**: `POST /api/cars`
   - Descrição: Adiciona um novo veículo ao catálogo.

4. **Atualizar Veículo**: `PUT /api/cars/{id}`
   - Descrição: Atualiza os detalhes de um veículo existente com base no ID.

5. **Remover Veículo**: `DELETE /api/cars/{id}`
   - Descrição: Remove um veículo do catálogo com base no ID.

## Autenticação

## Configuração

## Exemplos de Requisições
