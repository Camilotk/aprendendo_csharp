# Strategy Pattern
*Tipo*: Padrão Comportamental
O padrão Strategy tenta reduzir o acoplamento de uma família de algorítmos com comportamento similares e fazer com que sejam intercambiaveis entre si. <br>
<br>
 O Padrão Strategy sugere que se produza uma família de classes para cada variação do algoritmo e que se forneça para a classe hospedeira uma instância de Strategy para a qual ela delegará em tempo de execução. Um dos pré-requisitos para o Strategy é uma estrutura de herança onde cada subclasse específica contém uma variação do algoritmo. Assim, o padrão Strategy possui diversos benefícios como clarificar algoritmos ao diminuir ou remover lógica condicional, simplificar uma classe ao mover variações de um algoritmo para uma hierarquia, e habilitar um algoritmo para ser substituído por outro em tempo de execução.
 
## Motivação
Em resumo o padrão Strategy pode ser utilizado quando se tem as seguintes situações:

Quando muitas classes relacionadas diferem apenas no seu comportamento;
<br>
* Quando necessita-se de variantes de um algoritmo;
* Quando se precisa ocultar do usuário a exposição das estruturas de dados complexas, específicas do algoritmo;
* Quando uma classe define muitos comportamentos e por sua vez eles aparecem como diversos “IFs”. Com isso esses comandos condicionais são movidos para sua própria classe Strategy.

## Links
[Medium - Mulheres de Produto - O que é Strategy Pattern?](https://medium.com/mulheres-de-produto/o-que-%C3%A9-strategy-pattern-e-quando-usar-2fc3bcb4873f)<br>
[Estudo e Aplicação do Padrão de Projeto Strategy](https://www.devmedia.com.br/estudo-e-aplicacao-do-padrao-de-projeto-strategy/25856)<br>
[Using the Strategy Pattern (Examples in C#)](https://dev.to/sam_ferree/using-the-strategy-pattern-examples-in-c-4jn6)

## Aula

[![Design Patterns 1](http://img.youtube.com/vi/Z2ScCR1tyzU/0.jpg)](http://www.youtube.com/watch?v=Z2ScCR1tyzU)

## Classes da Aula
* [Program](https://github.com/Camilotk/csharp/blob/master/Design%20Patterns/Strategy/Program.cs): Classe Main, onde o código é executado.
* [Orcamento](https://github.com/Camilotk/csharp/blob/master/Design%20Patterns/Strategy/Orcamento.cs): Classe que abstrai o orçamento, possuindo o atributo _double_ valor e os métodos _get_ e _set_ do mesmo.
* [Imposto](https://github.com/Camilotk/csharp/blob/master/Design%20Patterns/Strategy/Imposto.cs): Interface que faz o contrato da função _Calcula_ que obriga que todos os que implementam-na possam ser usados como paramêtro através de Polimorfismo em métodos de outras classes.
* [Calculadora](https://github.com/Camilotk/csharp/blob/master/Design%20Patterns/Strategy/Calculadora.cs): Classe que possui o método _CalculaImposto_ responsável por receber um objeto _Orcamento_  e uma implementação da interface _Imposto_ e devolver o cálculo realizado dentro da classe específica.
* [ICMS](https://github.com/Camilotk/csharp/blob/master/Design%20Patterns/Strategy/ICMS.cs) e [ISS](https://github.com/Camilotk/csharp/blob/master/Design%20Patterns/Strategy/ISS.cs): Implementações de diferentes impostos (família de tarefas).
