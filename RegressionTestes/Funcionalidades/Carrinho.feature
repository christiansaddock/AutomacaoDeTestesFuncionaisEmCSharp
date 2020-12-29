#language: pt-BR
Funcionalidade: Regress_Carrinho_
 
Contexto: Exibição e contabilização dos produtos no carrinho

Cenário: Listagem de produtos e inclusão no carrinho de compras
	Dado a listagens dos produtos
	Quando o cliente escolhe um produto
	Então o produto deve ser adicionado ao carrinho

#Cenário: Situação dos itens
#
#Cenário: Remoção dos itens
#
#Cenário: Somatórios
#
#Cenário: etc.
	