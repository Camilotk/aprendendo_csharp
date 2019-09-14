using System;
using System.Collections.Generic;
using System.Text;

namespace SetsTest.SortedSet
{
    public class RedBlackTree<T> where T : IComparable
    {
        private class Node
        {
            // Propriedades:
            // item do tipo genérico
            private T item;
            // autoreferencia ao nó da esquerda
            private Node left;
            // autoreferencia ao nó da direita
            private Node right;
            // autoreferencia ao nó de cima
            private Node parent;
            // valor booleano se o nó é vermelho ou não
            private bool red = true;

            public Node Left { 
                get 
                {
                    return left;
                } 
                set
                {
                    left = value;
                } 
            }

            public Node Right { 
                get 
                {
                    return right;
                } 
                set
                {
                    right = value;
                } 
            }

            public Node Parent { 
                get 
                {
                    return parent;
                } 
                set
                {
                    parent = value;
                } 
            }

            public bool Red 
            {
                get
                {
                    return red;
                }
                set
                {
                    red = value;
                }
            }

            public T Item 
            {
                get
                {
                    return item;
                }
                set
                {
                    item = value;
                } 
            }

            // Construtor:
            // Recebe:
            //         - T item: item do tipo genérico
            //         - Node parent: nó superior
            //Descrição:
            //    Guarda o item e adiciona qual o nó que gerou este como acima
            public Node(T item, Node parent)
            {
                this.item = item;
                this.parent = parent;
                this.left = null;
                this.right = null;
            }
        }
        // ---------------------

        //Propriedades:
        // Primeiro nó
        private Node root;
        // Número de Elementos
        private uint numberOfElements;
        // Nó inserido
        private Node insertedNode;
        // Nó que sendo deletado
        private Node nodeBeingDeleted;
        // Tem parente a esquerda?
        private bool siblingToRight;
        //
        private bool parentToRight;
        // Nó para deletar vermelho
        private bool nodeToDeleteRed;

        // Método Adicionar
        // Recebe:
        //   - T item: item do tipo genérico da classe
        // Descrição:
        //   - Adiciona um novo item à árvore
        public void Add(T item)
        {
            root = InsertNode(root, item, null);
            numberOfElements++;
            if(numberOfElements > 2)
            {
                Node parent;
                Node grandParent;
                Node greatGrandParent;
            }
        }

        // Método Rotacionar (Direita e Esquerda)
        // Recebe:
        //   - Node node: Nó por referencia - muda seu valor original.
        // Descrição:
        //   - Reordena os nós para que o nó acima, direita e esquerda rotacionem em sentido horário
        //     ou antihorário
        private void LeftRotate(ref Node node)
        {
            Node nodeParent = node.Parent;
            Node right = node.Right;
            Node temp = right.Left;
            right.Left = node;
            node.Parent = right;
            node.Right = temp;

            if (temp != null)
            {
                temp.Parent = node;
            }

            if (right != null)
            {
                right.Parent = nodeParent;
            }

            node = right;
        }


        private void RightRotate(ref Node node)
        {
            Node nodeParent =  node.Parent;
            Node left = node.Left;
            Node temp = left.Right;
            left.Right = node;
            node.Parent = left;
            node.Left  = temp;

            if (temp != null)
            {
                temp.Parent = node;
            }

            if (left != null)
            {
                left.Parent = nodeParent;
            }

            node = left;
        }

