#language:pt-br

Funcionalidade: Aluguel
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Cenário: Aluguel filme
	Dado que esteja na página inicial
	E Fechado o Walkthrough
	E Login efetuado
	E Filme pesquisado
	E Filme selecionado
	Quando Clicado no botão alugar da modal
	E Pin inserido corretamente 
	E Clicar no botão de confirmação
	Então Usuário é encaminhado à tela de reprodução.


#	Cenário: Aluguel filme PIN errado
#	Dado o navegador esta aberto
#	E a URL acessada é o NOW
#	E Fechado o Walkthrough
#	E Login efetuado
#	E Filme pesquisado
#	E Filme selecionado
#	Quando Clicado no botão alugar da modal
#	E Pin inserido incorretamente 
#	E Clicar no botão de confirmação
#	Então Exibe mensagem de PIN inválido "Senha Incorreta"
#
#
#	Cenário: Aluguel filme PIN em branco
#	Dado o navegador esta aberto
#	E a URL acessada é o NOW
#	E Fechado o Walkthrough
#	E Login efetuado
#	E Filme pesquisado
#	E Filme selecionado
#	Quando Clicado no botão alugar da modal
#	E Clicar no botão de confirmação
#	Então Exibe mensagem de PIN inválido "Senha Incorreta"