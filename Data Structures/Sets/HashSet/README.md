# HashSet
Os HashSets (Conjunto de Dispersão) é um tipo de estrutura que tenta otimizar o trabalho de uma Lista para que contenha apenas valores únicos. Além disso, a garantia de unicidade também facilida o trabalho de busca por determinado item, uma vez em que o HashSet categoriza os items armazenados de forma que consiga garantir de forma eficiente que não há nenhum elemento duplicado. Os HashSets depedem diretamente da função **.GetHashCode()** que pertence à Classe Object do C#, essa função retorna um código único**¹** para cada objeto o que garante que cada objeto contido no Conjunto é único. 

Assim como LinkedLists implementam um Array primitivo que armazena os objetos passados, os HashSets implementam uma estrutura de Dicionário que recebe dois valores, o valor passado em si e o objeto que representa se o objeto passado já está inserido ou não. 

<p align="center">
<img src="https://upload.wikimedia.org/wikipedia/commons/thumb/7/7d/Hash_table_3_1_1_0_1_0_0_SP.svg/320px-Hash_table_3_1_1_0_1_0_0_SP.svg.png">
 <i style="font-size=6px;">Exemplo de HashTable - Dicionário - que armazena os elementos.</i>
</p>

## Implementação básica em C#
- [MyHashSet.cs](https://github.com/Camilotk/aprendendo_csharp/blob/master/Data%20Structures/Sets/HashSet/Implementation/MyHashSet.cs)
# Referências
 - [How HashSet is internally implemented in Java?](https://codepumpkin.com/hashset-internal-implementation/)
 - [VERY simple C# Set implementation](https://codereview.stackexchange.com/questions/126263/very-simple-c-set-implementation/126266)
 - [Lidando com conjuntos](https://www.caelum.com.br/apostila-csharp-orientacao-objetos/lidando-com-conjuntos/)