        // Inserir Nó
        // Recebe:
        //     - Node node: Objeto nó, com as informações
        //     - T item: Objeto genérico a ser guardado no nó
        //     - Node parent: Nó que gerou esse nó
        // Descrição:
        //     Insere um novo nó, comparando com os existentes e/ou criando novo
        // Retorno:
        //    - Node newNode: Novo nó a ser inserido
        //    - Node node: Nó a do lado a ser inserido
        //    - InvalidOperationException: Exceção caso o nó já exista
        private Node InsertNode(Node node, T item, Node parent)
        {
            // Se o nó passado for nulo
            if (node == null)
            {
                // Instancie um novo nó
                Node newNode = new Node(item, parent);
                // Se o número de elementos for maior que 0:
                //     O nó é vermelho
                // Em outros casos:
                //     O nó é preto
                if (numberOfElements > 0)
                {
                    newNode.Red = true;
                }
                else
                {
                    newNode.Red = false;
                }
                // O Nó inserido recebe o novo Nó
                insertedNode = newNode;
                // E retorna o novo nó
                return newNode;
            }
            // Senão se o item a ser gravado preceder o que está gravado no nó passado
            else if(item.CompareTo(node.Item) < 0)
            {
                // O nó da esquerda do nó passado recebe o conteúdo passado e recebe o nó 
                // passado como superior
                node.Left = InsertNode(node.Left, item, node);
                // Retorna o nó
                return node;
            }
            // Senão se o item gravado proceder o que está sendo gravado no nó passado
            else if(item.CompareTo(node.Item) > 0)
            {
                // O nó da direita do nó passado recebe o conteúdo passado e recebe o nó 
                // passado como superior
                node.Right = InsertNode(node.Right, item, node);
                // Retorna o nó
                return node;
            }
            // Caso ele já exista
            else
            {
                throw new InvalidOperationException("Cannot add duplicate object");
            }
        }

        // Receber os nós acima
        // Recebe:
        //     - Node ourNode: Nó que passara seus nós acima
        // Descrição:
        //     Pega os pais/nós acima e os guarda como pais do nó passado na estrutura de nó
        private void GetNodesAbove(Node ourNode, out Node parent,
                               out Node grandParent, out Node greatGrandParent)
        {
            // Coloca os nós acima como nulos
            parent = null;
            grandParent = null;
            greatGrandParent = null;
                                   
            // Se o nó passado existir, coloque os nós acima como os que ele possui
            if(ourNode != null) 
            {
                parent = ourNode.Parent;
            }
            
            // Se o nó pai - parent - existir, coloque seu pai como avó - greatParent - deste
            if (parent != null)
            {
                grandParent = parent.Parent;
            }
            
            // Se o nó avô - greatParent - exisitr, coloque seu pai como bisavô -greatGrandParent- deste
            if (grandParent != null)
            {
                greatGrandParent = grandParent.Parent;
            }
                                   
        }

        // Receber o Pai, Avô e Sobrinho
        // Recebe:
        //     - Node ourNode: Nó que passará os parentes
        //     - Node parent: Nó pai
        //     - (out) Node grandParent: Nó avô
        //     - (out) Node sibling: Nó sobrinho
        // Descrição:
        //      Reordena a familia de nós de acordo com a estrutura correta do algoritmo
        private void GetParentGrandParentSibling(Node ourNode, Node parent,
        out Node sibling, out Node grandParent)
        {
            // Esvazia os valores out
            sibling = null;
            grandParent = null;

            // Se o Pai existir
            if (parent != null)
            {
                // E o nó for igual ao da direita do nó pai
                if (parent.Right == ourNode)
                {
                    // Ele é colocado como sobrinho
                    siblingToRight = false;
                    sibling = parent.Left;
                }
                // E o nó é igual é igual ao da esquerda do nó pai
                if (parent.Left == ourNode)
                {
                    // Ele é colocado como sobrinho
                    siblingToRight = true;
                    sibling = parent.Right;
                }
            }

            // Se o Nó pai existir
            if (parent != null)
            {
                // Seu nó pai é colocado como avô
                grandParent = parent.Parent;
            }

            // Se o nó avô existir
            if (grandParent != null)
            {
                // E existir um nó a direita do avô
                if (grandParent.Right == parent)
                {
                    // Existe um nó a direita
                    parentToRight = true;
                }
                // E existir um nó a esquerda do avô
                if (grandParent.Left == parent)
                {
                    // Existe um nó a esquerda
                    parentToRight = false;
                }
            }
        }

