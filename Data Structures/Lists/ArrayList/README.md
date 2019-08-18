# ArrayList
A Estrutura ArrayList (List) é uma estrutura de vetor com capacidade de dinamicamente alocar qualquer quantidade de Objetos. Ela surgiu  para facilitar a criação de coleções de uma forma mais inteligente do que é feito pelos arrays nativos, utilizando-se da Orientação à Objetos para utilizar-se de métodos que facilitem a manipulação dos dados contidos no array. Por exemplo, se quisessemos adicionar um elemeto em um índice no meio do array, precisariámos inseri-lo e então reordenar todos os elementos posteriores, porém uma estrutura de ArrayList bem implemntada cuida disso para nós quando utilizamos o método **.add(** *Object o* **)**, também podemos utilizar o método **.get(** *int index* **)** para pegar o Objeto guardado na posição do índice. Além disso como dito anteriormente, o ArrayList pode implementar alguns métodos de manipulação, a implementação padrão utiliza [estes](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.list-1?view=netframework-4.8#m%C3%A9todos).

<p align="center">
<img src="https://www.caelum.com.br/apostila-csharp-orientacao-objetos/imagens/listas/list.png" />
</p>

## Implementação básica em C#
- [MyArrayList.cs](https://github.com/Camilotk/aprendendo_csharp/blob/master/Data%20Structures/Lists/ArrayList/Implementation/MyArrayList.cs)

### Propriedades
O ArrayList possui três propriedades, uma que guarda o tamanho do ArrayList (*size*), uma constante que guarda a quantidade padrão de itens (capacidade, DEFAULT_CAPACITY) e um Array nativo que é instanciado no construtor com o tamanho padrão.
```C#
private int size = 0;
private static readonly int DEFAULT_CAPACITY = 10;
private Object[] elements;
```
### Método Add
A implementação do método **.Add(** *Object o* **)** recebe o objeto do tipo genérico <T> declarado quando a classe é criada, a vantagem de utlizar tipos genéricos ao invés de Object é que quando o método recebe um objeto acontece a checagem se o tipo do objeto é o mesmo declarado na classe.

**Linhas 3-6**
```C#
namespace ArrayList
{
    public class MyArrayList<T>
    {  
```
**Linhas 24-33**  
```C#
public void add(T e)
{
  if (size == elements.Length)
  {
    this.resize();
  }
  elements[size++] = e;
}
```
Primeiramente, se o número de elementos for igual ao tamanho do ArrayList, será chamado o método **.resize()**. Então, o objeto será adicionado no final do array (após o incrementar o valor de *size*, o valor é passado como índice).

### Método Resize
É um método chamado internamente pela classe sempre quando o tamanho atinge o mesmo valor do número de elementos, esse é o método responsável pela **alocação dinâmica** do número de objetos que o ArrayList guarda. Então, o valor do número de elementos no array nativo implementado na classe, multiplicado por dois é guardado na variável *newSize*. 
Após isso, é utilizado o método **Array.Copy(** *array*, *array*, *int* **)**[¹]()  que copia um array para outro com um novo tamanho, e é passado então para que elements seja aumentado com o tamanho definido em *newSize*.
```C#
public void resize()
{
  int newSize = elements.Length * 2;
  Array.Resize(ref elements, newSize);
}
```
### Método Get
O método **.Get(** *int index* **)** é implementado recebendo um indice e retornando um objeto do tipo genérico. Primeiramente, é checado se o indice é valido (menor que zero ou maior que o tamanho do array) e caso seja inválido, então é retornado a exceção IndexOutOfRangeException. Caso seja válido, é retornado o elemento no array *elements* no indice passado com cast para o objeto genérico passado.

```C#
public T get(int i) 
{
    if (i >= size || i < 0) 
    {
        throw new System.IndexOutOfRangeException("Index: " + i + ", Size " + i );
    }
    return (T) elements[i];
 }
```
# Referências
- [Trabalho com listas - Caelum](https://www.caelum.com.br/apostila-csharp-orientacao-objetos/trabalhando-com-listas/)
