# LinkedList
A LinkedList é uma estrutura de dados linear, consiste de um grupo de nós em sequência. Os nós possuem duas informações, o dado ou objeto que guardam e a referência para o próximo nó. Elas possuem natureza dinâmica como os Lists (ArrayLists), porém por ser sequencial oferece vantagem nas operações de inserção e remoção de dados/objetos guardados, perdendo performance nas operações de modificar ou receber os dados armazenados. Ela é a estrutura básica utilizada para implementar outras estruturas mais complexas como Filas[¹](https://pt.wikibooks.org/wiki/Algoritmos_e_Estruturas_de_Dados/Filas), Pilhas[²](https://pt.wikibooks.org/wiki/Algoritmos_e_Estruturas_de_Dados/Pilhas) e Árvores[³](https://pt.wikibooks.org/wiki/Algoritmos_e_Estruturas_de_Dados/Árvore).

<p align="center">
<img src="https://github.com/Camilotk/aprendendo_csharp/blob/master/Data%20Structures/Lists/LinkedList/linked_list.png" />
</p>

## Tipos de LinkedList
- **Single LinkedList**: Cada nó contêm a informação do próximo nó e o dado que estão guardando, fazendo com que todos os acessos sejam sequenciais sempre do primeiro até o último nó.

<p align="center">
<img src="https://github.com/Camilotk/aprendendo_csharp/blob/master/Data%20Structures/Lists/LinkedList/single_linkedlist.webp" />
</p>

- **Double LinkedList**: Cada nó contêm a informação do nó anterior e do próximo nó, além do dado que estão guardando. Permitindo que sejam acessados tanto do primeiro até o último nó, quanto do último até o primeiro nó.

<p align="center">
<img src="https://github.com/Camilotk/aprendendo_csharp/blob/master/Data%20Structures/Lists/LinkedList/double_linkedlist.webp" />
</p>

- **Circular LinkedList**: Estrutura similar ao single linkedlist em que cada nó contêm a informação do próximo nó e o dado que estão guardando, exceto pelo último nó guardar a referência do primeiro, permitindo que seu acesso possa facilmente ser reiniciado.

<p align="center">
<img src="https://github.com/Camilotk/aprendendo_csharp/blob/master/Data%20Structures/Lists/LinkedList/circular_linkedlist.webp" />
</p>

## Implementação de uma Single LinkedList em C#
Optei por mostrar a implementação de uma *single linkedlist* por ser a estrutura mais simples de implementar, mas a partir de sua implementação é fácil de implementar *Double LinkedLists* (adicionando a ref. do nó anterior ao nó) e *Circular LinkedLists* (adicionando a ref. do primeiro nó caso o próximo seja nulo).
- [LinkedList.cs](https://github.com/Camilotk/aprendendo_csharp/blob/master/Data%20Structures/Lists/LinkedList/Implementation/LinkedList.cs)
- [Node.cs](https://github.com/Camilotk/aprendendo_csharp/blob/master/Data%20Structures/Lists/LinkedList/Implementation/Node.cs)

### Propriedades

### Método Add

# Referências
- [What is linked list?](https://www.quora.com/What-is-linked-list-1)
- [Algoritmos e Estruturas de Dados/Lista encadeada](https://pt.wikibooks.org/wiki/Algoritmos_e_Estruturas_de_Dados/Lista_encadeada)
