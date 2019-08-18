using System;

public class LinkedList
{
    // Propriedade que guarda o nó da primeira posição
    private Node head;

    // Método printAllNodes
    // Des:
    // Recebe: 
    // Retorna: 
    public void printAllNodes()
    {
        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.data);
            current = current.next;
        }
    }

    // Método AddFirst
    // Des: Adiciona o objeto passado como primeiro da lista
    // Recebe: Objeto (qualquer) data
    // Retorna: void
    public void AddFirst(Object data)
    {
        Node toAdd = new Node();
        toAdd.data = data;
        toAdd.next = head;
        head = toAdd;
    }

    // Método AddLast
    // Des: Adiciona o objeto passado como último da lista
    // Recebe: Objeto (qualquer) data
    // Retorna: void
    public void AddLast(Object data)
    {
        // se o primeiro não possui nenhum no (lista vazia)
        // adiciona o objeto passado como head e o próximo nulo
        if (head == null)
        {
            head = new Node();
            head.data = data;
            head.next = null;
        }
        else
        {
            // caso contrario
            // guarda o objeto como objeto a ser adicionado
            Node toAdd = new Node();
            toAdd.data = data;
            // passa o primeiro no como no atual
            Node current = head;
            while (current.next != null)
            {
                // enquanto o proximo no nao for nulo
                // o no atual recebe o valor do proximo no atual
                current = current.next;
            }
            // quando nao houver mais dados no proximo no
            // o no que guarda o objeto a ser adicionado
            // é guardado como proximo no do atual
            current.next = toAdd;
        }
    }
}
