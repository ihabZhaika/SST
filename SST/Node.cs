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
        public  const int RADIUS = 25;
        Color background { get; set; } = Color.DarkBlue;
        SolidBrush solidBrush;
        Pen pen;



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
            if(Name.Equals(((Node)obj).Name))
            {
                return true;
            }
            return false;

        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
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
            g.DrawString(Name, new Font(FontFamily.GenericSerif, 18), new SolidBrush(Color.Yellow), new PointF(x , Y-RADIUS ));
            /** write the distance*/
            g.DrawString(distance.ToString(), new Font(FontFamily.GenericSerif, 18), new SolidBrush(Color.Red), new PointF(x, Y + RADIUS));

            linkChilds(g);
        }
        private void linkChilds(Graphics g)
        {
            foreach(Node node in childs)
            {
                g.DrawLine(pen, new Point(x+(RADIUS / 2),y+ (RADIUS / 2)), new Point(node.x+ (RADIUS / 2), node.y+ (RADIUS / 2)));
            }

        }

        public static void addNodeToTree(Node node, TreeNodeCollection srcTreeNodes)
        {
            foreach (TreeNode treeNode in srcTreeNodes)
            {
                if (treeNode.Text.Equals(node.Parent.Name))
                {
                    treeNode.Nodes.Add(node.Name);
                }
            }
        }
        public static void  addNodeToTree(Node node, TreeNode srcTreeNode)
        {
            srcTreeNode.Nodes.Add(node.Name);
        }
        public static void changeNodeParentOnTree(TreeView tree,Node node, Node oldParent, Node newParent)
        {

            foreach (TreeNode treeNode in tree.Nodes)
            {
                if (oldParent != null && treeNode.Text.Equals(oldParent.Name))
                {
                    removeNodeFromTree(node, treeNode);
                }
                if (newParent != null && treeNode.Text.Equals(newParent.Name))
                {
                    addNodeToTree(node, treeNode);

                }
            }
        }

        private static void removeNodeFromTree(Node node, TreeNode sourceTreeNode)
        {
            foreach (TreeNode treeNode in sourceTreeNode.Nodes)
            {
                if (treeNode != null && treeNode.Text.Equals(node.Name))
                {
                    sourceTreeNode.Nodes.Remove(treeNode);
                }
            }
        }

        public static  void updateNode(TreeView tree, Node newNode, Node currentNode)
        {
            /** we check if parent get changed , we will update the tree*/
            if ( ((newNode.Parent != null && !newNode.Parent.Equals(currentNode.Parent)) || (currentNode.Parent != null && !currentNode.Parent.Equals(newNode.Parent))))
            {

                /** change the tree view*/
                Node.changeNodeParentOnTree(tree, currentNode, currentNode.Parent, newNode.Parent);
                /** we need to remove the node from its parent*/
                if (currentNode.Parent != null)
                {
                    currentNode.Parent.Childs.Remove(currentNode);

                }
                if (newNode.Parent != null)
                {
                    newNode.Parent.Childs.Add(currentNode);

                }
                currentNode.Parent = newNode.Parent;


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
