# SortedSet
A estrutura de SortedSet (Conjuntos Ordenados) permitem armazenar um conjunto de valores únicos ordenados de forma crescente, pelo seu valor natural - alfabético ou numérico - ou ordem especificada diretamente por um Objeto do tipo Comparator. Diferentemente do HashSet em que os elementos são ordenados conforme seu valor de Hash que por definição não conhecemos, o SortedSet guarda os elementos de forma ordenada, facilitando possiveis buscas que possam ser otimizadas por buscas ou métodos que possam beneficiar-se de ter os elementos ordenados (Ex: Um algoritmo que busca o nome de pessoas em uma lista telefônica cujo o nome inicie com uma letra entre M..Z do alfabeto). Apesar de seus itens estarem ordenados, é importante notar que o SortedSet é uma derivação de ISet e portanto é uma coleção que **não implementa índice**. 

A garantia de unicidade e organização de um SortedSet vem da implementação de uma Árvore Rubro-Negra que armazena em nós os objetos passados e os organiza, caso queira entender melhor sobre o algoritmo de Árvore Rubro-Negra em si você pode assistir este [vídeo](https://www.youtube.com/watch?v=DaWNuijRRFY) que explica sua lógica e funcionamento.

<div align="center">
  <figure>
    <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/6/66/Red-black_tree_example.svg/320px-Red-black_tree_example.svg.png">
    <br>
     <figcaption>
        <i style="font-size=6px;">Exemplo de representação do algoritmo de Árvore Binária Rubro-Negra que armazena os elementos.</i>
     </figcaption>  
   </figure>
</div>

## Implementação básica em C#
A implementação do SortedSet depende da implementação da Árvore Rubro-Negra que foi implementada em C#, porém o foco do estudo neste tópico é a implementação do SortedSet e por isso não será estudado os detalhes da árvore, apesar de ser possivel estudá-la acessando o seu código fonte implementado nos arquivos.
- [MySortedSet.cs](https://github.com/Camilotk/aprendendo_csharp/blob/master/Data%20Structures/Sets/SortedSet/Implementation/MySortedSet.cs)
- [RedBlackTree.cs](https://github.com/Camilotk/aprendendo_csharp/blob/master/Data%20Structures/Sets/SortedSet/Implementation/RedBlackTree.cs)

## Imports
**Linhas A a z**

...

```C#
...
```

### Propriedades
**Linhas A a z**

...

```C#
...
```

### Método Construtor
**Linhas A a z**

...

```C#
// ...
```

### Método .Add()
**Linhas de A a z**

...

```C#
// ...
```

### Método .Clear()
**Linhas A a z**

...

```C#
// ...
```

### Método .Contains()
**Linhas A a z**

...

```C#
// ...
```

### Método .Remove()
**Linhas A..z**

...

```C#
// ...
```

## Exemplo de Uso
...

```C#
// ...
```
**Output:**

```
// ...
```
# Referências

 - [ref](#)
 - [ref](#)
 - [ref](#)
