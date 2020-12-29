using SeleniumDriver.Basics;
using SeleniumDriver.Utils;

namespace SeleniumDriver.PageObjects
{
    public static class DriverCreatAccount
    {
        public static void DadoACriacaoDeConta()
        {
            DriverUtils.WaitPageLoaded();
            //Dados pessoais
            DriverStepsValue.DadoOValorParaOcampo("customer_firstname", "nome pessoa A");
            DriverStepsValue.DadoOValorParaOcampo("customer_lastname", "sobrenome pessoa A");
            DriverStepsValue.DadoOValorParaOcampo("email", DriverUtils.EmailRandon());
            DriverStepsValue.DadoOValorParaOcampo("passwd", "123456789");
            //DriverStepsValue.DadoASelecaoDoValorParaOcampo("uniform-days", "1");
            //DriverStepsValue.DadoASelecaoDoValorParaOcampo("uniform-months", "january");
            //DriverStepsValue.DadoASelecaoDoValorParaOcampo("uniform-years", "1984");

            //Contato
            DriverStepsValue.DadoOValorParaOcampo("company", "nome empresa A");
            DriverStepsValue.DadoOValorParaOcampo("address1", "Rua marechal, 1");
            DriverStepsValue.DadoOValorParaOcampo("address2", "ap 1800");
            DriverStepsValue.DadoOValorParaOcampo("city", "Curitiba");
            DriverStepsValue.DadoASelecaoDoValorParaOcampo("id_state", "California");
            DriverStepsValue.DadoASelecaoDoValorParaOcampo("postcode", "12345");
            //DriverStepsValue.DadoASelecaoDoValorParaOcampo("blablbablabla", "other");
            DriverStepsValue.DadoASelecaoDoValorParaOcampo("phone", "4133334444");
            DriverStepsValue.DadoASelecaoDoValorParaOcampo("phone_mobile", "41999944444");

            DriverStepsAction.QuandoClicarNoBotao("Register");
        }
    }
}
