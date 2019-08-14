using System;

namespace ArrayList
{
    public class MyArrayList<T>
    {
        // Propriedade que guarda o tamanho do ArrayList
        private int size = 0;
        // Constante que guarda o tamanho máximo padrão da implementação
        private static readonly int DEFAULT_CAPACITY = 10;
        // Array de objetos onde os elementos serão colocados
        private Object[] elements;

        // Construtor
        public MyArrayList()
        {
            elements = new Object[DEFAULT_CAPACITY];
        }

        // Método add
        // Des: Adiciona o elemento à ArrayList
        // Recebe: elemento (e) do tipo genérico <T>
        // Retorna: void
        public void add(T e)
        {
            // se tamanho == nº de elementos, então aumente a capacidade
            if (size == elements.Length)
            {
                this.resize();
            }
            // coloca e na posição de size++ (tamanho + 1)
            elements[size++] = e;
        }

        // Método resize
        // Des: Dobra o tamanho do ArrayList cada vez que o mesmo enche.
        // Recebe: void
        // Retorna: void
        public void resize()
        {
            int newSize = elements.Length * 2;
            // Copia todos os elementos para o mesmo array com o tamanho duplicado
            Array.Copy(elements, elements, newSize);
        }

        // Método get
        // Des: Retorna os dados armazenados no indice passado
        // Recebe: indice (i) tipo inteiro
        // Retorna: elemento na posição i (element[i]) do tipo genérico
        public T get(int i) {
            if (i >= size || i < 0) {
                throw new System.IndexOutOfRangeException("Index: " + i + ", Size " + i );
            }
            return (T) elements[i];
        }
    }
}
