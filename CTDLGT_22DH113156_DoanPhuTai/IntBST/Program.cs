using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntBST
{
    internal class Program
    {
        static void TestInput()
        {
            MyBinaryTree root = new MyBinaryTree();
            root.Input();
            Console.WriteLine("Duyet cay theo thu tu NLR");
            root.PreOrder();
        }
        static void Main(string[] args)
        {
            TestInput();
        }
    }
}
