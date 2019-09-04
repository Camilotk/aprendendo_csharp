# Sets
Os *Sets* (Conjuntos) são coleções de objetos e valores únicos. Existem diversas implementações de Set para diferentes finalidades, entre elas o **HashSet** (*não ordenados*) e o **SortedSet** (*ordenados*). Os elementos em armazenados em um Set são diferenciados pelo valor de Hash <SUP>[1](https://pt.wikipedia.org/wiki/Fun%C3%A7%C3%A3o_hash)</SUP> devolvido pelo método **.GetHashCode()** da Classe Object da qual todos os objetos herdam, isso pode ser consultado mais profundamente na [documentação](https://docs.microsoft.com/pt-br/dotnet/api/system.object.gethashcode?view=netcore-3.0). A Coleção de Set, é implementada pela interface ISet que define todos os comportamentos esperados de uma Set Collection, assim como as interfaces ICollection e IEnumerable. 

## Diferenças de Uso

Os HashSets e SortedLists possuem diferentes usos dependendo do tipo de problema que se está resolvendo, sua principal diferença por baixo dos panos é que os HashSets utilizam-se da implementação de um algoritmo de Hash Table (Tabela de Dispersão) <SUP>[2](https://pt.wikipedia.org/wiki/Tabela_de_dispers%C3%A3o)</SUP> com a finalidade de armazenar os dados em conjuntos sem que haja a repetição, uma característica dessse algoritmo é uma maior eficiência em processamento e velocidade, porém os itens ficam organizados de forma não ordenada e uma nova inserção pode resultar em uma reorganização (realocação) dos indices da coleção como um todo, enquanto o SortedSet utiliza-se de balanced binary-tree ou red-black tree (Árvores Rubro-negras) <SUP>[3](https://pt.wikipedia.org/wiki/%C3%81rvore_rubro-negra)</SUP> para organizar as coleções, o que resulta em algoritmos que exigem maior computação, porém capazes de armazenar os dados de forma ordenada o que permite buscas eficientes e operações como fatiamento de listas <SUP>[4](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.sortedset-1.getviewbetween?view=netcore-3.0#System_Collections_Generic_SortedSet_1_GetViewBetween__0__0_)</SUP> de forma precisa e segura.

## Índice de Sets
- [HashSet](#)
- [SortedSet](#)

### Referências
- [SortedSet<T> vs HashSet<T>](https://stackoverflow.com/questions/4622736/sortedsett-vs-hashsett)
- [ref](#)
- [ref](#)
- [ref](#)
