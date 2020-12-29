# Automacao De TestesFuncionaisEmCSharp
 ATDD + Regression + Selenium WebDriver

## Christian Saddock de Sá

Objetivo: 

Expor meus conhecimento em automação de testes de software

Estrutura:

Separei os projetos em pipelines diferentes, visto cada tipo de teste tem objetivos e tempos de execução diferentes. Propriciando assim, incluir os testes de aceitação em todos os pipes de CI/CD, os testes de regressão nos pipes de CI e os testes não funcionais de forma periódica.

- Testes Funcionais
    - ATDD
        - Baseado no requisito disponibilizado, aqui como um caso de teste. Criei dois critérios de aceitação que representam a necessidade do negócio. Estes critérios guiarão todos os testes durante o processo.
            - Carrinho de compras

                Dado que os produtos são disponibilizados para venda

                Quando o cliente escolher um ou mais produtos

                Então estes itens devem ser agrupados e contabilizados em um carrinho de compras

            - Processo de compra

                Dado que há ao menos um item no carrinho

                Quando o cliente fechar o pedido

                Então devem ser coletados os dados do cliente para efetivação da compra

        - Projeto de automação: ATDD.csproj
            - Dependências

                Incluir a extensão "SpecFlow for Visual Studio 2019" no VS;

                Visualisar os testes na janela "Test Explorer" do VS;

    - Validação de regras de negócio

        Visto que objetivo é somente a automação  dos testes, não reportarei inconsistências da aplicação. No entanto, em um cenário real, registraria todos os itens para compor o backlog de manutenção do produto.

        - Projeto de automação: RegressionTestes.csproj
    - Testes da API

        Tive problemas para criar o projeto usando o NetCore no VS. Apesar de utilizar essa stack no meu trabalho, inclusive por dar manutenção nele. No entanto, fiz o projeto na stack java, usando Maven e IntelliJ IDEA.

        - Projeto de automação: RegressionTestesAPI.iml

- Testes não funcionais
    - API: [http://5d9cc58566d00400145c9ed4.mockapi.io/shopping_cart](http://5d9cc58566d00400145c9ed4.mockapi.io/shopping_cart)
    - Para os testes de performance da API utilizei o Jmeter
        - Instalação e abertura:
