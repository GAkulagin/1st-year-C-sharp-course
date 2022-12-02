using System;
using System.Collections.Generic;
using MyLibrary;

namespace Laba12
{
    public class BinaryTree
    {
        TreePoint root = null;
        public List<Person> list = new List<Person>();

        public int Count
        {
            get
            {
                if (list == null) return 0;
                else return list.Count;
            }
        }

        public TreePoint Root
        {
            get { return root; }
            set { root = value; }
        }

        public BinaryTree()
        {
            root = null;
        }

        public BinaryTree(params Person[] arr)
        {
            foreach (Person p in arr) list.Add(p);

            int position = 0;

            root = IdealTree(arr.Length, root, ref position);
        }


        public void Add(TreePoint root, Person value)
        {
            TreePoint temp = root;
            TreePoint point = null;
            bool equal = false;

            while(temp != null && !equal)
            {
                point = temp;
                if (value.CompareTo(temp.data) == 0) equal = true;
                else if (value.CompareTo(temp.data) < 0) temp = temp.left;
                else temp = temp.right;
            }

            if (equal) throw new Exception("Одинаковые элементы недопустимы в дереве поиска");

            TreePoint newPoint = new TreePoint(value);
            if (value.CompareTo(point.data) < 0) point.left = newPoint;
            else point.right = newPoint;
        }

        public void Delete(TreePoint point)
        {
            if (Root.left == null && Root.right == null)
            {
                root = null;
                list = null;
                return;
            }

            TreePoint temp = new TreePoint();

            if (point.left == null && point.right != null)
            {
                temp = point.right;
                if (temp.left == null && temp.right == null)
                {
                    point.right = null;
                    Delete(Root);
                }
                else Delete(point.right);
            }
            else if (point.left != null)
            {
                temp = point.left;
                if(temp.left == null && temp.right == null)
                {
                    point.left = null;
                    Delete(Root);
                }
                else Delete(point.left);
            }
        }

        public void GetAgeSum(TreePoint point, ref double ageSum)
        {
            if(point != null)
            {
                ageSum += point.data.Age;
                GetAgeSum(point.left, ref ageSum);
                GetAgeSum(point.right, ref ageSum);
            }
        }

        public TreePoint IdealTree(int size, TreePoint point, ref int position)
        {
            int leftSide;
            int rightSide;
            TreePoint newRoot;

            if (size == 0)
            {
                point = null;
                return point;
            }

            leftSide = size / 2;
            rightSide = size - leftSide - 1;

            newRoot = new TreePoint(list[position]);
            position++;

            newRoot.left = IdealTree(leftSide, newRoot.left, ref position);

            newRoot.right = IdealTree(rightSide, newRoot.right, ref position);

            return newRoot;
        }

        public BinaryTree SearchTree()
        {
            BinaryTree searchTree = new BinaryTree();
            searchTree.Root = new TreePoint(list[0]);

            for (int i = 1; i < list.Count; i++)
                searchTree.Add(searchTree.Root, list[i]);

            return searchTree;
        }

        public void Print(TreePoint point)
        {
            if (point != null)
            {
                Console.WriteLine(point);
                Print(point.left);
                Print(point.right);
            }
        }
    }
}
