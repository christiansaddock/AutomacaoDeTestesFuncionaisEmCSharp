#language: pt-BR
Funcionalidade: Regress_CadastroDeConta_
 
Contexto: Exibição dos produtos
	//Visa garantir a boa e correta exibição dos produtos na vitrine

Cenário: Cadastro de novo cliente
	Dado a tela de cadastro de conta
	Quando cliente informar seus dados de cadastro
	Então o endereço deve ser cadastrado corretamente