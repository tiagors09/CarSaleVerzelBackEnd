# Projeto de API Car Sale Verzel

O **Car Sale Verzel** é um sistema de catálogo de vendas de veículos que foi desenvolvido com React no front-end e .NET Core com C# no back-end. Esta documentação descreve a estrutura e os principais componentes da API no lado do servidor.

## Visão Geral

A API do Car Sale Verzel é responsável por fornecer dados sobre veículos, gerenciar o catálogo de veículos, realizar operações de vendas e muito mais. A API segue as melhores práticas de desenvolvimento .NET Core e utiliza o padrão RESTful para comunicação.

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
