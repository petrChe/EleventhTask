using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleventhTask
{
    class StudentBinaryTree
    {
        public Node Root { get; set; }

        public StudentBinaryTree()
        {
            Root = null;
        }

        public bool IsEmpty(Node node)
        {
            return node == null;
        }

        public void InsertIntoTree(Student student)
        {
            if (IsEmpty(Root))
            {
                Root = new Node(student);
            }
            else
            {
                Node currentNode = Root;
                Node parent;

                while (true)
                {
                    parent = currentNode;
                    if (student.Mark < currentNode.Student.Mark)
                    {
                        currentNode = currentNode.LeftNode;
                        if (IsEmpty(currentNode))
                        {
                            parent.LeftNode = new Node(student);
                            return;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.RightNode;
                        if (IsEmpty(currentNode))
                        {
                            parent.RightNode = new Node(student);
                            return;
                        }
                    }
                    }
                }
            }
        

        public void PrintInOrder(Node root)
        {
            if (!IsEmpty(root))
            {
                PrintInOrder(root.LeftNode);
                root.Display();
                PrintInOrder(root.RightNode);
            }
        }
    }
}
