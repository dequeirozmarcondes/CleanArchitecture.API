# API Web em .NET com Clean Code e Arquitetura Cebola

Este projeto é uma API Web desenvolvida na plataforma .NET, utilizando o Framework ASP.NET Core. Ele foi concebido com o objetivo de seguir os princípios fundamentais do Clean Code e da Arquitetura Cebola, promovendo uma abordagem prática e eficaz.

## Objetivo

O objetivo deste projeto é fornecer uma estrutura sólida e bem organizada para o desenvolvimento de uma API Web utilizando .NET. Ao seguir os princípios do Clean Code, o código-fonte é mantido limpo, legível e fácil de dar manutenção. Além disso, a adoção da Arquitetura Cebola ajuda a garantir uma separação clara de preocupações e uma estrutura modular que facilita a expansão e a manutenção do sistema.

## Tecnologias Utilizadas

- Plataforma: .NET
- Framework: ASP.NET Core
- Banco de Dados: SQL Server
- ORM: Entity Framework Core

## Estrutura do Projeto

A estrutura do projeto segue a organização sugerida pela Arquitetura Cebola, com camadas concêntricas que representam diferentes aspectos da aplicação:

- **Domínio (Core):** Contém as entidades, regras de negócio e lógica central da aplicação.
- **Aplicação:** Responsável por orquestrar a interação entre as camadas externas e o domínio.
- **Infraestrutura:** Gerencia as operações de entrada e saída, como acesso a banco de dados, serviços externos, etc.
- **Apresentação:** Camada responsável pela interface com o usuário, neste caso, uma API REST.

## Como Rodar o Projeto

1. **Configuração do Banco de Dados:**
   - Certifique-se de ter o SQL Server instalado e configurado na sua máquina.
   - Configure a connection string no arquivo `appsettings.json` para apontar para o seu banco de dados.

2. **Execução do Projeto:**
   - Abra o projeto em sua IDE favorita.
   - Execute o projeto.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir uma issue para discutir novos recursos, melhorias ou problemas encontrados.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
