using SeleniumDriver.Basics;
using SeleniumDriver.PageObjects;
using TechTalk.SpecFlow;

namespace ATDD.Steps
{
    [Binding]
    public sealed class Carrinho
    {
        [Given(@"a listagens dos produtos")]
        public void DadoAListagensDosProdutos()
        {
            DriverStepsNavigate.DadoAurl("http://automationpractice.com/index.php");            
        }

        [When(@"o cliente escolhe um produto")]
        public void QuandoOClienteEscolheUmProduto()
        {
            DriverVitrine.DadoABuscaDoItem("Blouse");
            DriverVitrine.QuandoSelecionarOItem("Blouse");
            DriverStepsAction.QuandoClicarNoBotao("add_to_cart");
            DriverStepsAction.QuandoClicarNoBotao("Continue shopping");
        }

        [Then(@"o produto deve ser adicionado ao carrinho")]
        public void EntaoOProdutoDeveSerAdicionadoAoCarrinho()
        {
            DriverVitrine.QuandoClicarNoCarrinho();
            DriverCheckout.EntaoOValorTotalDaCompraDeveSer("$29.00");
        }


    }
}
