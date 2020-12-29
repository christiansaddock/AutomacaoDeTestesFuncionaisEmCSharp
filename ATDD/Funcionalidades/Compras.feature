#language: pt-BR
Funcionalidade: Compras_
 
Contexto: Processo de compras online
	//Visa garantir que o objetivo principal da funcionalidade compras funcione

Cenário: Carrinho de compras
	Dado que os produtos são disponibilizados para venda
	Quando o cliente escolher um ou mais produtos
	Então estes itens devem ser agrupados e contabilizados em um carrinho de compras

Cenário: Processo de compra
	Dado que há ao menos um item no carrinho
	Quando o cliente fechar o pedido
	Então devem ser coletados os dados do cliente para efetivação da compra