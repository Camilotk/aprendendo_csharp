# ArrayList
A Estrutura ArrayList (List) é uma estrutura de vetor com capacidade de dinamicamente alocar qualquer quantidade de Objetos. Ela surgiu  para facilitar a criação de coleções de uma forma mais inteligente do que é feito pelos arrays nativos, utilizando-se da Orientação à Objetos para utilizar-se de métodos que facilitem a manipulação dos dados contidos no array. Por exemplo, se quisessemos adicionar um elemeto em um índice no meio do array, precisariámos inseri-lo e então reordenar todos os elementos posteriores, porém uma estrutura de ArrayList bem implemntada cuida disso para nós quando utilizamos o método **.add(** *Object o* **)**, também podemos utilizar o método **.get(** *int index* **)** para pegar o Objeto guardado na posição do índice. Além disso como dito anteriormente, o ArrayList pode implementar alguns métodos de manipulação, a implementação padrão utiliza [estes](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.list-1?view=netframework-4.8#m%C3%A9todos).

<p align="center">

![ArrayList sendo re-ordenado](https://www.caelum.com.br/apostila-csharp-orientacao-objetos/imagens/listas/list.png)

</p>

## Implementação em C#
- [MyArrayList.cs](https://github.com/Camilotk/aprendendo_csharp/blob/master/Data%20Structures/Lists/ArrayList/Implementation/MyArrayList.cs)

# Referências
- [Trabalho com listas - Caelum](https://www.caelum.com.br/apostila-csharp-orientacao-objetos/trabalhando-com-listas/)
