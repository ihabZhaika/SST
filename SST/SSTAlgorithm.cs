using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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
        private static Dictionary<Node, Node> redPath;

        private SSTAlgorithm(TreeView treev)
        {
            tree = treev;
            RedPath = new Dictionary<Node, Node>();
        }
        public static SSTAlgorithm getInstance(TreeView tree)
        {
            if (instance == null)
            {
                instance = new SSTAlgorithm(tree);
            }
            return instance;
        }
        public void rootAlgo(Node node)
        {
            clearPath();
            node.Distance = 0;
            foreach (Node child in node.Childs)
            {
                child.Distance = 0;
            }
        }
        public void nonRootAlgo(Node node)
        {

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
                    node.Distance = minDistance;
                    /** here we mark it to be colored*/
                    if (!redPath.ContainsKey(node))
                    {
                        redPath.Add(node, child);
                    }
                    else
                    {
                        redPath[node] = child;
                    }
                    found = true;
                }
                else
                {
                    /** just update the distance*/
                  if(child.Distance!=minDistance)
                    {
                        if (minDistance < child.Distance)
                        {
                    child.Distance = minDistance+1;

                        }
                    }
                    
                }
            }

        }
        public void clearPath()
        {
            redPath.Clear();
        }
        public void drawPath(Graphics g)
        {

            foreach (Node key in redPath.Keys)
            {
                Node parent = new Node(key);
                parent.Childs.Clear();
                parent.addChild(redPath[key]);
                parent.draw(g, true);
            }
        }
        internal static Dictionary<Node, Node> RedPath
        {
            get
            {
                return redPath;
            }

            set
            {
                redPath = value;
            }
        }
    }
}
