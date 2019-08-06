# Strategy Pattern
O padrão Strategy tenta reduzir o acoplamento de uma família de algorítmos com comportamento similares e fazer com que sejam intercambiaveis entre si.
## Motivação
Em resumo o padrão Strategy pode ser utilizado quando se tem as seguintes situações:

Quando muitas classes relacionadas diferem apenas no seu comportamento;

* Quando necessita-se de variantes de um algoritmo;
* Quando se precisa ocultar do usuário a exposição das estruturas de dados complexas, específicas do algoritmo;
* Quando uma classe define muitos comportamentos e por sua vez eles aparecem como diversos “IFs”. Com isso esses comandos condicionais são movidos para sua própria classe Strategy.
