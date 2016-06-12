using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SST
{
    public partial class frm_main : Form
    {
        Boolean isCreating = true;
        int xGlobal, yGlobal;
        List<Node> nodes;
        public frm_main()
        {
            InitializeComponent();
            nodes = new List<Node>();
        }

        private void pnl_drawing_Paint(object sender, PaintEventArgs e)
        {
            drawNodes(e.Graphics);

        }
        private void drawNodes(Graphics g)
        {
            foreach (Node node in nodes)
            {
                node.draw(g);
            }
        }
        /** to add or edit a node*/
        private void btn_action_Click(object sender, EventArgs e)
        {

            object[] data = getData();
            if (data == null)
            {
                MessageBox.Show("Check the data and try again");
            }
            else
            {
                /**create node from the data*/
                Node node = new Node(data[0].ToString(), (Node)data[1], (double)data[2], (List<Node>)data[3], xGlobal, yGlobal);

                if (isCreating)
                {
                    /** chek if the node do exist*/
                    if (nodes.Contains(node))
                    {
                        MessageBox.Show("This node already exist");
                        return;
                    }

                    /** add it to nodes list*/
                    nodes.Add(node);

                    /** add a seperate node for it*/
                    int index = treeView_nodes.Nodes.Add(new TreeNode(node.Name));
                    foreach (Node subNode in node.Childs)
                    {
                        Node.addNodeToTree(subNode, treeView_nodes.Nodes[index]);

                    }
                    combo_parent.Items.Add(node.Name);

                }
                else
                {
                    Node currentNode = nodes[nodes.IndexOf(node)];
                    node.X = currentNode.X;
                    node.Y = currentNode.Y;
                    foreach (Node subNode in node.Childs)
                    {
                        if(!currentNode.Childs.Contains(subNode))
                        {
                            Node newInstanceOfSubnode = new Node(subNode);
                            newInstanceOfSubnode.addChild(node);
                            Node.updateNode(treeView_nodes, newInstanceOfSubnode, subNode);
                            nodes[nodes.IndexOf(subNode)] = newInstanceOfSubnode;
                        }
                    }

                    //foreach (Node nodee in node.Childs)
                    //{
                    //    Node newNode = new Node(nodee);
                    //    newNode.addChild(node);
                    //    Node.updateNode(treeView_nodes, newNode, nodee);
                    //    nodes[nodes.IndexOf(nodee)] = newNode;

                    //}
                    Node.updateNode(treeView_nodes, node, currentNode);
                    nodes[nodes.IndexOf(node)] = node;

                }

            }
            pnl_drawing.Refresh();

        }



        private void setData(String name, Node parent, double distance, List<Node> childs)
        {
            txt_nodeName.Text = name;
            int parentIndex = nodes.IndexOf(parent);
            combo_parent.SelectedIndex = (parentIndex);
            txt_distance.Text = distance.ToString();
            txt_childs.Text = "";
            foreach (Node node in childs)
            {
                txt_childs.Text += node.Name + ",";
            }
            if (txt_childs.Text.Length > 0)
            {
                txt_childs.Text = txt_childs.Text.Substring(0, txt_childs.Text.Length - 1);
            }
        }
        private object[] getData()
        {
            double distance = 0;
            if (txt_nodeName.TextLength == 0 || txt_distance.TextLength == 0 || !Double.TryParse(txt_distance.Text, out distance))
            {
                return null;
            }
            Object[] data = new object[4];
            data[0] = txt_nodeName.Text;
            if (combo_parent.SelectedIndex != -1)
            {
                data[1] = combo_parent.Items[combo_parent.SelectedIndex];
                foreach (Node node in nodes)
                {
                    if (node.Name.Equals(data[1].ToString()))
                    {
                        data[1] = node;
                        break;
                    }
                }
            }

            data[2] = distance;
            data[3] = parseChildsString(txt_childs.Text);
            return data;

        }

        private List<Node> parseChildsString(String chidls)
        {
            List<Node> parsedChilds = new List<Node>();
            char[] separators = { ',' };
            String[] childsSeparated = chidls.Split(separators);
            foreach (String child in childsSeparated)
            {
                /** not empty string*/
                if (child.Length > 0)
                {
                    foreach (Node node in nodes)
                    {
                        if (node.Name.Equals(child))
                        {
                            parsedChilds.Add(node);
                        }
                    }

                }
            }
            return parsedChilds;

        }

        /** we get the mouse x, y in order to know where to add the node*/
        private void pnl_drawing_MouseClick(object sender, MouseEventArgs e)
        {
            lbl_xPosition.Text = (xGlobal = e.X).ToString();
            lbl_yPosition.Text = (yGlobal = e.Y).ToString();

            /** check if there node on this point*/
            Node node = getNodeOnGraph(xGlobal, yGlobal);
            /** if there is node , we want to load its data*/
            if (node != null)
            {
                setData(node.Name, node.Parent, node.Distance, node.Childs);
                isCreating = false;
                txt_nodeName.ReadOnly = true;
                btn_action.Text = " Update";
            }
            else
            {
                isCreating = true;
                txt_nodeName.ReadOnly = false;
                btn_action.Text = " Create";

            }

        }
        /** return the node that exist on the x,y*/
        private Node getNodeOnGraph(int x, int y)
        {
            foreach (Node node in nodes)
            {
                if (inNode(node, x, y))
                {
                    return node;
                }
            }
            return null;
        }
        /** checks if in this X,Y there is a node*/
        private Boolean inNode(Node node, int x, int y)
        {
            if (x >= node.X && x <= node.X + (2 * Node.RADIUS) && y >= node.Y && y <= node.Y + (2 * Node.RADIUS))
            {
                return true;
            }
            return false;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            foreach (Node node in nodes)
            {
                /** this is the root*/
                if (node.Parent == null)
                {
                    SSTAlgorithm.getInstance(treeView_nodes).rootAlgo(node);

                }
                else
                {
                    SSTAlgorithm.getInstance(treeView_nodes).nonRootAlgo(node);

                }
                pnl_drawing.Refresh();

            }
        }

        private void fillDataIntoFields(String name, Node parent, double distance)
        {
            txt_nodeName.Text = name;
            txt_distance.Text = distance.ToString();
            combo_parent.SelectedIndex = combo_parent.FindStringExact(parent.Name);

        }
    }
}
