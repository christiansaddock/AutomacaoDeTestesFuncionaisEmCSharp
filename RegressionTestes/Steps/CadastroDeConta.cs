using SeleniumDriver.Basics;
using SeleniumDriver.PageObjects;
using TechTalk.SpecFlow;

namespace ATDD.Steps
{
    [Binding]
    public sealed class CadastroDeConta
    {
        [Given(@"que o cliente escolhe um ou mais produtos")]
        public void DadoQueOClienteEscolheUmOuMaisProdutos()
        {
            //DriverVitrine.DadoABuscaDoItem("Blouse");
            //DriverVitrine.QuandoSelecionarOItem("Blouse");
            //DriverStepsAction.QuandoClicarNoBotao("add_to_cart"); 
            //DriverStepsAction.QuandoClicarNoBotao("Continue shopping");

            //DriverVitrine.DadoABuscaDoItem("Faded Short Sleeve T-shirts");
            //DriverVitrine.QuandoSelecionarOItem("Faded Short Sleeve T-shirts");
            //DriverStepsAction.QuandoClicarNoBotao("add_to_cart");
            //DriverStepsAction.QuandoClicarNoBotao("Proceed to checkout");
        }

        [When(@"o cliente fechar o pedido")]
        public void QuandoOClienteFecharOPedido()
        {
            //DriverStepsAction.QuandoClicarNoBotao("Proceed to checkout");
            //DriverStepsValue.DadoOValorParaOcampo("authentication","test2912@a.com");
            //DriverCreatAccount.DadoACriacaoDeConta();
        }

        [Then(@"deve ser efetivada a compra")]
        public void EntaoDeveSerEfetivadaACompra()
        {
            //DriverStepsAction.QuandoClicarNoBotao("add_to_cart");
        }

    }
}