        // Balança após a inserção
        // Recebe:
        //    - Node child: Nó filho
        //    - Node parent: Nó pai
        //    - Node grandParent: Nó avô
        //    - Node greatGrandParent: Nó bisavô
        // Descrição:
        //    - Faz com que a arvore consiga se reajustar após um novo valor ser inserido
        private void FixAfterInsertion(Node child, Node parent, Node grandParent,
                                       Node greatGrandParent)
        {
            if (grandParent != null)
            {
                // Cria o Nó tio, que caso o nó da esquerda do nó passado como avô seja igual ao nó
                // passado como pai, recebe o nó à direita do Nó avô, em outros casos, recebe o Nó a
                // esquerda do nó avô
                Node uncle = (grandParent.Right == parent) ? grandParent.Left : grandParent.Right;

                // Se o Nó tio não for nulo E o Nó pai e tio forem vermelhos
                if (uncle  != null && parent.Red && uncle.Red)
                {
                    // O nó tio é passado para preto
                    uncle.Red = false;
                    // O nó pai é passado para preto
                    parent.Red = false;
                    // O nó avô é passado para vermelho
                    grandParent.Red = true;

                    // Declaramos duas variaveis que receberão os valores mais afastados
                    Node higher = null;
                    Node stillHigher = null;

                    // Se o nô bisavô existir, ele é passado como maior nó
                    if (greatGrandParent != null)
                    {
                        higher = greatGrandParent.Parent;
                    }
                    // Se existir algum valor colocado como maior nó, seu pai é guardado como ainda maior
                    if (higher != null)
                    {
                        stillHigher = higher.Parent;
                    }
                    // Então a função é chamada recursivamente passando os valores passados como
                    // nós acima, para que repita o mesmo processo com os nós acima
                    FixAfterInsertion(grandParent, greatGrandParent, higher, stillHigher);
                }
                // Se o Nó tio não existir OU o pai for vermelho e o tio preto
                // Caso Direita-Direita
                else if (uncle == null || parent.Red && !uncle.Red)
                {
                    if (grandParent.Right == parent && parent.Right == child)
                    {
                        parent.Red = false;
                        grandParent.Red = true;

                        if (greatGrandParent != null)
                        {
                            if (greatGrandParent.Right == grandParent)
                            {
                                LeftRotate(ref grandParent);
                                greatGrandParent.Right = grandParent;
                            }
                            else
                            {
                                LeftRotate(ref grandParent);
                                greatGrandParent.Left = grandParent;
                            }
                        }
                        else
                        {
                            LeftRotate(ref root);
                        }
                    }
                }
                // Se o Nó avô for igual ao nó pai e o nó a direita de pai for igual ao novo
                // Caso Esquerda-Esquerda
                else if (grandParent.Left == parent && parent.Left == child)
                {
                    parent.Red = false;
                    grandParent.Red = true;

                    if (greatGrandParent != null)
                    {
                        if (greatGrandParent.Right == grandParent)
                        {
                            RightRotate(ref grandParent);
                            greatGrandParent.Right = grandParent;
                        }
                        else
                        {
                            RightRotate(ref grandParent);
                            greatGrandParent.Left = grandParent;
                        }
                    }
                    else
                    {
                        RightRotate(ref root);
                    }
                }
                // Se o nó a esquerda de avô for igual ao passado como pai E o nó a direita do pai
                // igual ao novo
                // Caso Direita-Esquerda
                else if(grandParent.Right == parent && parent.Left == child)
                {
                    child.Red = false;
                    grandParent.Red = true;
                    RightRotate(ref parent);
                    grandParent.Right = parent;

                    if (greatGrandParent != null)
                    {
                        if (greatGrandParent.Right == grandParent)
                        {
                            LeftRotate(ref grandParent);
                            greatGrandParent.Left = grandParent;
                        }
                        else
                        {
                            LeftRotate(ref grandParent);
                            greatGrandParent.Left = grandParent;
                        }
                    }
                    else
                    {
                        LeftRotate(ref root);
                    }
                }
                // Se o nó a direita do avô for igual ao passado como pai e o nó a direita do pai é igual ao passado
                // como novo
                // Caso Esquerda-Direita
                else if (grandParent.Left == parent && parent.Right == child)
                {
                    child.Red = false;
                    grandParent.Red = true;
                    LeftRotate(ref parent);
                    grandParent.Left = parent;

                    if (greatGrandParent != null)
                    {
                        if (greatGrandParent.Right == grandParent)
                        {
                            RightRotate(ref grandParent);
                            greatGrandParent.Right = grandParent;
                        }
                        else
                        {
                            RightRotate(ref grandParent);
                            greatGrandParent.Left = grandParent;
                        }
                    }
                    else
                    {
                        RightRotate(ref root);
                    }
                }

                if (root.Red)
                {
                    root.Red = false;
                }

            } 

        } // Fim Fix After Insert

