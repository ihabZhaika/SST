using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SST
{
    class Node
    {
        String name;
        Node parent;
        List<Node> childs;
        double distance;
        int x, y;
        public const int RADIUS = 25;
        Color background { get; set; } = Color.DarkBlue;
        SolidBrush solidBrush;
        Pen pen;

        public Node(Node node) : this(node.name,node.parent,node.distance,node.x,node.y)
        {
            foreach(Node subNode in node.childs)
            {
                childs.Add(new Node(subNode));
            }

        }
        public Node(String name, Node parent, double distance, List<Node> childs, int x, int y) : this(name, parent, distance, x, y)
        {
            this.childs = childs;
        }

        public Node(String name, Node parent, double distance, int x, int y)
        {
            this.Name = name;
            this.Parent = parent;
            this.Distance = distance;
            this.X = x;
            this.Y = y;
            Childs = new List<Node>();
            solidBrush = new SolidBrush(background);
            pen = new Pen(solidBrush, 3);
        }
        // override object.Equals
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            if (Name.Equals(((Node)obj).Name))
            {
                return true;
            }
            return false;

        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public void addChild(Node child)
        {
            Childs.Add(child);
        }
        public void removeChild(Node child)
        {
            Childs.Remove(child);
        }
        public void draw(Graphics g)
        {
            /** draw the circle*/
            g.DrawEllipse(pen, new Rectangle(x, y, RADIUS, RADIUS));
            /** write the name*/
            g.DrawString(Name, new Font(FontFamily.GenericSerif, 18), new SolidBrush(Color.Yellow), new PointF(x, Y - RADIUS));
            /** write the distance*/
            g.DrawString(distance.ToString(), new Font(FontFamily.GenericSerif, 18), new SolidBrush(Color.Red), new PointF(x, Y + RADIUS));

            linkChilds(g);
        }
        private void linkChilds(Graphics g)
        {
            foreach (Node node in childs)
            {
                g.DrawLine(pen, new Point(x + (RADIUS / 2), y + (RADIUS / 2)), new Point(node.x + (RADIUS / 2), node.y + (RADIUS / 2)));
            }

        }

        public static void addNodeToTree(Node node, TreeNodeCollection srcTreeNodes)
        {
            foreach (TreeNode treeNode in srcTreeNodes)
            {
                if (treeNode.Text.Equals(node.Parent.Name))
                {
                    addNodeToTree(node, treeNode);
                }
            }
        }
        public static void addNodeToTree(Node node, TreeNode srcTreeNode)
        {
            srcTreeNode.Nodes.Add(node.Name);
        }
        public static void addChildsToParentOnTree(TreeView tree, Node parentNode)
        {

            foreach (TreeNode treeNode in tree.Nodes)
            {
                if (treeNode.Text.Equals(parentNode.name))
                {
                    treeNode.Nodes.Clear();
                
                    foreach (Node node in parentNode.childs)
                    {
                        treeNode.Nodes.Add(node.name);
                    }
                }

            }
        }

        public static bool isChildsEqual(Node a, Node b)
        {
            try
            {
                Dictionary<Node, int> map = new Dictionary<Node, int>();
                foreach (Node subNode in a.childs)
                {
                    map.Add(subNode, 1);
                }
                foreach (Node subNode in b.childs)
                {
                    if (map.ContainsKey(subNode))
                    {
                        map[subNode] = 2;
                    }
                }

                foreach (Node node in map.Keys)
                {
                    if (map[node] == 1)
                    {
                        return false;
                    }
                }
                return true;

            }
            catch(Exception e)
            {
                return false;
            }

        }

        public static void updateNode(TreeView tree, Node newNode, Node currentNode)
        {
            /** we check if parent get changed , we will update the tree*/
            if (!Node.isChildsEqual(newNode, currentNode))
            {
                /** change the tree view*/
                Node.addChildsToParentOnTree(tree, newNode);
            }
            if (!currentNode.Distance.Equals(newNode.Distance))
            {
                currentNode.Distance = newNode.Distance;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        internal Node Parent
        {
            get
            {
                return parent;
            }

            set
            {
                parent = value;
            }
        }

        internal List<Node> Childs
        {
            get
            {
                return childs;
            }

            set
            {
                childs = value;
            }
        }

        public double Distance
        {
            get
            {
                return distance;
            }

            set
            {
                distance = value;
            }
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }


    }
}
