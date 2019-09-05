# HashSet
Os HashSets (Conjunto de Dispersão) é um tipo de estrutura que tenta otimizar o trabalho de uma Lista para que contenha apenas valores únicos. Além disso, a garantia de unicidade também facilida o trabalho de busca por determinado item, uma vez em que o HashSet categoriza os items armazenados de forma que consiga garantir de forma eficiente que não há nenhum elemento duplicado. Os HashSets depedem diretamente da função **.GetHashCode()** que pertence à Classe Object do C#, essa função retorna um código único**¹** para cada objeto o que garante que cada objeto contido no Conjunto é único. 

Assim como LinkedLists implementam um Array primitivo que armazena os objetos passados, os HashSets implementam uma estrutura de Dicionário que recebe dois valores, o valor passado em si e o objeto que representa se o objeto passado já está inserido ou não. 

<div align="center">
  <figure>
    <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/7/7d/Hash_table_3_1_1_0_1_0_0_SP.svg/320px-Hash_table_3_1_1_0_1_0_0_SP.svg.png">
    <br>
     <figcaption>
        <i style="font-size=6px;">Exemplo de HashTable - Dicionário - que armazena os elementos.</i>
     </figcaption>  
   </figure>
</div>

## Implementação básica em C#
- [MyHashSet.cs](https://github.com/Camilotk/aprendendo_csharp/blob/master/Data%20Structures/Sets/HashSet/Implementation/MyHashSet.cs)

### Propriedades
**Linhas 17 a 22**

A propriedade **map** é a HashTable (Tabela de Disperção) que guarda os objetos passados, a maior parte das implementações já vem por default dos métodos que a classe Dictionary<T, K> das collections de C# possui.
A propriedade PRESENT é uma propriedade imutável do tipo objeto sem implementação derivada que representa o objeto adicionado, ele serve para checar se um dos objetos inseridos já está no conjunto ou se o objeto buscado está presente no conjunto.
A propriedade do tipo unsigned integer (inteiro positivo ou I<sup>*</sup><sub>+</sub>) é o número de elementos já adicionados ao conjunto.

```C#
Dictionary<T, Object> map;
private static readonly Object PRESENT = new Object();
private uint numberOfElements;
```
### Método Construtor

### Método .Add()

### Método .Remove()

### Método .Clear()

### Método .Contains()

## Exemplo de Uso
Podemos passar todos os itens de uma lista para um conjunto com a finalidade de garantir que não haja itens repetidos.

```C#
using System;
using System.Collections.Generic;
using SetsTest.HashSet;

namespace SetsTest
{
    class Program
    {
        // Oranges, peach, pears, plums, syringes
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>(){
                "apple",
                "orange",
                "peaches",
                "pears",
                "orange",
                "pears",
                "mirtilo",
                "apple"

            };

            MyHashSet<string> fruits_group = new MyHashSet<string>();
            Console.WriteLine("---------");
            foreach (var fruit in fruits)
            {
                fruits_group.Add(fruit);
            }
            Console.WriteLine("---------");
            foreach (var fruit in fruits_group)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine("---------");
            Console.WriteLine("Elementos no Conjunto: {0}", fruits_group.Count);
        }
    }
}
```
**Output:**
```
---------
An item with the same key has already been added. Key: orange
An item with the same key has already been added. Key: pears
An item with the same key has already been added. Key: apple
---------
apple
orange
peaches
pears
mirtilo
---------
Elementos no Conjunto: 5
```
# Referências
 - [How HashSet is internally implemented in Java?](https://codepumpkin.com/hashset-internal-implementation/)
 - [VERY simple C# Set implementation](https://codereview.stackexchange.com/questions/126263/very-simple-c-set-implementation/126266)
 - [Lidando com conjuntos](https://www.caelum.com.br/apostila-csharp-orientacao-objetos/lidando-com-conjuntos/)
 - [Set - Wikipedia](https://en.wikipedia.org/wiki/Set_(abstract_data_type))
 - [HashTable - Wikipedia](https://en.wikipedia.org/wiki/Hash_table)
