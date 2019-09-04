# Sets
Os *Sets* (Conjuntos) são coleções de objetos e valores únicos. Existem diversas implementações de Set para diferentes finalidades, entre elas o **HashSet** (*não ordenados*) e o **SortedSet** (*ordenados*). Os elementos em armazenados em um Set são diferenciados pelo valor de Hash[¹](https://pt.wikipedia.org/wiki/Fun%C3%A7%C3%A3o_hash) devolvido pelo método **.GetHashCode()** da Classe Object da qual todos os objetos herdam, isso pode ser consultado mais profundamente na [documentação](https://docs.microsoft.com/pt-br/dotnet/api/system.object.gethashcode?view=netcore-3.0). A Coleção de Set, é implementada pela interface ISet que define todos os comportamentos esperados de uma Set Collection, assim como as interfaces ICollection e IEnumerable. 

## Diferenças de Performance

|          | HashSet         | SortedSet       |
|----------|-----------------|-----------------|
| get()    | O(1)            | O(n)            |
| add()    | O(1)            | O(1) amortizado |
| remove() | O(n)            | O(n)            |

## Índice de Sets
- [HashSet](#)
- [SortedSet](#)

### Referências
- [ref](#)
- [ref](#)
- [ref](#)
- [ref](#)
