#language: pt-BR
Funcionalidade: ATDD_Compras_
 
Contexto: Processo de compras online
	//Visa garantir que o objetivo principal da funcionalidade compras funcione

Cenário: Processo de compra
	Dado que o cliente escolhe um ou mais produtos
	Quando o cliente fechar o pedido
	Então deve ser efetivada a compra