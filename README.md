# Desafio Técnico – Bernhoeft GRT

## Objetivo
Modificar a API existente para suportar funcionalidades de CRUD relacionadas a avisos, conforme especificações da vaga de Desenvolvedor(a) C#.

## Funcionalidades Implementadas
- GET /avisos/{id}
- POST /avisos
- PUT /avisos/{id}
- DELETE /avisos/{id} (soft delete)

## Regras de Negócio
- Validação com FluentValidation
- Controle de data de criação e edição
- Filtro para exibir apenas avisos ativos

## Decisões de Implementação
- Utilizei arquitetura proposta que era o DDD para manter consistência com o projeto original.
- Adotei soft delete via projeto com DDD.
- Validações foram aplicadas diretamente na camada de entrada para garantir integridade.

## Como rodar o projeto
1. Clone o repositório
2. Execute `dotnet restore`
3. Execute `dotnet run`

## Observações
Fico à disposição para esclarecer qualquer ponto técnico na próxima etapa.
