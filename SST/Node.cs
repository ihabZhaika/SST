using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            g.DrawEllipse(pen, new Rectangle(x, y, RADIUS, RADIUS));
            linkChilds(g);
        }
        private void linkChilds(Graphics g)
        {
            foreach(Node node in childs)
            {
                g.DrawLine(pen, new Point(x, y), new Point(node.x, node.y));
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
