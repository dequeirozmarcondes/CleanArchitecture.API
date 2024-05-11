# API Web em .NET Onion Architecture and Clean Code

Este projeto é uma API Web desenvolvida na plataforma .NET para fins de estudo de Arquitetura de Software Limpo utilizando o Onion Architecture e os princípios do Clean Code. Esta é uma abordagem prática objetiva e direta e básica sobre este assunto.

## Benefícios Onion Architecture and Clean Code

- **Manutenibilidade:** A separação clara de responsabilidades em camadas facilita a manutenção do código ao longo do tempo. O Clean Code garante que o código seja legível e compreensível, enquanto a Onion Architecture facilita a identificação e modificação de partes específicas do sistema sem afetar outras áreas.

- **Testabilidade:** A arquitetura em camadas promovida pela Onion Architecture permite a fácil substituição de componentes externos por mocks ou stubs durante os testes. Além disso, o Clean Code facilita a escrita de testes unitários e de integração, tornando o código mais testável.

- **Flexibilidade e Escalabilidade:** A separação clara de preocupações e a modularidade promovidas pela Onion Architecture facilitam a adição de novos recursos e a modificação do sistema sem afetar outras partes do código. O Clean Code torna mais fácil entender e adaptar o código conforme as necessidades mudam ao longo do tempo.

- **Reutilização de Código:** A estrutura modular da Onion Architecture permite que partes do código sejam reutilizadas em diferentes partes do sistema ou em projetos futuros. O Clean Code promove a escrita de funções e classes coesas e reutilizáveis, facilitando a reutilização de código.

- **Redução da Complexidade:** A clareza e simplicidade do código promovidas pelo Clean Code ajudam a reduzir a complexidade do sistema como um todo. A Onion Architecture fornece uma estrutura organizada que ajuda a gerenciar e controlar a complexidade do projeto.

- **Padronização e Consistência:** O Clean Code promove a adoção de padrões de codificação consistentes em todo o projeto, garantindo que o código seja fácil de entender para todos os membros da equipe. A Onion Architecture fornece uma estrutura padronizada para organizar o código, promovendo consistência em toda a aplicação.

![Clean Architecture](https://cdn-media-1.freecodecamp.org/images/oVVbTLR5gXHgP8Ehlz1qzRm5LLjX9kv2Zri6)

## Tecnologias Utilizadas

- Plataforma: .NET
- Framework: ASP.NET Core
- Banco de Dados: SQL Server
- ORM: Entity Framework Core

## Estrutura do Projeto

Estrutura sólida e bem organizada para o desenvolvimento de uma API Web utilizando .NET. Ao seguir os princípios do Clean Code, o código-fonte é mantido limpo, legível e fácil de dar manutenção. Além disso, a adoção da Arquitetura Cebola ajuda a garantir uma separação clara de preocupações e uma estrutura modular que facilita a expansão e a manutenção do sistema.
A estrutura do projeto segue a organização sugerida pela Arquitetura Cebola, com camadas concêntricas que representam diferentes aspectos da aplicação:

- **Domínio (Core):** Contém as entidades, regras de negócio e lógica central da aplicação.
- **Aplicação:** Responsável por orquestrar a interação entre as camadas externas e o domínio.
- **Infraestrutura:** Gerencia as operações de entrada e saída, como acesso a banco de dados, serviços externos, etc.
- **Apresentação:** Camada responsável pela interface com o usuário, neste caso, uma API REST.

## Como Executar o Projeto

1. **Configuração do Banco de Dados:**

   - Certifique-se de ter o SQL Server instalado e configurado na sua máquina.
   - Configure a connection string no arquivo `appsettings.json` para apontar para o seu banco de dados.

2. **Execução do Projeto:**
   - Abra o projeto em sua IDE favorita.
   - Execute o projeto.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir uma issue para discutir novos recursos, melhorias ou problemas encontrados.

## Licença

Não se aplica neste momento, utilize para fins de estudos.
