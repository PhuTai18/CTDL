using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntBST
{
    internal class MyBinaryTree
    {
        private IntTNode root;

        public IntTNode Root
        {
            get { return root; }
            set { root = value; }
        }
        public MyBinaryTree()
        {
            Root = null;
        }
        public bool Insert(int x)
        {
            if (Root == null)
            {
                Root = new IntTNode(x);
                return true;
            }
            return Root.InsertNode(x);
        }
        public void Input()
        {
            do
            {
                int x;
                Console.Write("Nhap vao gia tri (trung ket thuc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (Insert(x) == true)
                    Console.WriteLine("Da them gia tri vao cay");
                else
                {
                    Console.WriteLine("Gia tri bi trung, ket thuc");
                    return;
                }
            } while (true);
        }
        public void PreOrder()
        {
            if (Root == null)
                return;
            Root.NLR();
            Console.WriteLine();
        }
    }
}
