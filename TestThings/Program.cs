using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace TestThings
{
    public class Program
    {
        public class BinarySearchTree
        {
            public Node Root;

            public BinarySearchTree()
            {
                Root = null;
            }

            public void Insert(Node newNode)
            {
                if (newNode == null)
                    return;
                else
                {
                    if (Root == null)
                    {
                        Root = newNode;
                        return;
                    }
                    else
                    {
                        AddNewLeafNode(Root);
                    }
                }

                void AddNewLeafNode(Node node)
                {
                    if (newNode.Data < node.Data)
                    {
                        if (node.Left == null)
                        {
                            node.Left = newNode;
                        }
                        else
                        {
                            AddNewLeafNode(node.Left);
                        }
                    }
                    else
                    {
                        if (node.Right == null)
                        {
                            node.Right = newNode;
                        }
                        else
                        {
                            AddNewLeafNode(node.Right);
                        }
                    }
                }

            }
        }

        public class Node
        {
            public int Data;
            public Node Left;
            public Node Right;

            public Node(int i)
            {
                Data = i;
            }
        }

        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(new Node(5));
            bst.Insert(new Node(3));
            bst.Insert(new Node(1));
            bst.Insert(new Node(7));
            bst.Insert(new Node(2));
            bst.Insert(new Node(1));
            bst.Insert(new Node(10));

            Console.WriteLine(Total(bst.Root));
            Console.Read();
        }


        public static int Total(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            var leftNodeTotal = Total(node.Left);
            var rightNodeTotal = Total(node.Right);

            return node.Data + leftNodeTotal + rightNodeTotal;
        }
    }

}
