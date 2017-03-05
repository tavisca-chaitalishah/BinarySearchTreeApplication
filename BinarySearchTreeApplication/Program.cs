using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeApplication
{
    
   
    class Program
    {
        static void Main(string[] args)
        {
            Tree treeObject = new Tree();
            treeObject.Insert(20);
            treeObject.Insert(25);
            treeObject.Insert(45);
            treeObject.Insert(15);
            treeObject.Insert(67);
            treeObject.Insert(43);
            treeObject.Insert(80);
            treeObject.Insert(33);
            treeObject.Insert(67);
            treeObject.Insert(99);
            treeObject.Insert(91);
            Console.WriteLine("Inorder Traversal : ");
            treeObject.Inorder(treeObject.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Preorder Traversal : ");
            treeObject.Preorder(treeObject.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Postorder Traversal : ");
            treeObject.Postorder(treeObject.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine("Thankyou");
            Console.ReadLine();
        }
    }
}
