using SeleniumDriver.Utils;
using SeleniumDriver.Basics;
using SeleniumDriver.PageObjects;
using TechTalk.SpecFlow;
using System;

namespace ATDD.Steps
{

    [Binding]
    public sealed class Compras
    {
        [Given(@"que o cliente escolhe um ou mais produtos")]
        public void DadoQueOClienteEscolheUmOuMaisProdutos()
        {
            DriverVitrine.DadoABuscaDoItem("Blouse");
            DriverVitrine.QuandoSelecionarOItem("Blouse");
            DriverStepsAction.QuandoClicarNoBotao("add_to_cart"); 
            DriverStepsAction.QuandoClicarNoBotao("Continue shopping");

            DriverVitrine.DadoABuscaDoItem("Faded Short Sleeve T-shirts");
            DriverVitrine.QuandoSelecionarOItem("Faded Short Sleeve T-shirts");
            DriverStepsAction.QuandoClicarNoBotao("add_to_cart");
            DriverStepsAction.QuandoClicarNoBotao("Proceed to checkout");
        }

        [When(@"o cliente fechar o pedido")]
        public void QuandoOClienteFecharOPedido()
        {
            DriverStepsAction.QuandoClicarNoBotao("Proceed to checkout");
            DriverStepsValue.DadoOValorParaOcampo("email_create", "test2912@a.com");
            DriverStepsAction.QuandoClicarNoBotao("SubmitCreate");
            DriverCreatAccount.DadoACriacaoDeConta();
            DriverStepsAction.QuandoClicarNoBotao("Proceed to checkout");
            DriverCheckout.DadoQueAceitoOsTermosDeServico();
            DriverStepsAction.QuandoClicarNoBotao("Proceed to checkout");
        }

        [Then(@"deve ser efetivada a compra")]
        public void EntaoDeveSerEfetivadaACompra()
        {            
            DriverUtils.WaitPageLoaded();
            DriverCheckout.EntaoOValorTotalDaCompraDeveSer("$45.51");
        }
    }
}
