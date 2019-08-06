# Strategy Pattern
O padrão Strategy tenta reduzir o acoplamento de uma família de algorítmos com comportamento similares e fazer com que sejam intercambiaveis entre si. <br>
<br>
 O Padrão Strategy sugere que se produza uma família de classes para cada variação do algoritmo e que se forneça para a classe hospedeira uma instância de Strategy para a qual ela delegará em tempo de execução. Um dos pré-requisitos para o Strategy é uma estrutura de herança onde cada subclasse específica contém uma variação do algoritmo. Assim, o padrão Strategy possui diversos benefícios como clarificar algoritmos ao diminuir ou remover lógica condicional, simplificar uma classe ao mover variações de um algoritmo para uma hierarquia, e habilitar um algoritmo para ser substituído por outro em tempo de execução.
 
## Motivação
Em resumo o padrão Strategy pode ser utilizado quando se tem as seguintes situações:

Quando muitas classes relacionadas diferem apenas no seu comportamento;

* Quando necessita-se de variantes de um algoritmo;
* Quando se precisa ocultar do usuário a exposição das estruturas de dados complexas, específicas do algoritmo;
* Quando uma classe define muitos comportamentos e por sua vez eles aparecem como diversos “IFs”. Com isso esses comandos condicionais são movidos para sua própria classe Strategy.

## Aula

[![Design Patterns 1](http://img.youtube.com/vi/Z2ScCR1tyzU/0.jpg)](http://www.youtube.com/watch?v=Z2ScCR1tyzU)
