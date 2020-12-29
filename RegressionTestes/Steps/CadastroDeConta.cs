using SeleniumDriver.Basics;
using SeleniumDriver.PageObjects;
using SeleniumDriver.Utils;
using TechTalk.SpecFlow;

namespace ATDD.Steps
{
    [Binding]
    public sealed class CadastroDeConta
    {
        [Given(@"a tela de cadastro de conta")]
        public void DadoATelaDeCadastroDeConta()
        {
            DriverStepsNavigate.DadoAurl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            DriverUtils.WaitPageLoaded();
            DriverStepsValue.DadoOValorParaOcampo("email_create", "test2912@a.com");
            DriverStepsAction.QuandoClicarNoBotao("SubmitCreate");
        }

        [When(@"cliente informar seus dados de cadastro")]
        public void QuandoClienteInformarSeusDadosDeCadastro()
        {
            DriverCreatAccount.DadoACriacaoDeConta();
            DriverUtils.WaitPageLoaded();
        }

        [Then(@"o endereço deve ser cadastrado corretamente")]
        public void EntaoOEnderecoDeveSerCadastradoCorretamente()
        {
            DriverStepsNavigate.DadoAurl("http://automationpractice.com/index.php?controller=addresses");
            DriverCreatAccount.EntaoOEnderecoCadastradoDeveSer("address_address1", "Rua marechal, 1");
            DriverCreatAccount.EntaoOEnderecoCadastradoDeveSer("address_address2", "ap 1800");
            DriverCreatAccount.EntaoOEnderecoCadastradoDeveSer("address_company", "nome empresa A");
            DriverCreatAccount.EntaoOEnderecoCadastradoDeveSer("address_phone", "4133334444");
            DriverCreatAccount.EntaoOEnderecoCadastradoDeveSer("address_phone_mobile", "41999944444");
        }

    }
}
