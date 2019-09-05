using System;
using System.Collections.Generic;

namespace SetsTest.HashSet
{
    // O HashSet é um conjunto de objetos únicos não ordenados organizados em
    // coleção, internamente ele implementa uma Hash Table (Dictionary em C#)
    // que armazena o Objeto passado e garante que não haja repetição de items
    //
    // OBS: Caso queira entender a implementação de Dictionary<T, K> veja a 
    // seção de Dictionaries em Estrutura de Dados
    public class MyHashSet<T>
    {
        // A Classe HashSet implementa internamente um Dictionary (HashTable)
        // que irá guardar uma chave do tipo genérico do conjunto e um objeto
        // que diz se ele já está presente na coleção.
        Dictionary<T, Object> map;
        // Define o Objeto que indica se o Objeto está presente ou não
        private static readonly Object PRESENT = new Object();
        // Guarda um valor inteiro positivo que representa o número de objetos
        // no map
        private uint numberOfElements;

        public MyHashSet()
        {
            map = new Dictionary<T, object>();
        }

        // Retorna o número de elementos dentro do HashSet
        public uint Count => numberOfElements;

        // Adiciona um novo Objeto ao HashSet
        public bool Add(T item)
        {
            try
            {
                // Tenta adicionar um novo objeto ao Map
                // Caso ele já exista irá lançar uma Exceção
                map.Add(item, PRESENT);
                return true;
            }
            catch(ArgumentException e)
            {
                // Caso a exceção seja que o Objeto já existe
                // irá imprimir o erro e retornar falso
                //
                // obs: comente essa linha para suprimir a mensagem
                Console.WriteLine(e.Message);
                return false;
            }
            catch(Exception)
            {
                // Qualquer outra exceção irá apenas retornar falso
                return false;
            }
        }

        public void Clear()
        {
            // Limpa o HashSet
            map.Clear();
        }

        public bool Contains(T item)
        {
            // Retorna se o elemento do tipo genérico passsado
            // está presente no HashSet
            return map.ContainsKey(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return map.Keys.GetEnumerator();
        }

        public bool Remove(T item)
        {
            // Retorna se a chave do Map foi encontrada e corretamente removida
            return map.Remove(item);
        }
    }
}