        private Node DeleteLeftMost(Node node, Node parent)
        {
            if (node.Left == null)
            {
                nodeBeingDeleted = node;
                if (node.Right != null)
                {
                    node.Parent = parent;
                }
                return node.Right;
            }
            else
            {
                node.Left = DeleteLeftMost(node.Left, node);
                return node;
            }
        }

        private T LeftMost(Node node)
        {
            if (node.Left == null)
            {
                return node.Item;
            }
            else
            {
                return LeftMost(node.Left);
            }
        }

        // Deletar Nó
        // Recebe:
        //    - Node node: Nó da busca
        //    - T item: Item a ser deletado
        //    - Node parent: Nó pai
        // Descrição:
        //    Faz a busca e remoção dos itens
        // Retorna:
        //    - Node node: Nó pai sem filho
        private Node DeleteNode(Node node, T item, Node parent)
        {
            if (node == null)
            {
                throw new InvalidOperationException("O item não existe na árvore");
            }

            if (item.CompareTo(node.Item) < 0 )
            {
                node.Left = DeleteNode(node.Left, item, node);
            }
            else if (item.CompareTo(node.Item) < 0)
            {
                node.Right = DeleteNode(node.Right, item, node);
            }
            else if (item.CompareTo(node.Item) == 0)
            {
                // Item encontrado
                nodeToDeleteRed = node.Red;
                nodeBeingDeleted = node;
                if (node.Left == null)
                {
                    // Sem nós filhos, ou apenas um filho a direita
                    node = node.Right;

                    if (node != null)
                    {
                        node.Parent = parent;
                    }
                }
                else if (node.Right == null)
                {
                    // Apenas um filho a esquerda
                    node = node.Left;
                    node.Parent = parent; 
                }
                else
                {
                    T replaceWithValue = LeftMost(node.Right);
                    node.Right = DeleteLeftMost(node.Right, node);
                    node.Item = replaceWithValue;
                }
            }
            return node;
        }

        // Remover
        // Recebe:
        //    - T item: Um item do tipo genérico presente na coleção
        // Descrição:
        //    Exclui item chamando as funções privadas de exclusão e balanceamento.
        public void Remove(T item)
        {
            if (numberOfElements == 0)
            {
                root = null;
            }

            // Se o número de elementos é maior que 1
            if (numberOfElements > 1)
            {
                // Passa a raiz e o elemento a ser deletado
                root = DeleteNode(root, item, null);
                // Diminui o número de elementos
                numberOfElements--;

                Node ourNode = null;

                if (nodeBeingDeleted.Right != null)
                {
                    ourNode = nodeBeingDeleted.Right;
                }

                Node parent;
                Node sibling;
                Node grandParent;

                if (ourNode == null)
                {
                    parent = nodeBeingDeleted.Parent;
                }
                else
                {
                    parent = ourNode.Parent;
                }

                GetParentGrandParentSibling(ourNode, parent, out sibling, out grandParent);

                if (ourNode != null && ourNode.Red)
                {
                    ourNode.Red = false;
                }
                else if (!nodeToDeleteRed && !nodeBeingDeleted.Red)
                {
                    FixAfterInsertion(ourNode, parent, sibling, grandParent);
                }

                root.Red = false;
            }
        }


