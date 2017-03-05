using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeApplication
{
    class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void Insert(int number)
        {
            Node newNode = new Node();
            newNode.value = number;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (number < current.value)
                    {
                        current = current.leftNode;
                        if (current == null)
                        {
                            parent.leftNode = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightNode;
                        if (current == null)
                        {
                            parent.rightNode = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public void Preorder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.value + " ");
                Preorder(Root.leftNode);
                Preorder(Root.rightNode);
            }
        }
        public void Inorder(Node Root)
        {
            if (Root != null)
            {
                Inorder(Root.leftNode);
                Console.Write(Root.value + " ");
                Inorder(Root.rightNode);
            }
        }
        public void Postorder(Node Root)
        {
            if (Root != null)
            {
                Postorder(Root.leftNode);
                Postorder(Root.rightNode);
                Console.Write(Root.value + " ");
            }
        }
    }
}
