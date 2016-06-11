using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SST
{
    class SSTAlgorithm
    {
        private static SSTAlgorithm instance = null;
        private static TreeView tree;
        private SSTAlgorithm(TreeView treev)
        {
            tree = treev;
        }
        public static SSTAlgorithm getInstance(TreeView tree)
        {
            if (instance == null)
            {
                instance = new SSTAlgorithm(tree);
            }
            return instance;
        }
        public  void rootAlgo(Node node)
        {
            node.Distance = 0;
            foreach (Node child in node.Childs)
            {
                child.Distance = 1;
            }
        }
        public  void nonRootAlgo(Node node)
        {
            /** we need its parent also , so if have one we will add it then remove it*/
            if (node.Parent != null)
            {
                node.Childs.Add(node.Parent);
            }
            List<Double> childernDistances = new List<double>(node.Childs.Count);
            double minDistance = Double.MaxValue;
            bool found = false;
            foreach (Node child in node.Childs)
            {
                childernDistances.Add(child.Distance);
                if (child.Distance < minDistance)
                {
                    minDistance = child.Distance;
                }
            }
            minDistance += 1;
            foreach (Node child in node.Childs)
            {
                if (!found && minDistance == (child.Distance + 1))
                {
                    /** here we change the parent and the distance of the node*/
                    Node newNode = new Node(node.Name, child, minDistance, node.X, node.Y);
                    Node.updateNode(tree, newNode, node);
                    found = true;
                }
                else
                {
                    /** just update the distance*/
                    child.Distance = minDistance;

                }
            }

            /** if we added the parent we need to remove it*/
            if (node.Parent != null)
            {
                node.Childs.Remove(node.Parent);
            }

        }
    }
}