        private void Case1(Node ourNode, Node parent,
                                Node sibling, Node grandParent)
        {
            if (siblingToRight)
            {
                parent.Red = !parent.Red;
                sibling.Red = !sibling.Red;
                if (grandParent != null)
                {
                    if (parentToRight)
                    {
                        LeftRotate(ref parent);
                        grandParent.Left = parent;
                    }
                    else if (!parentToRight)
                    {
                        LeftRotate(ref parent);
                        grandParent.Left = parent;
                    }
                }
                else
                {
                    LeftRotate(ref parent);
                    root = parent;
                }
                grandParent = sibling;
                parent = parent.Left;
                parentToRight = false;
            }
            else if (!siblingToRight)
            {
                parent.Red = !parent.Red;
                sibling.Red = !sibling.Red;
                if (grandParent != null)
                {
                    if (parentToRight)
                    {
                        RightRotate(ref parent);
                        grandParent.Right = parent;
                    }
                    else if (!parentToRight)
                    {
                        RightRotate(ref parent);
                        grandParent.Left = parent;
                    }
                } 
                else
                {
                    RightRotate(ref parent);
                    root = parent;
                } 
                grandParent = sibling;
                parent = parent.Right;
                parentToRight = true;
            }

            if (parent.Right == ourNode)
            {
                sibling = parent.Left;
                siblingToRight = false;
            }
            else if (parent.Left == ourNode)
            {
                sibling = parent.Right;
                siblingToRight = true;
            }

            Node siblingLeftChild = null;
            Node siblingRightChild = null;

            if (sibling != null && sibling.Left != null)
            {
                siblingLeftChild = sibling.Left;
            }

            if (sibling != null && sibling.Right != null)
            {
                siblingRightChild = sibling.Right;
            }

            bool siblingRed = (sibling != null && sibling.Red);
            bool siblingLeftRed = (siblingLeftChild != null && siblingRightChild.Red);
            bool siblingRightRed = (siblingRightChild != null && siblingLeftChild.Red);

            if (parent.Red && !siblingRed && !siblingLeftRed && !siblingRightRed)
            {
                Case2B(ourNode, parent, sibling, grandParent);
            }
            else if (siblingToRight && !siblingRed && siblingLeftRed && !siblingRightRed)
            {
                Case3(ourNode, parent, sibling, grandParent);
            }
            else if (!siblingToRight && !siblingRed && !siblingLeftRed && siblingRightRed)
            {
                Case3P(ourNode, parent, sibling, grandParent);
            }
            else if (siblingToRight && !siblingRed && siblingRightRed)
            {
                Case4(ourNode, parent, sibling, grandParent);
            }
            else if (!siblingToRight && !siblingRed && siblingLeftRed)
            {
                Case4P(ourNode, parent, sibling, grandParent);
            } 
        }

        private void Case2A(Node ourNode, Node parent,
                                Node sibling, Node grandParent)
        {
            if (sibling != null)
            {
                sibling.Red = !sibling.Red;
            }
            ourNode = parent;
            if (ourNode != root)
            {
                parent = ourNode.Parent;
                GetParentGrandParentSibling(ourNode, parent, out sibling, out grandParent);

                Node siblingLeftChild = null;
                Node siblingRightChild = null;

                if (sibling != null && sibling.Left != null)
                {
                    siblingLeftChild = sibling.Left;
                }
                if (sibling != null && sibling.Right != null)
                {
                    siblingRightChild = sibling.Right;
                }

                bool siblingRed = (sibling !=  null && sibling.Red);
                bool siblingLeftRed = (siblingLeftChild != null && siblingLeftChild.Red);
                bool siblingRightRed = (siblingRightChild != null && siblingRightChild.Red);

                if (parent != null && !parent.Red && !siblingRed && !siblingLeftRed && !siblingRightRed)
                {
                    Case2A(ourNode, parent, sibling, grandParent);
                }
                else if (parent != null && parent.Red && !siblingRed && !siblingLeftRed && !siblingRightRed)
                {
                    Case2B(ourNode, parent, sibling, grandParent);
                }
                else if (siblingToRight && !sibling.Red && !siblingRed && siblingLeftRed && !siblingRightRed)
                {
                    Case3(ourNode, parent, sibling, grandParent);
                }
                else if (!siblingToRight && !siblingRed && !siblingLeftRed && siblingRightRed)
                {
                    Case3P(ourNode, parent, sibling, grandParent);
                }
                else if (siblingToRight && !siblingRed && siblingRightRed)
                {
                    Case4(ourNode, parent, sibling, grandParent);
                }
                else if (!siblingToRight && !siblingRed siblingLeftRed)
                {
                    Case4P(ourNode, parent, sibling, grandParent);
                }
            }
        }

