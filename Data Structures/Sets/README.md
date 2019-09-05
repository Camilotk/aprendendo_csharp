# Sets
Os *Sets* (Conjuntos) são coleções de objetos e valores únicos. Existem diversas implementações de Set para diferentes finalidades, entre elas o **HashSet** (*não ordenados*) e o **SortedSet** (*ordenados*). Os elementos em armazenados em um Set são diferenciados pelo valor de Hash <SUP>[1](https://pt.wikipedia.org/wiki/Fun%C3%A7%C3%A3o_hash)</SUP> devolvido pelo método **.GetHashCode()** da Classe Object da qual todos os objetos herdam, isso pode ser consultado mais profundamente na [documentação](https://docs.microsoft.com/pt-br/dotnet/api/system.object.gethashcode?view=netcore-3.0). A Coleção de Set, é implementada pela interface ISet que define todos os comportamentos esperados de uma Set Collection, assim como as interfaces ICollection e IEnumerable. Diferentemente de Listas, em Conjuntos, não há como obter elementos por índice de um conjunto, sendo necessário iterar os itens a partir de um **foreach()** ou então obter o item esperado diretamente passando-o no método **.Get(** *Object* **)** do conjunto. Isso acontece porque tratando-se de Conjuntos **não existe ordem**, os itens são contatemente reorganizados à medida em que são inseridos seja por ordem de Hash no caso do HashSet ou por ordem de algum atributo como no caso do SortedSet.

## Diferenças de Uso

Os HashSets e SortedLists possuem diferentes usos dependendo do tipo de problema que se está resolvendo, sua principal diferença por baixo dos panos é que os HashSets utilizam-se da implementação de um algoritmo de Hash Table (Tabela de Dispersão) <SUP>[2](https://pt.wikipedia.org/wiki/Tabela_de_dispers%C3%A3o)</SUP> com a finalidade de armazenar os dados em conjuntos sem que haja a repetição, uma característica dessse algoritmo é uma maior eficiência em processamento e velocidade, porém os itens ficam organizados de forma não ordenada e uma nova inserção pode resultar em uma reorganização (realocação) dos indices da coleção como um todo, enquanto o SortedSet utiliza-se de balanced binary-tree ou red-black tree (Árvores Rubro-negras) <SUP>[3](https://pt.wikipedia.org/wiki/%C3%81rvore_rubro-negra)</SUP> para organizar as coleções, o que resulta em algoritmos que exigem maior computação, porém capazes de armazenar os dados de forma ordenada o que permite buscas eficientes e operações como fatiamento de listas <SUP>[4](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.sortedset-1.getviewbetween?view=netcore-3.0#System_Collections_Generic_SortedSet_1_GetViewBetween__0__0_)</SUP> de forma precisa e segura.

## Eficiência
|Operação| HashSet (*Média*) | HashSet (*Pior Caso*) | SortedSet (*Média*) | SortedSet(*Pior Caso*)|
|--------|-------------------|-----------------------|---------------------|-----------------------|
| Search | O(1)              | O(n)                  | O(*log n*)          | O(*log n*)            |   
| Insert | O(1)              | O(n)                  | O(*log n*)          | O(*log n*)            |   
| Delete | O(1)              | O(n)                  | O(*log n*)          | O(*log n*)            |   

## Índice de Sets
- [HashSet](https://github.com/Camilotk/aprendendo_csharp/tree/master/Data%20Structures/Sets/HashSet)
- [SortedSet](#)

### Referências
- [SortedSet<T> vs HashSet<T>](https://stackoverflow.com/questions/4622736/sortedsett-vs-hashsett)
- [Trabalhando com a Interface Set no Java](http://www.linhadecodigo.com.br/artigo/3669/trabalhando-com-a-interface-set-no-java.aspx)
- [Set Operations](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/concepts/linq/set-operations)
- [ref](#)
