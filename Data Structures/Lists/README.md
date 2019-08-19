# Lists
Uma List (às vezes chamada de sequência) é uma coleção ordenada que pode conter elementos duplicados. Como os arrays, índices de uma lista seguem a numeração baseada em zero (Zero-based numbering)[¹](https://en.wikipedia.org/wiki/Zero-based_numbering). As listas ordenadas herdam das interfaces IEnumerable, ICollection e IList. Nessa categoria estão as estruturas **List** (*ou ArrayList*) e **LinkedList**.  A classe List é uma implementação de array redimensionável com acesso randômico. LinkedLists são coleções ordenadas em que cada nó (objeto que contêm a informação) também contenha a referência para o próximo nó, fazendo com que assim todos fiquem ordenados um após o outro.

**Obs:** Em C#, a implementação padrão da linguagem de um ArrayList permite ser feita pelas classes **List** e **ArrayList** como pode ser visto melhor [aqui](https://stackoverflow.com/a/50736397).

## Diferenças de Performance
Inserir um elemento entre os elementos existentes de um ArrayList é uma operação ineficiente — todos os elementos depois do novo devem ser removidos, o que pode ser uma operação cara em uma coleção com um grande número de elementos. Uma LinkedList permite a inserção (ou remoção) eficiente dos elementos no meio de uma coleção, mas é muito menos eficiente que um ArrayList para pular para um elemento específico na coleção.

|          | List (ArrayList)| LinkedList      |
|----------|-----------------|-----------------|
| get()    | O(1)            | O(n)            |
| add()    | O(1)            | O(1) amortizado |
| remove() | O(n)            | O(n)            |

## Indice de Listas
- [List](https://github.com/Camilotk/aprendendo_csharp/tree/master/Data%20Structures/Lists/ArrayList)
- [LinkedList](https://github.com/Camilotk/aprendendo_csharp/tree/master/Data%20Structures/Lists/LinkedList)

### Referências
- [When should I use a List vs a LinkedList?](https://stackoverflow.com/a/169983)
- [When to use LinkedList over ArrayList in Java?](https://stackoverflow.com/questions/322715/when-to-use-linkedlist-over-arraylist-in-java)
- [ArrayList vs. LinkedList vs. Vector](https://www.programcreek.com/2013/03/arraylist-vs-linkedlist-vs-vector/)