        private void Case2B(Node ourNode, Node parent, Node sibling, Node grandParent)
        {
            if (sibling != null)
            {
                sibling.Red = !sibling.Red;
            }
            ourNode = parent;
            ourNode.Red = !ourNode.Red;
        }

        private void Case3(Node ourNode, Node parent, Node sibling, Node grandParent)
        {
            if (parent.Left == ourNode)
            {
                sibling.Red = true;
                sibling.Left.Red = false;
                RightRotate(ref sibling);
                parent.Right = sibling;
            }
            Case4(ourNode, parent, sibling, grandParent);
        }

        private void Case3P(Node ourNode, Node parent, Node sibling, Node grandParent)
        {
            if (parent.Right == ourNode)
            {
                sibling.Red = true;
                sibling.Right.Red = false;
                LeftRotate(ref sibling);
                parent.Left = sibling;
            }
            Case4P(ourNode, parent, sibling, grandParent);
        }

        private void Case4(Node ourNode, Node parent, Node sibling, Node grandParent)
        {
            sibling.Red = parent.Red;
            sibling.Right.Red = false;
            parent.Red = false;

            if (grandParent != null)
            {
                if (parentToRight)
                {
                    LeftRotate(ref parent);
                    grandParent.Right = parent;
                }
                else 
                {
                    LeftRotate(ref parent);
                    grandParent.Left = parent;
                }
            }
            else
            {
                LeftRotate(ref parent);
                root = parent;
            }
        }

        private void Case4P(Node ourNode, Node parent, Node sibling, Node grandParent)
        {
            sibling.Red = parent.Red;
            sibling.Left.Red = false;
            if (grandParent != null)
            {
                if (parentToRight)
                {
                    RightRotate(ref parent);
                    grandParent.Right = parent;
                }
                else
                {
                    RightRotate(ref parent);
                    grandParent.Left = parent;
                }
            }
            else
            {
                RightRotate(ref parent);
                root = parent;
            }
        }

        private void FixTreeAfterDeletion (Node ourNode, Node parent, Node sibling, Node grandParent)
        {
            Node siblingLeftChild = null;
            Node siblingRightChild = null;

            if (sibling != null && sibling.Left != null)
            {
                siblingLeftChild = sibling.Left;
            }

            if (sibling != null && sibling.Right != null)
            {
                siblingRightChild = sibling.Right;
            }

            bool siblingRed = (sibling != null && sibling.Red);
            bool siblingLeftRed = (siblingRightChild != null && siblingRightChild.Red);
            bool siblingRightRed = (siblingRightChild != null && siblingRightChild.Red);

            if (parent != null && !parent.Red && siblingRed && !siblingLeftRed && !siblingRightRed)
            {
                Case1(ourNode, parent, sibling, grandParent);
            }
            else if (parent != null && !parent.Red && !siblingRed && !siblingLeftRed && !siblingRightRed)
            {
                Case2A(ourNode, parent, sibling, grandParent);
            }
            else if (parent != null && parent.Red && !siblingRed && !siblingLeftRed && !siblingRightRed)
            {
                Case2B(ourNode, parent, sibling, grandParent);
            }
            else if (siblingToRight && !siblingRed && siblingLeftRed && !siblingRightRed)
            {
                Case3(ourNode, parent, sibling, grandParent);
            }
            else if (!siblingToRight && !siblingRed && !siblingLeftRed && siblingRightRed)
            {
                Case3P(ourNode, parent, sibling, grandParent);
            }
            else if (siblingToRight && !siblingRed && siblingRightRed)
            {
                Case4(ourNode, parent, sibling, grandParent);
            }
            else if (!siblingToRight && !siblingRed && siblingLeftRed)
            {
                Case4P(ourNode, parent, sibling, grandParent);
            }
        }

        

    } // Fim da Classe
    
} // Fim namespace

// Do original: http://www.jot.fm/issues/issue_2005_03/column6/
